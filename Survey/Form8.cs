using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "jungyuyeop" || textBox2.Text == "991015")
            {
                this.Visible = false;
                Form9 F9 = new Form9();
                F9.ShowDialog();
            }
            else
            {
                this.Visible = false;
                Form7 F7 = new Form7();
                F7.ShowDialog();
            }
        }
    }
}
