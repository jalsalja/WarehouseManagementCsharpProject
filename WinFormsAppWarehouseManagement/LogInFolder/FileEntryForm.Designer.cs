
namespace WinFormsAppWarehouseManagement.LogInFolder
{
    partial class FileEntryForm
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
            this.CheckContentBt = new System.Windows.Forms.Button();
            this.SaveFromFile = new System.Windows.Forms.Button();
            this.BackToMain = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckContentBt
            // 
            this.CheckContentBt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckContentBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CheckContentBt.Location = new System.Drawing.Point(308, 331);
            this.CheckContentBt.Name = "CheckContentBt";
            this.CheckContentBt.Size = new System.Drawing.Size(583, 84);
            this.CheckContentBt.TabIndex = 0;
            this.CheckContentBt.Text = "Enter The File";
            this.CheckContentBt.UseVisualStyleBackColor = false;
            this.CheckContentBt.Click += new System.EventHandler(this.CheckContentBt_Click);
            // 
            // SaveFromFile
            // 
            this.SaveFromFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SaveFromFile.Location = new System.Drawing.Point(308, 462);
            this.SaveFromFile.Name = "SaveFromFile";
            this.SaveFromFile.Size = new System.Drawing.Size(583, 81);
            this.SaveFromFile.TabIndex = 0;
            this.SaveFromFile.Text = "Import from CSV File";
            this.SaveFromFile.UseVisualStyleBackColor = false;
            this.SaveFromFile.Click += new System.EventHandler(this.SaveFromFile_Click);
            // 
            // BackToMain
            // 
            this.BackToMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackToMain.Location = new System.Drawing.Point(308, 582);
            this.BackToMain.Name = "BackToMain";
            this.BackToMain.Size = new System.Drawing.Size(583, 72);
            this.BackToMain.TabIndex = 0;
            this.BackToMain.Text = "Back To Main";
            this.BackToMain.UseVisualStyleBackColor = false;
            this.BackToMain.Click += new System.EventHandler(this.BackToMain_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 159);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(425, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Entry";
            // 
            // FileEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1225, 913);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackToMain);
            this.Controls.Add(this.SaveFromFile);
            this.Controls.Add(this.CheckContentBt);
            this.Name = "FileEntryForm";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CheckContentBt;
        private System.Windows.Forms.Button SaveFromFile;
        private System.Windows.Forms.Button BackToMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}