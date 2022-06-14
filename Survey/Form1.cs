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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 F2 = new Form2();
            F2.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login F8 = new login();
            F8.ShowDialog();
        }
    }
}
