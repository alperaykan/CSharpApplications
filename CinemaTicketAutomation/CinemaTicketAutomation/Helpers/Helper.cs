using CinemaTicketAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketAutomation.Helpers
{
    public class Helper
    {
        public static List<Movie> CreateMovies()
        {
            string basePath = "C:/Users/falid/Desktop/CsApps/CinemaTicketAutomation/CinemaTicketAutomation/Pictures/";
            return new List<Movie>()
            {
                new Movie()
                {
                    movieName = "Ebenin Avı",
                    category = Enums.Category.Gerilim,
                    minute = "2 saat",
                    price = 50,
                    picturePath = basePath + "ebeninavi.jpg"
                },
                new Movie()
                {
                    movieName = "Güzel Şoför",
                    category = Enums.Category.Komedi,
                    minute = "1 saat 38 dakika",
                    price = 45,
                    picturePath = basePath + "guzelsofor.jpg"
                },
                new Movie()
                {
                    movieName = "Savaşın Lordu",
                    category = Enums.Category.Aksiyon,
                    minute = "2 saat 38 dakika",
                    price = 60,
                    picturePath = basePath + "lordofwar.jpg"
                },
                new Movie()
                {
                    movieName = "Sherlock Holmes",
                    category = Enums.Category.Macera,
                    minute = "2 saat 18 dakika",
                    price = 55,
                    picturePath = basePath + "sherlockholmes.jpg"
                },
                new Movie()
                {
                    movieName = "Thor",
                    category = Enums.Category.Fantastik,
                    minute = "2 saat 48 dakika",
                    price = 75,
                    picturePath = basePath + "thor.jpg"
                },
                new Movie()
                {
                    movieName = "Uzay Yolcuları",
                    category = Enums.Category.Bilimkurgu,
                    minute = "2 saat 30 dakika",
                    price = 80,
                    picturePath = basePath + "uzayyolcuları.jpg"
                },
            };
        }
    }
}
