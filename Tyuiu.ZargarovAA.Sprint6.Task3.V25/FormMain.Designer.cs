
namespace Tyuiu.ZargarovAA.Sprint6.Task3.V25
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxTask_EKP = new System.Windows.Forms.GroupBox();
            this.dataGridViewTaskMatrix_EKP = new System.Windows.Forms.DataGridView();
            this.textBoxTask_EKP = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_EKP = new System.Windows.Forms.GroupBox();
            this.pictureBox4_EKP = new System.Windows.Forms.PictureBox();
            this.dataGridViewMatrixResult_EKP = new System.Windows.Forms.DataGridView();
            this.labelResult_EKP = new System.Windows.Forms.Label();
            this.buttonReference_EKP = new System.Windows.Forms.Button();
            this.buttonDone_EKP = new System.Windows.Forms.Button();
            this.groupBoxTask_EKP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskMatrix_EKP)).BeginInit();
            this.groupBoxOutputData_EKP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4_EKP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_EKP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_EKP
            // 
            this.groupBoxTask_EKP.BackColor = System.Drawing.Color.LightPink;
            this.groupBoxTask_EKP.Controls.Add(this.dataGridViewTaskMatrix_EKP);
            this.groupBoxTask_EKP.Controls.Add(this.textBoxTask_EKP);
            this.groupBoxTask_EKP.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_EKP.Name = "groupBoxTask_EKP";
            this.groupBoxTask_EKP.Size = new System.Drawing.Size(437, 258);
            this.groupBoxTask_EKP.TabIndex = 0;
            this.groupBoxTask_EKP.TabStop = false;
            this.groupBoxTask_EKP.Text = "Условие";
            // 
            // dataGridViewTaskMatrix_EKP
            // 
            this.dataGridViewTaskMatrix_EKP.AllowUserToAddRows = false;
            this.dataGridViewTaskMatrix_EKP.AllowUserToDeleteRows = false;
            this.dataGridViewTaskMatrix_EKP.AllowUserToResizeColumns = false;
            this.dataGridViewTaskMatrix_EKP.AllowUserToResizeRows = false;
            this.dataGridViewTaskMatrix_EKP.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridViewTaskMatrix_EKP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaskMatrix_EKP.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTaskMatrix_EKP.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTaskMatrix_EKP.GridColor = System.Drawing.Color.DarkViolet;
            this.dataGridViewTaskMatrix_EKP.Location = new System.Drawing.Point(231, 37);
            this.dataGridViewTaskMatrix_EKP.Name = "dataGridViewTaskMatrix_EKP";
            this.dataGridViewTaskMatrix_EKP.RowHeadersVisible = false;
            this.dataGridViewTaskMatrix_EKP.Size = new System.Drawing.Size(178, 178);
            this.dataGridViewTaskMatrix_EKP.TabIndex = 1;
            this.dataGridViewTaskMatrix_EKP.TabStop = false;
            this.dataGridViewTaskMatrix_EKP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTaskMatrix_EKP_CellContentClick);
            // 
            // textBoxTask_EKP
            // 
            this.textBoxTask_EKP.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxTask_EKP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_EKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_EKP.Location = new System.Drawing.Point(7, 37);
            this.textBoxTask_EKP.Multiline = true;
            this.textBoxTask_EKP.Name = "textBoxTask_EKP";
            this.textBoxTask_EKP.ReadOnly = true;
            this.textBoxTask_EKP.Size = new System.Drawing.Size(192, 178);
            this.textBoxTask_EKP.TabIndex = 0;
            this.textBoxTask_EKP.TabStop = false;
            this.textBoxTask_EKP.Text = resources.GetString("textBoxTask_EKP.Text");
            // 
            // groupBoxOutputData_EKP
            // 
            this.groupBoxOutputData_EKP.BackColor = System.Drawing.Color.PaleVioletRed;
            this.groupBoxOutputData_EKP.Controls.Add(this.pictureBox4_EKP);
            this.groupBoxOutputData_EKP.Controls.Add(this.dataGridViewMatrixResult_EKP);
            this.groupBoxOutputData_EKP.Controls.Add(this.labelResult_EKP);
            this.groupBoxOutputData_EKP.Location = new System.Drawing.Point(468, 13);
            this.groupBoxOutputData_EKP.Name = "groupBoxOutputData_EKP";
            this.groupBoxOutputData_EKP.Size = new System.Drawing.Size(198, 224);
            this.groupBoxOutputData_EKP.TabIndex = 5;
            this.groupBoxOutputData_EKP.TabStop = false;
            this.groupBoxOutputData_EKP.Text = "Вывод данных";
            // 
            // pictureBox4_EKP
            // 
            this.pictureBox4_EKP.BackColor = System.Drawing.Color.Pink;
            this.pictureBox4_EKP.Location = new System.Drawing.Point(10, 39);
            this.pictureBox4_EKP.Name = "pictureBox4_EKP";
            this.pictureBox4_EKP.Size = new System.Drawing.Size(179, 179);
            this.pictureBox4_EKP.TabIndex = 3;
            this.pictureBox4_EKP.TabStop = false;
            // 
            // dataGridViewMatrixResult_EKP
            // 
            this.dataGridViewMatrixResult_EKP.AllowUserToAddRows = false;
            this.dataGridViewMatrixResult_EKP.AllowUserToDeleteRows = false;
            this.dataGridViewMatrixResult_EKP.AllowUserToResizeColumns = false;
            this.dataGridViewMatrixResult_EKP.AllowUserToResizeRows = false;
            this.dataGridViewMatrixResult_EKP.BackgroundColor = System.Drawing.Color.Violet;
            this.dataGridViewMatrixResult_EKP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixResult_EKP.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMatrixResult_EKP.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMatrixResult_EKP.GridColor = System.Drawing.Color.DarkViolet;
            this.dataGridViewMatrixResult_EKP.Location = new System.Drawing.Point(10, 40);
            this.dataGridViewMatrixResult_EKP.Name = "dataGridViewMatrixResult_EKP";
            this.dataGridViewMatrixResult_EKP.ReadOnly = true;
            this.dataGridViewMatrixResult_EKP.RowHeadersVisible = false;
            this.dataGridViewMatrixResult_EKP.Size = new System.Drawing.Size(178, 178);
            this.dataGridViewMatrixResult_EKP.TabIndex = 2;
            this.dataGridViewMatrixResult_EKP.TabStop = false;
            // 
            // labelResult_EKP
            // 
            this.labelResult_EKP.AutoSize = true;
            this.labelResult_EKP.Location = new System.Drawing.Point(7, 20);
            this.labelResult_EKP.Name = "labelResult_EKP";
            this.labelResult_EKP.Size = new System.Drawing.Size(62, 13);
            this.labelResult_EKP.TabIndex = 1;
            this.labelResult_EKP.Text = "Результат:";
            // 
            // buttonReference_EKP
            // 
            this.buttonReference_EKP.BackColor = System.Drawing.Color.LightPink;
            this.buttonReference_EKP.Font = new System.Drawing.Font("Blackletter Shadow", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReference_EKP.Location = new System.Drawing.Point(478, 243);
            this.buttonReference_EKP.Name = "buttonReference_EKP";
            this.buttonReference_EKP.Size = new System.Drawing.Size(59, 50);
            this.buttonReference_EKP.TabIndex = 6;
            this.buttonReference_EKP.TabStop = false;
            this.buttonReference_EKP.Text = "?";
            this.buttonReference_EKP.UseVisualStyleBackColor = false;
            this.buttonReference_EKP.Click += new System.EventHandler(this.buttonReference_EKP_Click);
            // 
            // buttonDone_EKP
            // 
            this.buttonDone_EKP.BackColor = System.Drawing.Color.Pink;
            this.buttonDone_EKP.Font = new System.Drawing.Font("Maginors", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone_EKP.Location = new System.Drawing.Point(566, 243);
            this.buttonDone_EKP.Name = "buttonDone_EKP";
            this.buttonDone_EKP.Size = new System.Drawing.Size(90, 50);
            this.buttonDone_EKP.TabIndex = 7;
            this.buttonDone_EKP.TabStop = false;
            this.buttonDone_EKP.Text = "Выполнить";
            this.buttonDone_EKP.UseVisualStyleBackColor = false;
            this.buttonDone_EKP.Click += new System.EventHandler(this.buttonDone_EKP_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(679, 300);
            this.Controls.Add(this.buttonDone_EKP);
            this.Controls.Add(this.buttonReference_EKP);
            this.Controls.Add(this.groupBoxOutputData_EKP);
            this.Controls.Add(this.groupBoxTask_EKP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 25 | Заргаров А. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_EKP.ResumeLayout(false);
            this.groupBoxTask_EKP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskMatrix_EKP)).EndInit();
            this.groupBoxOutputData_EKP.ResumeLayout(false);
            this.groupBoxOutputData_EKP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4_EKP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_EKP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_EKP;
        private System.Windows.Forms.DataGridView dataGridViewTaskMatrix_EKP;
        private System.Windows.Forms.TextBox textBoxTask_EKP;
        private System.Windows.Forms.GroupBox groupBoxOutputData_EKP;
        private System.Windows.Forms.DataGridView dataGridViewMatrixResult_EKP;
        private System.Windows.Forms.Label labelResult_EKP;
        private System.Windows.Forms.Button buttonReference_EKP;
        private System.Windows.Forms.Button buttonDone_EKP;
        private System.Windows.Forms.PictureBox pictureBox4_EKP;
    }
}
