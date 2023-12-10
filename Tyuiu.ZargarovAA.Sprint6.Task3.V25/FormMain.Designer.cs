
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
            this.groupBoxTask_ZAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewTaskMatrix_ZAA = new System.Windows.Forms.DataGridView();
            this.textBoxTask_ZAA = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_ZAA = new System.Windows.Forms.GroupBox();
            this.pictureBox4_ZAA = new System.Windows.Forms.PictureBox();
            this.dataGridViewMatrixResult_ZAA = new System.Windows.Forms.DataGridView();
            this.labelResult_ZAA = new System.Windows.Forms.Label();
            this.buttonReference_ZAA = new System.Windows.Forms.Button();
            this.buttonDone_ZAA = new System.Windows.Forms.Button();
            this.groupBoxTask_ZAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskMatrix_ZAA)).BeginInit();
            this.groupBoxOutputData_ZAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4_ZAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_ZAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_ZAA
            // 
            this.groupBoxTask_ZAA.BackColor = System.Drawing.Color.LightPink;
            this.groupBoxTask_ZAA.Controls.Add(this.dataGridViewTaskMatrix_ZAA);
            this.groupBoxTask_ZAA.Controls.Add(this.textBoxTask_ZAA);
            this.groupBoxTask_ZAA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_ZAA.Name = "groupBoxTask_ZAA";
            this.groupBoxTask_ZAA.Size = new System.Drawing.Size(437, 258);
            this.groupBoxTask_ZAA.TabIndex = 0;
            this.groupBoxTask_ZAA.TabStop = false;
            this.groupBoxTask_ZAA.Text = "Условие";
            // 
            // dataGridViewTaskMatrix_ZAA
            // 
            this.dataGridViewTaskMatrix_ZAA.AllowUserToAddRows = false;
            this.dataGridViewTaskMatrix_ZAA.AllowUserToDeleteRows = false;
            this.dataGridViewTaskMatrix_ZAA.AllowUserToResizeColumns = false;
            this.dataGridViewTaskMatrix_ZAA.AllowUserToResizeRows = false;
            this.dataGridViewTaskMatrix_ZAA.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridViewTaskMatrix_ZAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaskMatrix_ZAA.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTaskMatrix_ZAA.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTaskMatrix_ZAA.GridColor = System.Drawing.Color.DarkViolet;
            this.dataGridViewTaskMatrix_ZAA.Location = new System.Drawing.Point(231, 37);
            this.dataGridViewTaskMatrix_ZAA.Name = "dataGridViewTaskMatrix_ZAA";
            this.dataGridViewTaskMatrix_ZAA.RowHeadersVisible = false;
            this.dataGridViewTaskMatrix_ZAA.Size = new System.Drawing.Size(178, 178);
            this.dataGridViewTaskMatrix_ZAA.TabIndex = 1;
            this.dataGridViewTaskMatrix_ZAA.TabStop = false;
            this.dataGridViewTaskMatrix_ZAA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTaskMatrix_ZAA_CellContentClick);
            // 
            // textBoxTask_ZAA
            // 
            this.textBoxTask_ZAA.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxTask_ZAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_ZAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_ZAA.Location = new System.Drawing.Point(7, 37);
            this.textBoxTask_ZAA.Multiline = true;
            this.textBoxTask_ZAA.Name = "textBoxTask_ZAA";
            this.textBoxTask_ZAA.ReadOnly = true;
            this.textBoxTask_ZAA.Size = new System.Drawing.Size(192, 178);
            this.textBoxTask_ZAA.TabIndex = 0;
            this.textBoxTask_ZAA.TabStop = false;
            this.textBoxTask_ZAA.Text = resources.GetString("textBoxTask_ZAA.Text");
            // 
            // groupBoxOutputData_ZAA
            // 
            this.groupBoxOutputData_ZAA.BackColor = System.Drawing.Color.PaleVioletRed;
            this.groupBoxOutputData_ZAA.Controls.Add(this.pictureBox4_ZAA);
            this.groupBoxOutputData_ZAA.Controls.Add(this.dataGridViewMatrixResult_ZAA);
            this.groupBoxOutputData_ZAA.Controls.Add(this.labelResult_ZAA);
            this.groupBoxOutputData_ZAA.Location = new System.Drawing.Point(468, 13);
            this.groupBoxOutputData_ZAA.Name = "groupBoxOutputData_ZAA";
            this.groupBoxOutputData_ZAA.Size = new System.Drawing.Size(198, 187);
            this.groupBoxOutputData_ZAA.TabIndex = 5;
            this.groupBoxOutputData_ZAA.TabStop = false;
            this.groupBoxOutputData_ZAA.Text = "Вывод данных";
            // 
            // pictureBox4_ZAA
            // 
            this.pictureBox4_ZAA.BackColor = System.Drawing.Color.Pink;
            this.pictureBox4_ZAA.Location = new System.Drawing.Point(10, 39);
            this.pictureBox4_ZAA.Name = "pictureBox4_ZAA";
            this.pictureBox4_ZAA.Size = new System.Drawing.Size(179, 137);
            this.pictureBox4_ZAA.TabIndex = 3;
            this.pictureBox4_ZAA.TabStop = false;
            // 
            // dataGridViewMatrixResult_ZAA
            // 
            this.dataGridViewMatrixResult_ZAA.AllowUserToAddRows = false;
            this.dataGridViewMatrixResult_ZAA.AllowUserToDeleteRows = false;
            this.dataGridViewMatrixResult_ZAA.AllowUserToResizeColumns = false;
            this.dataGridViewMatrixResult_ZAA.AllowUserToResizeRows = false;
            this.dataGridViewMatrixResult_ZAA.BackgroundColor = System.Drawing.Color.Violet;
            this.dataGridViewMatrixResult_ZAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixResult_ZAA.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMatrixResult_ZAA.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMatrixResult_ZAA.GridColor = System.Drawing.Color.DarkViolet;
            this.dataGridViewMatrixResult_ZAA.Location = new System.Drawing.Point(10, 40);
            this.dataGridViewMatrixResult_ZAA.Name = "dataGridViewMatrixResult_ZAA";
            this.dataGridViewMatrixResult_ZAA.ReadOnly = true;
            this.dataGridViewMatrixResult_ZAA.RowHeadersVisible = false;
            this.dataGridViewMatrixResult_ZAA.Size = new System.Drawing.Size(178, 136);
            this.dataGridViewMatrixResult_ZAA.TabIndex = 2;
            this.dataGridViewMatrixResult_ZAA.TabStop = false;
            // 
            // labelResult_ZAA
            // 
            this.labelResult_ZAA.AutoSize = true;
            this.labelResult_ZAA.Location = new System.Drawing.Point(7, 20);
            this.labelResult_ZAA.Name = "labelResult_ZAA";
            this.labelResult_ZAA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_ZAA.TabIndex = 1;
            this.labelResult_ZAA.Text = "Результат:";
            // 
            // buttonReference_ZAA
            // 
            this.buttonReference_ZAA.BackColor = System.Drawing.Color.LightPink;
            this.buttonReference_ZAA.Font = new System.Drawing.Font("Blackletter Shadow", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReference_ZAA.Location = new System.Drawing.Point(478, 243);
            this.buttonReference_ZAA.Name = "buttonReference_ZAA";
            this.buttonReference_ZAA.Size = new System.Drawing.Size(59, 50);
            this.buttonReference_ZAA.TabIndex = 6;
            this.buttonReference_ZAA.TabStop = false;
            this.buttonReference_ZAA.Text = "?";
            this.buttonReference_ZAA.UseVisualStyleBackColor = false;
            this.buttonReference_ZAA.Click += new System.EventHandler(this.buttonReference_ZAA_Click);
            // 
            // buttonDone_ZAA
            // 
            this.buttonDone_ZAA.BackColor = System.Drawing.Color.Pink;
            this.buttonDone_ZAA.Font = new System.Drawing.Font("Maginors", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone_ZAA.Location = new System.Drawing.Point(566, 243);
            this.buttonDone_ZAA.Name = "buttonDone_ZAA";
            this.buttonDone_ZAA.Size = new System.Drawing.Size(90, 50);
            this.buttonDone_ZAA.TabIndex = 7;
            this.buttonDone_ZAA.TabStop = false;
            this.buttonDone_ZAA.Text = "Выполнить";
            this.buttonDone_ZAA.UseVisualStyleBackColor = false;
            this.buttonDone_ZAA.Click += new System.EventHandler(this.buttonDone_ZAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(679, 300);
            this.Controls.Add(this.buttonDone_ZAA);
            this.Controls.Add(this.buttonReference_ZAA);
            this.Controls.Add(this.groupBoxOutputData_ZAA);
            this.Controls.Add(this.groupBoxTask_ZAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 25 | Заргаров А. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_ZAA.ResumeLayout(false);
            this.groupBoxTask_ZAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskMatrix_ZAA)).EndInit();
            this.groupBoxOutputData_ZAA.ResumeLayout(false);
            this.groupBoxOutputData_ZAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4_ZAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_ZAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ZAA;
        private System.Windows.Forms.DataGridView dataGridViewTaskMatrix_ZAA;
        private System.Windows.Forms.TextBox textBoxTask_ZAA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_ZAA;
        private System.Windows.Forms.DataGridView dataGridViewMatrixResult_ZAA;
        private System.Windows.Forms.Label labelResult_ZAA;
        private System.Windows.Forms.Button buttonReference_ZAA;
        private System.Windows.Forms.Button buttonDone_ZAA;
        private System.Windows.Forms.PictureBox pictureBox4_ZAA;
    }
}
