using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZargarovAA.Sprint6.Task0.V19.Lib;

namespace Tyuiu.ZargarovAA.Sprint6.Task0.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                TextBoxResults.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8));
            {
                e.Handled = true;
            }
        }


        private void buttonInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент ИИПБ - 23 -2 Заргаров АЙхан Ахатович", "сообщение") ;
        }

        private void textBoxTask_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
