using OOP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Constructor : Form
    {
        public Constructor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = txt1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Product product = new Product(txt1.Text);
            
        }
    }
}
