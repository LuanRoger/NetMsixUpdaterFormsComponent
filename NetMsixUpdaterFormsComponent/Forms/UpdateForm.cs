using System;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetMsixUpdater;
using NetMsixUpdater.Updater.Extensions.MsixUpdater;
using NetMsixUpdaterFormsComponent.Enum;
using NetMsixUpdaterFormsComponent.Exceptions;

namespace NetMsixUpdaterFormsComponent.Forms
{
    /// <summary>
    /// Base form from MsixUpdater.
    /// </summary>
    public partial class UpdateForm : Form
    {
        public MsixUpdater msixUpdater { get; }
        private string? customProgramName { get; }
        public bool showUpdateState { get; set; } = true;
        public bool asyncUpdate { get; set; } = true;
        public MandatoryType mandatoryType { get; set; } = MandatoryType.ImposibleToUse;

        public UpdateForm(MsixUpdater msixUpdater, string customProgramName = null)
        {
            InitializeComponent();
            
            this.msixUpdater = msixUpdater;
            this.customProgramName = customProgramName;
            msixUpdater.Build();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = string.Format(lblTitle.Text,
                customProgramName ?? Assembly.GetEntryAssembly()!.GetName().Name);
            
            lblUpdateInfo.Text = string.Format(lblUpdateInfo.Text, 
                Assembly.GetExecutingAssembly().GetName().Version,
                msixUpdater.yamlUpdateInfo.version);
            
            wbvChangelog.Source = new(msixUpdater.yamlUpdateInfo.changelog);

            UpdateExtension.OnDownloadStart += UpdateExtensionOnOnDownloadStart;
            UpdateExtension.OnUpdateDownloadProgresssChange += UpdateExtensionOnOnUpdateDownloadProgresssChange;
            UpdateExtension.OnDownlaodComplete += UpdateExtensionOnOnDownlaodComplete;
        }
        private void UpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(msixUpdater.yamlUpdateInfo.mandatory && mandatoryType == MandatoryType.ImposibleToUse)
            {
                DialogResult dialogResult = MessageBox.Show("This update is mandatory and you can't use in old version", "Information",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Cancel)
                    Environment.Exit(0);
                else e.Cancel = true;
            }
        }

        public void Start()
        {
            if(msixUpdater.hasUpdated)
            {
                if(showUpdateState)
                    MessageBox.Show("The program has been updated", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            if (msixUpdater.yamlUpdateInfo.mandatory)
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
    }
}
