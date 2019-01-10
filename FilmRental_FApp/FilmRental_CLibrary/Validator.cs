using System.Collections.Generic;


namespace FilmRental_CLibrary
{
    public class Validator
    {
        //Клиент уже зарегистрирован?
        public bool CopyClient(Storage storage, Client client)
        {
            foreach(var c in storage.GetClientList())
                if (c.PassNum == client.PassNum)
                    return true;
            return false;
        }

        //фильм уже зарегистрирован?
        public bool CopyFilm(Storage storage, Film film)
        {
            foreach (var f in storage.GetFilmList())
                if (f.FilmID == film.FilmID)
                    return true;
            return false;
        }

        //Категория уже зарегистрирована?
        public bool CopyCategory(Storage storage, Category category)
        {
            foreach (var c in storage.GetCategoryList())
                if (c.CatID == category.CatID)
                    return true;
            return false;
        }

        //Строка имеет ","
        public bool DotString(string str)
        {
            char[] csrt = str.ToCharArray();
            int k = 0;
            foreach(char c in csrt)
                if(c == ',')
                {
                    k++;
                    if (k == 2)
                        return true;
                }
            return false;
        }

        public bool FilmHands(List<ClientFilm> cFilm)
        {
            int count = 0;
            foreach (ClientFilm cF in cFilm)
                if(cF.returnDate.Date.Year == 1)
                    count++;
            if (count > 5)
                return true;
            else
                return false;
        }
    }
}
