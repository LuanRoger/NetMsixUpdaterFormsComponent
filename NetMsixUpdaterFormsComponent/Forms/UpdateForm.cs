using NetMsixUpdater;
using System;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetMsixUpdater.Updater.Extensions.MsixUpdater;
using NetMsixUpdater.YamlInfo.Models;
using NetMsixUpdaterFormsComponent.Enum;

#nullable enable
// ReSharper disable once MemberCanBePrivate.Global
// ReSharper disable MemberCanBePrivate.Global

namespace NetMsixUpdaterFormsComponent.Forms
{
    public sealed partial class UpdateForm : Form
    {
        /// <summary>
        /// <c>MsixUpdater</c> used by the package to verify, download and install updates.
        /// </summary>
        /// <seealso cref="https://www.nuget.org/packages/NetMsixUpdater"/>
        public MsixUpdater msixUpdater { get; }
        /// <summary>
        /// Name of the program used in the main text of the window.
        /// If null, the name chosen will be the Assembly name.
        /// </summary>
        private string? customProgramName { get; }
        /// <summary>
        /// When calling the <c>Start</c> method, it shows a dialog box if the program is already updated.
        /// Default: <c>true</c>
        /// </summary>
        public bool showUpdateState { get; set; } = true;
        /// <summary>
        /// Download the update asynchronously.
        /// Default: <c>true</c>
        /// </summary>
        public bool asyncUpdate { get; set; } = true;
        /// <summary>
        /// The way the updater will handle mandatory updates.
        /// 
        /// <list>
        ///     <item>
        ///     <term>ImposibleToUse</term>
        ///         <description>
        ///         The user is unable to use the program.
        ///         </description>
        ///     </item>
        ///     <item>
        ///     <term>AutoUpdate</term>
        ///         <description>
        ///         The program is updated automatically, the user does't need to click to update manually.
        ///         </description>
        ///     </item>
        /// </list>
        /// </summary>
        public MandatoryType mandatoryType { get; set; } = MandatoryType.ImposibleToUse;

        /// <summary>
        /// Intance a new <c>UpdateForm</c>.
        /// </summary>
        /// <param name="msixUpdater">The instance of the <c>MsixUpdater</c> class.</param>
        /// <param name="customProgramName">This name will override the program name of the assembly.</param>
        public UpdateForm(MsixUpdater msixUpdater, string customProgramName = null)
        {
            InitializeComponent();
            
            this.msixUpdater = msixUpdater;
            this.msixUpdater.Build();
            this.customProgramName = customProgramName;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = string.Format(lblTitle.Text,
                customProgramName ?? Assembly.GetEntryAssembly()!.GetName().Name);
            
            lblUpdateInfo.Text = string.Format(lblUpdateInfo.Text, 
                Assembly.GetExecutingAssembly().GetName().Version,
                msixUpdater.currentChannelInfo.version);
            
            wbvChangelog.Source = new(msixUpdater.currentChannelInfo.changelog);

            foreach (string channelName in msixUpdater.yamlUpdateInfo.channels.Keys)
                cmbUpdateChannels.Items.Add(channelName);
            cmbUpdateChannels.SelectedItem = msixUpdater.currentUpdateChannel;

            UpdateExtension.OnDownloadStart += UpdateExtensionOnOnDownloadStart;
            UpdateExtension.OnUpdateDownloadProgresssChange += UpdateExtensionOnOnUpdateDownloadProgresssChange;
            UpdateExtension.OnDownlaodComplete += UpdateExtensionOnOnDownlaodComplete;
        }
        private void UpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!msixUpdater.currentChannelInfo.mandatory || mandatoryType != MandatoryType.ImposibleToUse) return;
            
            DialogResult dialogResult = MessageBox.Show("This update is mandatory and you can't use the program in an old version",
                "Information",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Cancel)
                Environment.Exit(0);
            else e.Cancel = true;
        }
        
        private void cmbUpdateChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            msixUpdater.currentUpdateChannel = cmbUpdateChannels.Text;
            msixUpdater.Build();
        }

        /// <summary>
        /// Show the update form if have any update available.
        /// </summary>
        public void Start()
        {
            if(msixUpdater.hasUpdated)
            {
                if(showUpdateState)
                    MessageBox.Show("The program has been updated", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            if (msixUpdater.currentChannelInfo.mandatory)
            {
                MinimizeBox = false;
                ShowDialog();
            }
            else Show();
        }
        private void btnUpdateNow_Click(object sender, EventArgs e)
        {
            if(asyncUpdate)
                RunUpdateAsync();
                
            else msixUpdater.DownloadAndInstall();
        }

        private async void RunUpdateAsync()
        {
            Task? updateTask = msixUpdater.DownloadAndInstallAsync();
            await updateTask;
        }

        #region Events Methods
        private void UpdateExtensionOnOnDownloadStart(EventArgs e)
        {
            pgbUpdateProgress.Visible = true;
        }
        private void UpdateExtensionOnOnUpdateDownloadProgresssChange(object sender, DownloadProgressChangedEventArgs e)
        {
            pgbUpdateProgress.Value = e.ProgressPercentage;
        }
        private void UpdateExtensionOnOnDownlaodComplete(EventArgs e)
        {
            pgbUpdateProgress.Visible = false;
        }
        #endregion
    }
}
