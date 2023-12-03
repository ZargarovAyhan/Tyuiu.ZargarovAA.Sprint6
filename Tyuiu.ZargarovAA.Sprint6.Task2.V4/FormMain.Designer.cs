namespace Tyuiu.ZargarovAA.Sprint6.Task2.V4
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
        /// 
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.labelStop = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.textBoxStopValue = new System.Windows.Forms.TextBox();
            this.textBoxStartValue = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelLine = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.groupBoxTask.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Location = new System.Drawing.Point(8, 8);
            this.groupBoxTask.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTask.Size = new System.Drawing.Size(378, 181);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(0, 15);
            this.textBoxTask.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(374, 162);
            this.textBoxTask.TabIndex = 1;
            this.textBoxTask.Text = "Написать программу, которая выводит таблицу значений функции\r\nF(x)=(5x+2,5)/(SIN(" +
    "x)+2)+2x+2";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.labelStop);
            this.groupBoxInput.Controls.Add(this.labelStart);
            this.groupBoxInput.Controls.Add(this.textBoxStopValue);
            this.groupBoxInput.Controls.Add(this.textBoxStartValue);
            this.groupBoxInput.Location = new System.Drawing.Point(8, 207);
            this.groupBoxInput.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInput.Size = new System.Drawing.Size(164, 78);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";
            // 
            // labelStop
            // 
            this.labelStop.AutoSize = true;
            this.labelStop.Location = new System.Drawing.Point(88, 35);
            this.labelStop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(69, 13);
            this.labelStop.TabIndex = 3;
            this.labelStop.Text = "Конец шага:";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(4, 35);
            this.labelStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(67, 13);
            this.labelStart.TabIndex = 2;
            this.labelStart.Text = "Старт шага:";
            // 
            // textBoxStopValue
            // 
            this.textBoxStopValue.Location = new System.Drawing.Point(91, 50);
            this.textBoxStopValue.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStopValue.Name = "textBoxStopValue";
            this.textBoxStopValue.Size = new System.Drawing.Size(68, 20);
            this.textBoxStopValue.TabIndex = 2;
            // 
            // textBoxStartValue
            // 
            this.textBoxStartValue.Location = new System.Drawing.Point(4, 50);
            this.textBoxStartValue.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStartValue.Name = "textBoxStartValue";
            this.textBoxStartValue.Size = new System.Drawing.Size(68, 20);
            this.textBoxStartValue.TabIndex = 1;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.labelLine);
            this.groupBoxResult.Controls.Add(this.labelResult);
            this.groupBoxResult.Controls.Add(this.chartResult);
            this.groupBoxResult.Controls.Add(this.dataGridViewResult);
            this.groupBoxResult.Location = new System.Drawing.Point(390, 8);
            this.groupBoxResult.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxResult.Size = new System.Drawing.Size(481, 277);
            this.groupBoxResult.TabIndex = 2;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод данных";
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Location = new System.Drawing.Point(127, 15);
            this.labelLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(48, 13);
            this.labelLine.TabIndex = 3;
            this.labelLine.Text = "График:";
            this.labelLine.Click += new System.EventHandler(this.labelLine_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(6, 15);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(53, 13);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Таблица:";
            // 
            // chartResult
            // 
            chartArea4.Name = "ChartArea1";
            this.chartResult.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartResult.Legends.Add(legend4);
            this.chartResult.Location = new System.Drawing.Point(130, 33);
            this.chartResult.Margin = new System.Windows.Forms.Padding(2);
            this.chartResult.Name = "chartResult";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartResult.Series.Add(series4);
            this.chartResult.Size = new System.Drawing.Size(347, 240);
            this.chartResult.TabIndex = 1;
            this.chartResult.Text = "chart1";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Fx});
            this.dataGridViewResult.Location = new System.Drawing.Point(4, 30);
            this.dataGridViewResult.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.RowHeadersWidth = 62;
            this.dataGridViewResult.RowTemplate.Height = 28;
            this.dataGridViewResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResult.Size = new System.Drawing.Size(106, 240);
            this.dataGridViewResult.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 8;
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Fx
            // 
            this.Fx.HeaderText = "F(X)";
            this.Fx.MinimumWidth = 8;
            this.Fx.Name = "Fx";
            this.Fx.Width = 50;
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.Lime;
            this.buttonResult.Location = new System.Drawing.Point(268, 217);
            this.buttonResult.Margin = new System.Windows.Forms.Padding(2);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(114, 67);
            this.buttonResult.TabIndex = 2;
            this.buttonResult.Text = "Выполнить";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            this.buttonResult.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResult_MouseDown);
            this.buttonResult.MouseEnter += new System.EventHandler(this.buttonResult_MouseEnter);
            this.buttonResult.MouseLeave += new System.EventHandler(this.buttonResult_MouseLeave);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.Silver;
            this.buttonInfo.Location = new System.Drawing.Point(176, 217);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(88, 68);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "Справка";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 301);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxTask);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 4 | Косов А.С";
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxStartValue;
        private System.Windows.Forms.TextBox textBoxStopValue;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fx;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Label labelResult;
    }
}
