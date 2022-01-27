namespace NetMsixUpdaterFormsComponent.Forms
{
    sealed partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUpdateInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wbvChangelog = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdateNow = new System.Windows.Forms.Button();
            this.pgbUpdateProgress = new System.Windows.Forms.ProgressBar();
            this.cmbUpdateChannels = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.wbvChangelog)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitle, 2);
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 20);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "A new version of {0} is available.";
            // 
            // lblUpdateInfo
            // 
            this.lblUpdateInfo.AutoSize = true;
            this.lblUpdateInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblUpdateInfo.Location = new System.Drawing.Point(3, 40);
            this.lblUpdateInfo.Name = "lblUpdateInfo";
            this.lblUpdateInfo.Size = new System.Drawing.Size(69, 34);
            this.lblUpdateInfo.TabIndex = 8;
            this.lblUpdateInfo.Text = "Actual: {0}\r\nNew: {1}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Changelog:";
            // 
            // wbvChangelog
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.wbvChangelog, 2);
            this.wbvChangelog.CreationProperties = null;
            this.wbvChangelog.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wbvChangelog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbvChangelog.Location = new System.Drawing.Point(3, 103);
            this.wbvChangelog.Name = "wbvChangelog";
            this.wbvChangelog.Size = new System.Drawing.Size(366, 273);
            this.wbvChangelog.TabIndex = 10;
            this.wbvChangelog.ZoomFactor = 1D;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUpdateInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdateNow, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.wbvChangelog, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pgbUpdateProgress, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbUpdateChannels, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.09479F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.90521F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 444);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btnUpdateNow
            // 
            this.btnUpdateNow.Image = global::NetMsixUpdaterFormsComponent.Properties.Resources.download;
            this.btnUpdateNow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateNow.Location = new System.Drawing.Point(3, 382);
            this.btnUpdateNow.Name = "btnUpdateNow";
            this.btnUpdateNow.Size = new System.Drawing.Size(102, 23);
            this.btnUpdateNow.TabIndex = 11;
            this.btnUpdateNow.Text = "Install update";
            this.btnUpdateNow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateNow.UseVisualStyleBackColor = true;
            this.btnUpdateNow.Click += new System.EventHandler(this.btnUpdateNow_Click);
            // 
            // pgbUpdateProgress
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pgbUpdateProgress, 2);
            this.pgbUpdateProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgbUpdateProgress.Location = new System.Drawing.Point(3, 418);
            this.pgbUpdateProgress.Name = "pgbUpdateProgress";
            this.pgbUpdateProgress.Size = new System.Drawing.Size(366, 23);
            this.pgbUpdateProgress.TabIndex = 12;
            this.pgbUpdateProgress.Visible = false;
            // 
            // cmbUpdateChannels
            // 
            this.cmbUpdateChannels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUpdateChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateChannels.FormattingEnabled = true;
            this.cmbUpdateChannels.Location = new System.Drawing.Point(248, 382);
            this.cmbUpdateChannels.Name = "cmbUpdateChannels";
            this.cmbUpdateChannels.Size = new System.Drawing.Size(121, 23);
            this.cmbUpdateChannels.TabIndex = 13;
            this.cmbUpdateChannels.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateChannels_SelectedIndexChanged);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 444);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(280, 400);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update available";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateForm_FormClosing);
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wbvChangelog)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUpdateInfo;
        private System.Windows.Forms.Label label1;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbvChangelog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnUpdateNow;
        private System.Windows.Forms.ProgressBar pgbUpdateProgress;
        private System.Windows.Forms.ComboBox cmbUpdateChannels;
    }
}