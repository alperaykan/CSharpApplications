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
    public partial class Methodlar : Form
    {
        public Methodlar()
        {
            InitializeComponent();
        }

        public void Selamla()
        {
            MessageBox.Show("Selamın aleyküm. Oyuncu sınıfını seç!!!!");
        }

        private void Methodlar_Load(object sender, EventArgs e)
        {
            Selamla();
        }

        private void btnSavasci_Click(object sender, EventArgs e)
        {
            Attack("Kılıç",215);
        }

        private void btnOkcu_Click(object sender, EventArgs e)
        {
            Attack("Ok",220);
        }

        private void btnBüyücü_Click(object sender, EventArgs e)
        {
            Attack("Büyü",230);
        }

        private void btnBerserk_Click(object sender, EventArgs e)
        {
            Attack("Çılgın saldırı",250);
        }

        private void Attack(string attackStyle, int damage = 200)
        {
            MessageBox.Show($"Düşmana {attackStyle} ile {damage} zarar verildi!!");
        }
    }
}
