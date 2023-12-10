
namespace Tyuiu.ZargarovAA.Sprint6.Task4.V16
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_ZAA = new System.Windows.Forms.GroupBox();
            this.labelCondition_ZAA = new System.Windows.Forms.Label();
            this.buttonHelp_ZAA = new System.Windows.Forms.Button();
            this.groupBoxInput_ZAA = new System.Windows.Forms.GroupBox();
            this.labelEnd_ZAA = new System.Windows.Forms.Label();
            this.labelStart_ZAA = new System.Windows.Forms.Label();
            this.textBoxStopStep_ZAA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_ZAA = new System.Windows.Forms.TextBox();
            this.buttonSave_ZAA = new System.Windows.Forms.Button();
            this.buttonDone_ZAA = new System.Windows.Forms.Button();
            this.groupBoxRes_ZAA = new System.Windows.Forms.GroupBox();
            this.chartFunction_ZAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxResult_ZAA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTask_ZAA.SuspendLayout();
            this.groupBoxInput_ZAA.SuspendLayout();
            this.groupBoxRes_ZAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_ZAA
            // 
            this.groupBoxTask_ZAA.Controls.Add(this.labelCondition_ZAA);
            this.groupBoxTask_ZAA.Controls.Add(this.buttonHelp_ZAA);
            this.groupBoxTask_ZAA.Controls.Add(this.groupBoxInput_ZAA);
            this.groupBoxTask_ZAA.Controls.Add(this.buttonSave_ZAA);
            this.groupBoxTask_ZAA.Controls.Add(this.buttonDone_ZAA);
            this.groupBoxTask_ZAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTask_ZAA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxTask_ZAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_ZAA.Name = "groupBoxTask_ZAA";
            this.groupBoxTask_ZAA.Size = new System.Drawing.Size(1014, 89);
            this.groupBoxTask_ZAA.TabIndex = 4;
            this.groupBoxTask_ZAA.TabStop = false;
            this.groupBoxTask_ZAA.Text = "Условие";
            // 
            // labelCondition_ZAA
            // 
            this.labelCondition_ZAA.AutoSize = true;
            this.labelCondition_ZAA.Location = new System.Drawing.Point(6, 21);
            this.labelCondition_ZAA.Name = "labelCondition_ZAA";
            this.labelCondition_ZAA.Size = new System.Drawing.Size(322, 39);
            this.labelCondition_ZAA.TabIndex = 13;
            this.labelCondition_ZAA.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox, построить график функции и \r\nсохранить в файл OutPutFileTask4V16.txt по н" +
    "ажатию кнопки. \r\n";
            // 
            // buttonHelp_ZAA
            // 
            this.buttonHelp_ZAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ZAA.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonHelp_ZAA.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonHelp_ZAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_ZAA.Location = new System.Drawing.Point(916, 21);
            this.buttonHelp_ZAA.Name = "buttonHelp_ZAA";
            this.buttonHelp_ZAA.Size = new System.Drawing.Size(92, 57);
            this.buttonHelp_ZAA.TabIndex = 12;
            this.buttonHelp_ZAA.Text = "Справка";
            this.buttonHelp_ZAA.UseVisualStyleBackColor = false;
            this.buttonHelp_ZAA.Click += new System.EventHandler(this.buttonHelp_ZAA_Click);
            // 
            // groupBoxInput_ZAA
            // 
            this.groupBoxInput_ZAA.Controls.Add(this.labelEnd_ZAA);
            this.groupBoxInput_ZAA.Controls.Add(this.labelStart_ZAA);
            this.groupBoxInput_ZAA.Controls.Add(this.textBoxStopStep_ZAA);
            this.groupBoxInput_ZAA.Controls.Add(this.textBoxStartStep_ZAA);
            this.groupBoxInput_ZAA.Location = new System.Drawing.Point(406, 0);
            this.groupBoxInput_ZAA.Name = "groupBoxInput_ZAA";
            this.groupBoxInput_ZAA.Size = new System.Drawing.Size(241, 95);
            this.groupBoxInput_ZAA.TabIndex = 6;
            this.groupBoxInput_ZAA.TabStop = false;
            this.groupBoxInput_ZAA.Text = "Ввод данных";
            // 
            // labelEnd_ZAA
            // 
            this.labelEnd_ZAA.AutoSize = true;
            this.labelEnd_ZAA.Location = new System.Drawing.Point(118, 19);
            this.labelEnd_ZAA.Name = "labelEnd_ZAA";
            this.labelEnd_ZAA.Size = new System.Drawing.Size(66, 13);
            this.labelEnd_ZAA.TabIndex = 6;
            this.labelEnd_ZAA.Text = "Конец шага";
            // 
            // labelStart_ZAA
            // 
            this.labelStart_ZAA.AutoSize = true;
            this.labelStart_ZAA.Location = new System.Drawing.Point(6, 19);
            this.labelStart_ZAA.Name = "labelStart_ZAA";
            this.labelStart_ZAA.Size = new System.Drawing.Size(64, 13);
            this.labelStart_ZAA.TabIndex = 5;
            this.labelStart_ZAA.Text = "Старт шага";
            // 
            // textBoxStopStep_ZAA
            // 
            this.textBoxStopStep_ZAA.Location = new System.Drawing.Point(121, 38);
            this.textBoxStopStep_ZAA.Name = "textBoxStopStep_ZAA";
            this.textBoxStopStep_ZAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_ZAA.TabIndex = 3;
            this.textBoxStopStep_ZAA.Text = "5";
            // 
            // textBoxStartStep_ZAA
            // 
            this.textBoxStartStep_ZAA.Location = new System.Drawing.Point(6, 38);
            this.textBoxStartStep_ZAA.Name = "textBoxStartStep_ZAA";
            this.textBoxStartStep_ZAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_ZAA.TabIndex = 0;
            this.textBoxStartStep_ZAA.Text = "-5";
            // 
            // buttonSave_ZAA
            // 
            this.buttonSave_ZAA.BackColor = System.Drawing.Color.Green;
            this.buttonSave_ZAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_ZAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonSave_ZAA.Location = new System.Drawing.Point(775, 19);
            this.buttonSave_ZAA.Name = "buttonSave_ZAA";
            this.buttonSave_ZAA.Size = new System.Drawing.Size(94, 58);
            this.buttonSave_ZAA.TabIndex = 11;
            this.buttonSave_ZAA.Text = "Сохранить";
            this.buttonSave_ZAA.UseVisualStyleBackColor = false;
            this.buttonSave_ZAA.Click += new System.EventHandler(this.buttonSave_ZAA_Click);
            // 
            // buttonDone_ZAA
            // 
            this.buttonDone_ZAA.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonDone_ZAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_ZAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_ZAA.Location = new System.Drawing.Point(653, 17);
            this.buttonDone_ZAA.Name = "buttonDone_ZAA";
            this.buttonDone_ZAA.Size = new System.Drawing.Size(94, 58);
            this.buttonDone_ZAA.TabIndex = 10;
            this.buttonDone_ZAA.Text = "Выполнить";
            this.buttonDone_ZAA.UseVisualStyleBackColor = false;
            this.buttonDone_ZAA.Click += new System.EventHandler(this.buttonDone_ZAA_Click);
            // 
            // groupBoxRes_ZAA
            // 
            this.groupBoxRes_ZAA.Controls.Add(this.label1);
            this.groupBoxRes_ZAA.Controls.Add(this.chartFunction_ZAA);
            this.groupBoxRes_ZAA.Controls.Add(this.textBoxResult_ZAA);
            this.groupBoxRes_ZAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxRes_ZAA.Location = new System.Drawing.Point(0, 89);
            this.groupBoxRes_ZAA.Name = "groupBoxRes_ZAA";
            this.groupBoxRes_ZAA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxRes_ZAA.Size = new System.Drawing.Size(1014, 382);
            this.groupBoxRes_ZAA.TabIndex = 13;
            this.groupBoxRes_ZAA.TabStop = false;
            this.groupBoxRes_ZAA.Text = "Вывод";
            // 
            // chartFunction_ZAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_ZAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_ZAA.Legends.Add(legend1);
            this.chartFunction_ZAA.Location = new System.Drawing.Point(176, 47);
            this.chartFunction_ZAA.Name = "chartFunction_ZAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_ZAA.Series.Add(series1);
            this.chartFunction_ZAA.Size = new System.Drawing.Size(813, 317);
            this.chartFunction_ZAA.SuppressExceptions = true;
            this.chartFunction_ZAA.TabIndex = 16;
            this.chartFunction_ZAA.Text = "График функции";
            // 
            // textBoxResult_ZAA
            // 
            this.textBoxResult_ZAA.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult_ZAA.Multiline = true;
            this.textBoxResult_ZAA.Name = "textBoxResult_ZAA";
            this.textBoxResult_ZAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_ZAA.Size = new System.Drawing.Size(168, 345);
            this.textBoxResult_ZAA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "График Функции";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 471);
            this.Controls.Add(this.groupBoxRes_ZAA);
            this.Controls.Add(this.groupBoxTask_ZAA);
            this.MinimumSize = new System.Drawing.Size(1030, 510);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 16 | Заргаров А. А.";
            this.groupBoxTask_ZAA.ResumeLayout(false);
            this.groupBoxTask_ZAA.PerformLayout();
            this.groupBoxInput_ZAA.ResumeLayout(false);
            this.groupBoxInput_ZAA.PerformLayout();
            this.groupBoxRes_ZAA.ResumeLayout(false);
            this.groupBoxRes_ZAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ZAA;
        private System.Windows.Forms.GroupBox groupBoxInput_ZAA;
        private System.Windows.Forms.TextBox textBoxStopStep_ZAA;
        private System.Windows.Forms.TextBox textBoxStartStep_ZAA;
        private System.Windows.Forms.Button buttonDone_ZAA;
        private System.Windows.Forms.Button buttonSave_ZAA;
        private System.Windows.Forms.Button buttonHelp_ZAA;
        private System.Windows.Forms.GroupBox groupBoxRes_ZAA;
        private System.Windows.Forms.TextBox textBoxResult_ZAA;
        private System.Windows.Forms.Label labelCondition_ZAA;
        private System.Windows.Forms.Label labelEnd_ZAA;
        private System.Windows.Forms.Label labelStart_ZAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ZAA;
        private System.Windows.Forms.Label label1;
    }
}
