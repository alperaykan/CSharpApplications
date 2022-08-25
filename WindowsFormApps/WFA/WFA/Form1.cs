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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selamın aleyküm basıldık!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBirinci_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Buldun!!!!");
        }

        private void btnUcuncu_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Tekrar Dene Bulamadın!!!!");
        }

        private void btnİkinci_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Tekrar Dene Bulamadın!!!!");
        }

        private void btnClick_MouseHover(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Red;
            btnBirinci.BackColor = Color.Blue;
            btnİkinci.BackColor = Color.Green;
            btnUcuncu.BackColor = Color.Green;
        }

        private void btnClick_MouseLeave(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.White;
            btnBirinci.BackColor = Color.White;
            btnİkinci.BackColor = Color.White;
            btnUcuncu.BackColor = Color.White;
        }
    }
}
