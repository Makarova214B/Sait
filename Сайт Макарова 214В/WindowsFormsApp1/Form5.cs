using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();

            a.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();

            a.Show();
            this.Close();
        }
    }
}
