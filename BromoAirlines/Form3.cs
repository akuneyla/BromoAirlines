using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BromoAirlines
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }

        private void masterBandaraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void masterBandaraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void masterBandaraToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }
    }
}
