

namespace Tyuiu.ZargarovAA.Sprint6.Task6.V29
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelAbout_ZAA = new System.Windows.Forms.Label();
            this.buttonOk_ZAA = new System.Windows.Forms.Button();
            this.pictureBoxAva_ZAA = new System.Windows.Forms.PictureBox();
            this.labelInfo_ZAA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_ZAA)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAbout_ZAA
            // 
            this.labelAbout_ZAA.AutoSize = true;
            this.labelAbout_ZAA.Location = new System.Drawing.Point(144, 6);
            this.labelAbout_ZAA.Name = "labelAbout_ZAA";
            this.labelAbout_ZAA.Size = new System.Drawing.Size(0, 13);
            this.labelAbout_ZAA.TabIndex = 1;
            // 
            // buttonOk_ZAA
            // 
            this.buttonOk_ZAA.Location = new System.Drawing.Point(428, 126);
            this.buttonOk_ZAA.Name = "buttonOk_ZAA";
            this.buttonOk_ZAA.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_ZAA.TabIndex = 2;
            this.buttonOk_ZAA.Text = "OK";
            this.buttonOk_ZAA.UseVisualStyleBackColor = true;
            this.buttonOk_ZAA.Click += new System.EventHandler(this.buttonOk_ZAA_Click);
            // 
            // pictureBoxAva_ZAA
            // 
            this.pictureBoxAva_ZAA.BackgroundImage = global::Tyuiu.ZargarovaAA.Sprint6.Task6.V29.Properties.Resources.so;
            this.pictureBoxAva_ZAA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAva_ZAA.Name = "pictureBoxAva_ZAA";
            this.pictureBoxAva_ZAA.Size = new System.Drawing.Size(99, 137);
            this.pictureBoxAva_ZAA.TabIndex = 0;
            this.pictureBoxAva_ZAA.TabStop = false;
            // 
            // labelInfo_ZAA
            // 
            this.labelInfo_ZAA.AutoSize = true;
            this.labelInfo_ZAA.Location = new System.Drawing.Point(133, 9);
            this.labelInfo_ZAA.Name = "labelInfo_ZAA";
            this.labelInfo_ZAA.Size = new System.Drawing.Size(289, 130);
            this.labelInfo_ZAA.TabIndex = 3;
            this.labelInfo_ZAA.Text = resources.GetString("labelInfo_ZAA.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 161);
            this.Controls.Add(this.labelInfo_ZAA);
            this.Controls.Add(this.buttonOk_ZAA);
            this.Controls.Add(this.labelAbout_ZAA);
            this.Controls.Add(this.pictureBoxAva_ZAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_ZAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAbout_ZAA;
        private System.Windows.Forms.Button buttonOk_ZAA;
        private System.Windows.Forms.PictureBox pictureBoxAva_ZAA;
        private System.Windows.Forms.Label labelInfo_ZAA;
    }
}
