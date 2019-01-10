using System;
using System.Collections.Generic;


namespace FilmRental_CLibrary
{
    public class Client
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string PassNum { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public DateTime Limit { get; set; }
        public DateTime RegTime { get; set; }
        public bool Debt { get; set; }
        //Для карточки
        public List<ClientFilm> ListClientFilm { get; set; }   

        public Client() { }

        public Client(string name, string secondname, string thirdname, string passNum, string sex, short age, DateTime limit, DateTime regtime)
        {
            Name = name;
            SecondName = secondname;
            ThirdName = thirdname;
            PassNum = passNum;
            Sex = sex;
            Age = age;
            Limit = limit;
            RegTime = regtime;
            Debt = false;
            ListClientFilm = new List<ClientFilm>();
        }

        public void SetClient(string name, string secondname, string thirdname, string passNum, string sex, int age, DateTime limit, DateTime regtime, bool debt)
        {
            Name = name;
            SecondName = secondname;
            ThirdName = thirdname;
            PassNum = passNum;
            Sex = sex;
            Age = age;
            Limit = limit;
            RegTime = regtime;
            Debt = debt;
        }
        

        public void AddClienFilm(ClientFilm cfilm)
        {
            ListClientFilm.Add(cfilm);
        }

    }
}
