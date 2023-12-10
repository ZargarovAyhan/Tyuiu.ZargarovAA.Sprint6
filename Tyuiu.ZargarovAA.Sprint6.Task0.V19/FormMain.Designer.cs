
namespace Tyuiu.ZargarovAA.Sprint6.Task0.V19
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.pictureBoxequation = new System.Windows.Forms.PictureBox();
            this.groupBoxInputData = new System.Windows.Forms.GroupBox();
            this.labelVarA = new System.Windows.Forms.Label();
            this.textBoxVarA = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.TextBoxResults = new System.Windows.Forms.TextBox();
            this.buttonInformation = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxequation)).BeginInit();
            this.groupBoxInputData.SuspendLayout();
            this.groupBoxOutputData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Controls.Add(this.pictureBoxequation);
            this.groupBoxTask.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(533, 199);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(9, 19);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(290, 174);
            this.textBoxTask.TabIndex = 2;
            this.textBoxTask.Text = "Вычислить выражение по формуле";
            this.textBoxTask.TextChanged += new System.EventHandler(this.textBoxTask_TextChanged);
            // 
            // pictureBoxequation
            // 
            this.pictureBoxequation.Image = global::Tyuiu.ZargarovAA.Sprint6.Task0.V19.Properties.Resources.Untitled;
            this.pictureBoxequation.Location = new System.Drawing.Point(314, 16);
            this.pictureBoxequation.Name = "pictureBoxequation";
            this.pictureBoxequation.Size = new System.Drawing.Size(213, 61);
            this.pictureBoxequation.TabIndex = 1;
            this.pictureBoxequation.TabStop = false;
            // 
            // groupBoxInputData
            // 
            this.groupBoxInputData.Controls.Add(this.labelVarA);
            this.groupBoxInputData.Controls.Add(this.textBoxVarA);
            this.groupBoxInputData.Location = new System.Drawing.Point(13, 218);
            this.groupBoxInputData.Name = "groupBoxInputData";
            this.groupBoxInputData.Size = new System.Drawing.Size(299, 99);
            this.groupBoxInputData.TabIndex = 0;
            this.groupBoxInputData.TabStop = false;
            this.groupBoxInputData.Text = "Ввод данных";
            // 
            // labelVarA
            // 
            this.labelVarA.AutoSize = true;
            this.labelVarA.Location = new System.Drawing.Point(11, 29);
            this.labelVarA.Name = "labelVarA";
            this.labelVarA.Size = new System.Drawing.Size(78, 13);
            this.labelVarA.TabIndex = 1;
            this.labelVarA.Text = "Перменная A:";
            // 
            // textBoxVarA
            // 
            this.textBoxVarA.Location = new System.Drawing.Point(6, 45);
            this.textBoxVarA.Name = "textBoxVarA";
            this.textBoxVarA.Size = new System.Drawing.Size(111, 20);
            this.textBoxVarA.TabIndex = 0;
            // 
            // groupBoxOutputData
            // 
            this.groupBoxOutputData.Controls.Add(this.labelResult);
            this.groupBoxOutputData.Controls.Add(this.TextBoxResults);
            this.groupBoxOutputData.Location = new System.Drawing.Point(318, 218);
            this.groupBoxOutputData.Name = "groupBoxOutputData";
            this.groupBoxOutputData.Size = new System.Drawing.Size(228, 99);
            this.groupBoxOutputData.TabIndex = 0;
            this.groupBoxOutputData.TabStop = false;
            this.groupBoxOutputData.Text = "Вывод данных";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(6, 32);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Результат:";
            // 
            // TextBoxResults
            // 
            this.TextBoxResults.Location = new System.Drawing.Point(6, 48);
            this.TextBoxResults.Name = "TextBoxResults";
            this.TextBoxResults.ReadOnly = true;
            this.TextBoxResults.Size = new System.Drawing.Size(216, 20);
            this.TextBoxResults.TabIndex = 0;
            // 
            // buttonInformation
            // 
            this.buttonInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInformation.Location = new System.Drawing.Point(318, 324);
            this.buttonInformation.Name = "buttonInformation";
            this.buttonInformation.Size = new System.Drawing.Size(45, 42);
            this.buttonInformation.TabIndex = 1;
            this.buttonInformation.Text = "?";
            this.buttonInformation.UseVisualStyleBackColor = true;
            this.buttonInformation.Click += new System.EventHandler(this.buttonInformation_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(375, 323);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(171, 43);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 369);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonInformation);
            this.Controls.Add(this.groupBoxOutputData);
            this.Controls.Add(this.groupBoxInputData);
            this.Controls.Add(this.groupBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 9 | Заргаров А. А.";
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxequation)).EndInit();
            this.groupBoxInputData.ResumeLayout(false);
            this.groupBoxInputData.PerformLayout();
            this.groupBoxOutputData.ResumeLayout(false);
            this.groupBoxOutputData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.GroupBox groupBoxInputData;
        private System.Windows.Forms.GroupBox groupBoxOutputData;
        private System.Windows.Forms.Label labelVarA;
        private System.Windows.Forms.TextBox textBoxVarA;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox TextBoxResults;
        private System.Windows.Forms.Button buttonInformation;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.PictureBox pictureBoxequation;
        private System.Windows.Forms.TextBox textBoxTask;
    }
}

