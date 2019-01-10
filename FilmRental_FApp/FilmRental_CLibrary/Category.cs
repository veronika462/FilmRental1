using System;

namespace FilmRental_CLibrary
{
    public class Category
    {
        public string CatName { get; set; }
        public string CatID { get; set; }

        public Category(string catName, string catID)
        {
            CatName = catName;
            CatID = catID;
        }
    }
}
