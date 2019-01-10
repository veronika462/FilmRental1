using System;
using System.Windows.Forms;
using FilmRental_CLibrary;

namespace FilmRental_FApp
{
    public partial class CashierLogForm : Form
    {
        private Storage storage;

        public Storage GetStorage()
        {
            return storage;
        }

        public CashierLogForm()
        {
            InitializeComponent();
            storage = new Storage();
        }
        //Кнопки
        private void ListClientButton1_Click(object sender, EventArgs e)
        {
            FilmRental_Forms.ListCForm listC = new FilmRental_Forms.ListCForm(this);
            listC.Show();
        }

        private void ListFilmButton1_Click(object sender, EventArgs e)
        {
            FilmRental_Forms.ListFForm listF = new FilmRental_Forms.ListFForm(this);
            listF.Show();
        }

        private void RegCButton1_Click(object sender, EventArgs e)
        {
            FilmRental_Forms.RegCForm regC = new FilmRental_Forms.RegCForm(this);
            regC.Show();
        }
    }
}
