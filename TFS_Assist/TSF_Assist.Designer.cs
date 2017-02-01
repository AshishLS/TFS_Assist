namespace TFS_Assist
{
    partial class TSF_Assist
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
            this.tbxTFSDirPath = new System.Windows.Forms.TextBox();
            this.lblServerFolder = new System.Windows.Forms.Label();
            this.lblMappedFolder = new System.Windows.Forms.Label();
            this.tbxMappedFolder = new System.Windows.Forms.TextBox();
            this.btnGenerateBat = new System.Windows.Forms.Button();
            this.lblBatFileInfo = new System.Windows.Forms.Label();
            this.btnRunBat = new System.Windows.Forms.Button();
            this.cbxNoTFSDEBUG = new System.Windows.Forms.CheckBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.cbxRecursive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbxTFSDirPath
            // 
            this.tbxTFSDirPath.Location = new System.Drawing.Point(96, 16);
            this.tbxTFSDirPath.Name = "tbxTFSDirPath";
            this.tbxTFSDirPath.Size = new System.Drawing.Size(341, 20);
            this.tbxTFSDirPath.TabIndex = 0;
            // 
            // lblServerFolder
            // 
            this.lblServerFolder.AutoSize = true;
            this.lblServerFolder.Location = new System.Drawing.Point(12, 19);
            this.lblServerFolder.Name = "lblServerFolder";
            this.lblServerFolder.Size = new System.Drawing.Size(70, 13);
            this.lblServerFolder.TabIndex = 1;
            this.lblServerFolder.Text = "Server Folder";
            // 
            // lblMappedFolder
            // 
            this.lblMappedFolder.AutoSize = true;
            this.lblMappedFolder.Location = new System.Drawing.Point(12, 45);
            this.lblMappedFolder.Name = "lblMappedFolder";
            this.lblMappedFolder.Size = new System.Drawing.Size(78, 13);
            this.lblMappedFolder.TabIndex = 3;
            this.lblMappedFolder.Text = "Mapped Folder";
            // 
            // tbxMappedFolder
            // 
            this.tbxMappedFolder.Location = new System.Drawing.Point(96, 38);
            this.tbxMappedFolder.Name = "tbxMappedFolder";
            this.tbxMappedFolder.Size = new System.Drawing.Size(287, 20);
            this.tbxMappedFolder.TabIndex = 2;
            // 
            // btnGenerateBat
            // 
            this.btnGenerateBat.Location = new System.Drawing.Point(15, 81);
            this.btnGenerateBat.Name = "btnGenerateBat";
            this.btnGenerateBat.Size = new System.Drawing.Size(118, 23);
            this.btnGenerateBat.TabIndex = 4;
            this.btnGenerateBat.Text = "Generate Bat";
            this.btnGenerateBat.UseVisualStyleBackColor = true;
            this.btnGenerateBat.Click += new System.EventHandler(this.btnGenerateBat_Click);
            // 
            // lblBatFileInfo
            // 
            this.lblBatFileInfo.AutoSize = true;
            this.lblBatFileInfo.Location = new System.Drawing.Point(12, 129);
            this.lblBatFileInfo.Name = "lblBatFileInfo";
            this.lblBatFileInfo.Size = new System.Drawing.Size(91, 13);
            this.lblBatFileInfo.TabIndex = 5;
            this.lblBatFileInfo.Text = "Check Bat file at: ";
            // 
            // btnRunBat
            // 
            this.btnRunBat.Location = new System.Drawing.Point(344, 116);
            this.btnRunBat.Name = "btnRunBat";
            this.btnRunBat.Size = new System.Drawing.Size(79, 23);
            this.btnRunBat.TabIndex = 6;
            this.btnRunBat.Text = "Run Bat";
            this.btnRunBat.UseVisualStyleBackColor = true;
            this.btnRunBat.Click += new System.EventHandler(this.btnRunBat_Click);
            // 
            // cbxNoTFSDEBUG
            // 
            this.cbxNoTFSDEBUG.AutoSize = true;
            this.cbxNoTFSDEBUG.Location = new System.Drawing.Point(344, 93);
            this.cbxNoTFSDEBUG.Name = "cbxNoTFSDEBUG";
            this.cbxNoTFSDEBUG.Size = new System.Drawing.Size(110, 17);
            this.cbxNoTFSDEBUG.TabIndex = 7;
            this.cbxNoTFSDEBUG.Text = "No TFS (DEBUG)";
            this.cbxNoTFSDEBUG.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnHelp.Location = new System.Drawing.Point(449, 146);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(28, 23);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "!";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.bthHelp_Click);
            // 
            // cbxRecursive
            // 
            this.cbxRecursive.AutoSize = true;
            this.cbxRecursive.Location = new System.Drawing.Point(344, 64);
            this.cbxRecursive.Name = "cbxRecursive";
            this.cbxRecursive.Size = new System.Drawing.Size(74, 17);
            this.cbxRecursive.TabIndex = 9;
            this.cbxRecursive.Text = "Recursive";
            this.cbxRecursive.UseVisualStyleBackColor = true;
            // 
            // TSF_Assist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 181);
            this.Controls.Add(this.cbxRecursive);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.cbxNoTFSDEBUG);
            this.Controls.Add(this.btnRunBat);
            this.Controls.Add(this.lblBatFileInfo);
            this.Controls.Add(this.btnGenerateBat);
            this.Controls.Add(this.lblMappedFolder);
            this.Controls.Add(this.tbxMappedFolder);
            this.Controls.Add(this.lblServerFolder);
            this.Controls.Add(this.tbxTFSDirPath);
            this.Name = "TSF_Assist";
            this.Text = "TFS_Assist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTFSDirPath;
        private System.Windows.Forms.Label lblServerFolder;
        private System.Windows.Forms.Label lblMappedFolder;
        private System.Windows.Forms.TextBox tbxMappedFolder;
        private System.Windows.Forms.Button btnGenerateBat;
        private System.Windows.Forms.Label lblBatFileInfo;
        private System.Windows.Forms.Button btnRunBat;
        private System.Windows.Forms.CheckBox cbxNoTFSDEBUG;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.CheckBox cbxRecursive;
    }
}

