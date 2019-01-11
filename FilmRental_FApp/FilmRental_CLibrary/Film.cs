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
        public string Eighteen { get; set; }
        public int DVD { get; set; }
        public int Cassette { get; set; }
        public Image Photo { get; set; }
        public double Price { get; set; }
        public double Peny { get; set; }
        public string Category { get; set; }
        public bool Available { get; set; }

        public Film(Storage storage, string title, string producer, int year, string country,   string eighteen, int dvd, int cassette, Image photo, double price, double peny, string category, bool available)
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
