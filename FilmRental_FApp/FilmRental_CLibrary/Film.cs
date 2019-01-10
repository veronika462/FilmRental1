using System.Drawing;

namespace FilmRental_CLibrary
{
    public class Film
    {
        public string FilmID { get; set; }

        public string Title { get; set; }

        public string Producer { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public double Eighteen { get; set; }
        public double DVD { get; set; }
        public double Cassette { get; set; }
        public Image Photo { get; set; }
        public double Price { get; set; }
        public double Peny { get; set; }
        public string Category { get; set; }
        public bool Available { get; set; }

        public Film(Storage storage, string title, string producer, int year, string country,   double eighteen, double dvd, double cassette, Image photo, double price, double peny, string category, bool available)
        {
            //FilmID = GenID(storage);
            Title = title;
            Producer = producer;
            Year = year;
            Country = country;
            Eighteen = eighteen;
            DVD = dvd;
            Cassette = cassette;
            Photo = photo;
            Price = price;
            Peny = peny;
            Category = category;
            Available = available;
        }

      
    }
}
