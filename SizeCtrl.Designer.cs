﻿
namespace WinFormsApp
{
    partial class SizeCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSize
            // 
            this.lblSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSize.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSize.Location = new System.Drawing.Point(0, 0);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(228, 176);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "(0, 0)";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SizeCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSize);
            this.Name = "SizeCtrl";
            this.Size = new System.Drawing.Size(228, 176);
            this.SizeChanged += new System.EventHandler(this.SizeCtrl_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSize;
    }
}
