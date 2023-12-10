using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZargarovAA.Sprint6.Task5.V24.Lib;
using System.IO;

namespace Tyuiu.ZargarovAA.Sprint6.Task5.V24
{
    public partial class FormMain_ZAA : Form
    {
        public FormMain_ZAA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V24.txt";

        private void buttonHelp_ZAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПБ-23-2 - Заргаров Айхан Ахатович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHelp_ZAA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonHelp_ZAA.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void buttonDo_ZAA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDo_ZAA.Cursor = System.Windows.Forms.Cursors.Hand;

        }
        private void buttonOpen_ZAA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonOpen_ZAA.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonDo_ZAA_Click(object sender, EventArgs e)
        {
            dataGridViewNums_ZAA.ColumnCount = 2;
            dataGridViewNums_ZAA.Columns[0].Width = 50;
            dataGridViewNums_ZAA.Columns[1].Width = 50;

            this.chartDiag_ZAA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_ZAA.ChartAreas[0].AxisY.Title = "Ось Y";


            double[] nums = ds.LoadFromDataFile(path);

            for (int i = 0; i < nums.Length; ++i)
            {
                dataGridViewNums_ZAA.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
                chartDiag_ZAA.Series[0].Points.AddXY(i, nums[i]);
            }

        }

        private void buttonOpen_ZAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void FormMain_ZAA_Load(object sender, EventArgs e)
        {

        }
    }
}