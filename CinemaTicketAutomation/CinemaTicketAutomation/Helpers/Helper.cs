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
                    category = Enums.Category.gerilim,
                    minute = "2 saat",
                    price = 50,
                    picturePath = basePath + "ebeninavi.jpg"
                },
                new Movie()
                {
                    movieName = "Güzel Şoför",
                    category = Enums.Category.komedi,
                    minute = "1 saat 38 dakika",
                    price = 45,
                    picturePath = basePath + "guzelsofor.jpg"
                },
                new Movie()
                {
                    movieName = "Savaşın Lordu",
                    category = Enums.Category.aksiyon,
                    minute = "2 saat 38 dakika",
                    price = 60,
                    picturePath = basePath + "lordofwar.jpg"
                },
                new Movie()
                {
                    movieName = "Sherlock Holmes",
                    category = Enums.Category.macera,
                    minute = "2 saat 18 dakika",
                    price = 55,
                    picturePath = basePath + "sherlockholmes.jpg"
                },
                new Movie()
                {
                    movieName = "Thor",
                    category = Enums.Category.fantastik,
                    minute = "2 saat 48 dakika",
                    price = 75,
                    picturePath = basePath + "thor.jpg"
                },
                new Movie()
                {
                    movieName = "Uzay Yolcuları",
                    category = Enums.Category.bilimkurgu,
                    minute = "2 saat 30 dakika",
                    price = 80,
                    picturePath = basePath + "uzayyolcuları.jpg"
                },
            };
        }
    }
}
