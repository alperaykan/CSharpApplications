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
            lblPrice.Text = selectedMovie.price.ToString();
            pictureBoxSelectedPicture.Image = Image.FromFile(selectedMovie.picturePath); 

        }
    }
}
