using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ZargarovAA.Sprint6.Task4.V16.Lib;

namespace Tyuiu.ZargarovAA.Sprint6.Task4.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_ZAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_ZAA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_ZAA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_ZAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_ZAA.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_ZAA.Text = "";
                chartFunction_ZAA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_ZAA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_ZAA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonSave_ZAA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V16.txt";
                File.WriteAllText(path, textBoxResult_ZAA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + "сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_ZAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПБ-23-2 Заргаров Айхан Ахатович ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
