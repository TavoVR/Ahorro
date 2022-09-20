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

        int progress = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress += 1;

            if ( progress >= 100)
            {
                timer1.Enabled = false;
                timer1.Stop();
                MessageBox.Show("Carga Completa!!");
            }
            pgbProgress.Value = progress;
            lblProgress.Text = progress + ".0" + "%";
        }
    }
}
