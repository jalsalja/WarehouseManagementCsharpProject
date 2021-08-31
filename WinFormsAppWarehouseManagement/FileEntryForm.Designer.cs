﻿
namespace WinFormsAppWarehouseManagement
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
            this.BackToMainFE = new System.Windows.Forms.Button();
            this.CheckContentBt = new System.Windows.Forms.Button();
            this.addPanel = new System.Windows.Forms.Panel();
            this.AddContentsText = new System.Windows.Forms.Label();
            this.sveFromFile = new System.Windows.Forms.Button();
            this.addPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackToMainFE
            // 
            this.BackToMainFE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackToMainFE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackToMainFE.ForeColor = System.Drawing.Color.Black;
            this.BackToMainFE.Location = new System.Drawing.Point(465, 665);
            this.BackToMainFE.Name = "BackToMainFE";
            this.BackToMainFE.Size = new System.Drawing.Size(511, 58);
            this.BackToMainFE.TabIndex = 1;
            this.BackToMainFE.Text = "Back To Main";
            this.BackToMainFE.UseVisualStyleBackColor = false;
            this.BackToMainFE.Click += new System.EventHandler(this.BackToMainFE_Click);
            // 
            // CheckContentBt
            // 
            this.CheckContentBt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckContentBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CheckContentBt.Location = new System.Drawing.Point(465, 327);
            this.CheckContentBt.Name = "CheckContentBt";
            this.CheckContentBt.Size = new System.Drawing.Size(511, 68);
            this.CheckContentBt.TabIndex = 2;
            this.CheckContentBt.Text = "Enter The File";
            this.CheckContentBt.UseVisualStyleBackColor = false;
            this.CheckContentBt.Click += new System.EventHandler(this.CheckContentBt_Click);
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addPanel.Controls.Add(this.AddContentsText);
            this.addPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPanel.Location = new System.Drawing.Point(0, 0);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(1434, 167);
            this.addPanel.TabIndex = 3;
            // 
            // AddContentsText
            // 
            this.AddContentsText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddContentsText.AutoSize = true;
            this.AddContentsText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddContentsText.ForeColor = System.Drawing.Color.Black;
            this.AddContentsText.Location = new System.Drawing.Point(570, 57);
            this.AddContentsText.Name = "AddContentsText";
            this.AddContentsText.Size = new System.Drawing.Size(185, 54);
            this.AddContentsText.TabIndex = 0;
            this.AddContentsText.Text = "File Entry";
            this.AddContentsText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sveFromFile
            // 
            this.sveFromFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sveFromFile.Location = new System.Drawing.Point(465, 469);
            this.sveFromFile.Name = "sveFromFile";
            this.sveFromFile.Size = new System.Drawing.Size(511, 64);
            this.sveFromFile.TabIndex = 9;
            this.sveFromFile.Text = "Import from CSV File";
            this.sveFromFile.UseVisualStyleBackColor = false;
            this.sveFromFile.Click += new System.EventHandler(this.sveFromFile_Click);
            // 
            // FileEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 890);
            this.Controls.Add(this.sveFromFile);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.CheckContentBt);
            this.Controls.Add(this.BackToMainFE);
            this.Name = "FileEntryForm";
            this.Text = "FileEntryForm";
            this.Load += new System.EventHandler(this.FileEntryForm_Load);
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BackToMainFE;
        private System.Windows.Forms.Button CheckContentBt;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Label AddContentsText;
        private System.Windows.Forms.Button sveFromFile;
    }
}