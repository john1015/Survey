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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 F5 = new Form5();
            F5.ShowDialog();
        }
        

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 밥YES_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void 밥NO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void 밥OR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void 횟수0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void 횟수1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void 횟수2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void 횟수3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void 횟수모름_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
