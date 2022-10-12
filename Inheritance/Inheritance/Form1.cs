using Inheritance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Classroom classroom = new Classroom();
            classroom.seviye = 1;
            classroom.sube = "B";
            Student student = new Student(38, "alpoo", "12345");
            student.classroom = classroom;
            student.GetFullName();
            student.classroom.SınıfTamAd();

        }
    }
}
