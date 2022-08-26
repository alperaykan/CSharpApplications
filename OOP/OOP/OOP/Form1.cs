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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void btnNewUser_Click(object sender, EventArgs e)
        //{
        //    User user = new User();

        //    user.userName = "Alper";
        //    user.job = "developer";
        //    user.password = "123456";
        //    user.age = 26;
        //    user.eMail = "alper@gmail.com";

        //    MessageBox.Show($"{user.userName} kullanıcı adıyla {user.age} yaşında {user.job} işinde çalışan bir kullanıcı yaratıldı.");
        //}

        //private void btnNewTree_Click(object sender, EventArgs e)
        //{
        //    Tree tree = new Tree();

        //    tree.where = "bahçede";
        //    tree.name = "Limon ağacı";
        //    tree.age = 15;
        //    tree.height = 20;

        //    MessageBox.Show($"Bugün {tree.where} {tree.name} gördüm. Yaşı muhtemelen {tree.age}, boyuda {tree.height} kadardı.");
        //}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.userName = txtUserName.Text;
            user.password = txtPassword.Text;
            string loginDate = DateTime.Now.ToString();
            user.Login(loginDate);
        }

    }
}
