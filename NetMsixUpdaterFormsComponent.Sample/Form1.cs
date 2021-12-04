using System.Reflection;

namespace NetMsixUpdaterFormsComponent.Sample
{
    public partial class Form1 : Form
    {
        private Forms.UpdateForm updateForm { get; }

        public Form1()
        {
            InitializeComponent();

            updateForm = new(new(Assembly.GetExecutingAssembly(),
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\update.yaml"));
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            lblAssemblyVersion.Text = string.Format(lblAssemblyVersion.Text, 
                Assembly.GetExecutingAssembly().GetName().Version);
            lblUpdated.Text = string.Format(lblUpdated.Text, updateForm.msixUpdater.hasUpdated.ToString());
        }

        private void btnSearchUpdate_Click(object sender, EventArgs e) => updateForm.Start();
    }
}