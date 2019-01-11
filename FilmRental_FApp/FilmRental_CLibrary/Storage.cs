using System.Collections.Generic;


namespace FilmRental_CLibrary
{
    public class Storage
    {
        private List<Client> ListClient { get; set; }
        private List<Film> ListFilm { get; set; }
        private List<Category> ListCategory { get; set; }

        public Storage()
        {
            ListClient = new List<Client>();
            ListFilm = new List<Film>();
            ListCategory = new List<Category>();
        }

        public List<Client> GetClientList()
        {
            return ListClient;
        }

        public void SetClientList (List<Client> listC)
        {
            ListClient = listC;
        }

        public void Add (Client element)
        {
            ListClient.Add(element);
        }  

        public List<Film> GetFilmList()
        {
            return ListFilm;
        }

        public void SetFilmList(List<Film> listF)
        {
            ListFilm = listF;
        }

        public void Add(Film element)
        {
            ListFilm.Add(element);
        }

        public List<Category> GetCategoryList()
        {
            return  ListCategory;
        }

        public void SetCategoryList(List<Category> listCat)
        {
            ListCategory = listCat;
        }

        public void Add(Category element)
        {
            ListCategory.Add(element);
        }
    }
}
