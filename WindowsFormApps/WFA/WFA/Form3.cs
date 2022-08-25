using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int number = 0;
        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show((++number).ToString());
        }

        private void btnClick2_Click(object sender, EventArgs e)
        {
            MessageBox.Show((--number).ToString());
        }
    }
}
