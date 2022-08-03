using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alcancia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0, b = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            a = a + 1;
            label1.Text = a.ToString();
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 10;
                label2.Text = progressBar1.Value.ToString();
            }
            else
            {
                label2.Text = "Carga Completa";
            }
            timer1.Start();

        }
    }
}
