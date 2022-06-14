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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        


        private void 다음_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 F4 = new Form4();
            F4.ShowDialog();
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
