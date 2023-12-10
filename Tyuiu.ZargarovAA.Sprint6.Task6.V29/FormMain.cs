using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZargarovAA.Sprint6.Task6.V29.Lib;
using System.IO;

namespace Tyuiu.ZargarovAA.Sprint6.Task6.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;

        private void buttonLoad_ZAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ZAA.ShowDialog();
            openFilePath = openFileDialogTask_ZAA.FileName;
            textBoxIn_ZAA.Text = File.ReadAllText(openFilePath);
            groupBoxIn_ZAA.Text = groupBoxIn_ZAA.Text + "  " + openFileDialogTask_ZAA.FileName;
            buttonDone_ZAA.Enabled = true;
        }

        private void buttonDone_ZAA_Click(object sender, EventArgs e)
        {
            textBoxOut_ZAA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_ZAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}