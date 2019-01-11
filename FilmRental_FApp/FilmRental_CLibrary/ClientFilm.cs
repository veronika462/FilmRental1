using System;

namespace FilmRental_CLibrary
{
    public class ClientFilm
    {
        public Film clientFilm { get; set; } 
        public DateTime leaseDate { get; set; }
        public DateTime returnDate { get; set; }
        public DateTime deadlineDate { get; set; }
        public double Price { get; set; }
        public double Peny { get; set; }
        public bool CheckFlag { get; set; }

        public ClientFilm() { }

        public ClientFilm(Film clientFilm, DateTime leaseDate, DateTime deadlineDate)
        {
            this.clientFilm = clientFilm;
            this.leaseDate = leaseDate;
            this.deadlineDate = deadlineDate;
            Price = 0;
            Peny = 0;
            CheckFlag = false;
        }

        public double LateDayCount()
        {
            if (DateTime.Today > deadlineDate)
                return DateTime.Today.Date.Subtract(this.deadlineDate.Date).TotalDays;
            else
                return 0;
        }

        public double EndPrice()
        {
            return DateTime.Today.Date.Subtract(this.leaseDate.Date).TotalDays * this.Price + Peny * LateDayCount();
        }
    }
}