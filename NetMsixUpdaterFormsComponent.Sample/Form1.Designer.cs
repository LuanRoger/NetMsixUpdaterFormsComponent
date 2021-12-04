namespace NetMsixUpdaterFormsComponent.Sample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearchUpdate = new System.Windows.Forms.Button();
            this.lblAssemblyVersion = new System.Windows.Forms.Label();
            this.lblUpdated = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearchUpdate
            // 
            this.btnSearchUpdate.Location = new System.Drawing.Point(164, 116);
            this.btnSearchUpdate.Name = "btnSearchUpdate";
            this.btnSearchUpdate.Size = new System.Drawing.Size(130, 23);
            this.btnSearchUpdate.TabIndex = 0;
            this.btnSearchUpdate.Text = "Search for updates";
            this.btnSearchUpdate.UseVisualStyleBackColor = true;
            this.btnSearchUpdate.Click += new System.EventHandler(this.btnSearchUpdate_Click);
            // 
            // lblAssemblyVersion
            // 
            this.lblAssemblyVersion.AutoSize = true;
            this.lblAssemblyVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAssemblyVersion.Location = new System.Drawing.Point(12, 9);
            this.lblAssemblyVersion.Name = "lblAssemblyVersion";
            this.lblAssemblyVersion.Size = new System.Drawing.Size(172, 21);
            this.lblAssemblyVersion.TabIndex = 1;
            this.lblAssemblyVersion.Text = "Assembly version: {0}";
            // 
            // lblUpdated
            // 
            this.lblUpdated.AutoSize = true;
            this.lblUpdated.Location = new System.Drawing.Point(12, 127);
            this.lblUpdated.Name = "lblUpdated";
            this.lblUpdated.Size = new System.Drawing.Size(72, 15);
            this.lblUpdated.TabIndex = 2;
            this.lblUpdated.Text = "Updated: {0}";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 151);
            this.Controls.Add(this.lblUpdated);
            this.Controls.Add(this.lblAssemblyVersion);
            this.Controls.Add(this.btnSearchUpdate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetMsixUpdaterFomrsComponent Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSearchUpdate;
        private Label lblAssemblyVersion;
        private Label lblUpdated;
    }
}