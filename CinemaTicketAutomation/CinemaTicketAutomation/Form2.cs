using CinemaTicketAutomation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTicketAutomation
{
    public partial class Form2 : Form
    {
        public Form2(List<Movie> _movies, Form1 _form1)
        {
            InitializeComponent();
            movies = _movies;
            form1 = _form1;
        }

        List<Movie> movies;
        Form1 form1;
        Movie selectedMovie;
        Session selectedSession;

        public void ListDetail(int movieIndex, string sessionTime, string sessionDate)
        {
            selectedMovie = movies[movieIndex];
            selectedSession = selectedMovie.sessions.Find(s => s.date == sessionDate && s.time == sessionTime);
            lblTime.Text = $"{sessionDate} - {sessionTime}";
            lblMinute.Text = selectedMovie.minute;
            lblCategory.Text = selectedMovie.category.ToString();
            lblPrice.Text = selectedMovie.price.ToString() + "TL";
            pictureBoxSelectedPicture.Image = Image.FromFile(selectedMovie.picturePath);
            CheckChairStatus();
        }

        private void CheckChairStatus()
        {
            foreach(Control item in gbSalon.Controls)
            {
                if(item is Button)
                {
                    string row = item.Tag.ToString();
                    string number = item.Text;
                    item.Enabled = true;
                    foreach(Chair chair in selectedSession.chairs)
                    {
                        if(chair.row == row && chair.number == number)
                        {
                            if (chair.status)
                            {
                                item.BackColor = Color.DarkRed;
                            }
                            else
                            {
                                item.BackColor = Color.LightGreen;
                            }
                            break;
                        }
                    }
                }
            }
        }
        List<Chair> chairs = new List<Chair>();
        private void button24_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string row = button.Tag.ToString();
            string number = button.Text;
            Chair chair = selectedSession.chairs.Find(c => c.row == row && c.number == number);
            if(button.BackColor.Name != "Blue")
            {
                chairs.Add(chair);
                button.BackColor = Color.Blue;
            }
            else
            {
                chairs.Remove(chair);
                button.BackColor = Color.LightGreen;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if(chairs.Count == 0)
            {
                MessageBox.Show("Lütfen en az 1 koltuk seçiniz ve tekrar deneyiniz.");
                return;
            }

            Sales sales = new Sales();
            sales.movieName = selectedMovie.movieName;
            sales.count = chairs.Count;
            sales.sessionTime = $"{selectedSession.date} - {selectedSession.time}";
            sales.totalPrice = TotalPriceHesapla();
            foreach(Chair chair in chairs)
            {
                chair.status = true;
            }
            MessageBox.Show(sales.ToString()); 
            ChangePage();
        }

        private decimal TotalPriceHesapla()
        {
            decimal price = selectedMovie.price * chairs.Count;
            if (radioSmall.Checked)
            {
                price += 10;
            }
            else if (radioMedium.Checked)
            {
                price += 20;
            }
            else if (radioLarge.Checked)
            {
                price += 30;
            }
            return price;
        }

        private void ChangePage()
        {
            radioSmall.Checked = radioMedium.Checked = radioLarge.Checked = false;
            chairs.Clear();
            this.Hide();
            form1.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangePage();
        }
    }
}
