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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                if (name == "")
                {
                    MessageBox.Show("Numara giriniz. Boşluk olmaz");
                    return;
                }
                int nameSayi = Convert.ToInt32(name);
                if(nameSayi >= 100)
                {
                    MessageBox.Show("Sayı çok büyük biraz küçültmeyi deneyin!!");
                    txtName.Text = "";
                    return;
                }
                txtName.Text = Convert.ToString(nameSayi + 1);
            }
            catch (FormatException)
            {
                MessageBox.Show("Sayı formatında giriniz");
                txtName.Text = "";
            }
          
        }
    }
}
