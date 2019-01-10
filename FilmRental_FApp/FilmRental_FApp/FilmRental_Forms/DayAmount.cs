using System;
using System.Windows.Forms;
using FilmRental_CLibrary;

namespace FilmRental_FApp.FilmRental_Forms
{
    public partial class DayAmount : Form
    {
        Storage _storage = new Storage();
        MainMenuForm _mainMenuForm = new MainMenuForm();
        Client _client = null;
        Film _film = null;

        public DayAmount()
        {
            InitializeComponent();
        }

        public DayAmount(MainMenuForm mainMenu, Client cl, Film fl) 
        {
            InitializeComponent();
            this._mainMenuForm = mainMenu;
            this._storage = mainMenu.GetStorage();
            this._client = cl;
            this._film = fl;
        }

        private void DayAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                TextErrorProvider.SetError(DayAmountTextBox, "Недопустимый символ!");
            }
            else
            {
                TextErrorProvider.Clear();
            }               
        }

        private void GiveButton_Click(object sender, EventArgs e)
        {
            if (DayAmountTextBox.Text == String.Empty ||
                Convert.ToInt16(DayAmountTextBox.Text) > 7 || Convert.ToInt16(DayAmountTextBox.Text) < 1)
            {
                MessageBox.Show("Недопустимые данные!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClientFilm cFilm = new ClientFilm(this._film, DateTime.Today, DateTime.Today.AddDays(Convert.ToDouble(DayAmountTextBox.Text)));
                this._film.Available = false;
                cFilm.clientFilm.Available = false;
                this._client.AddClienFilm(cFilm);
                this._mainMenuForm.FilmUp(-1);
                MessageBox.Show("Фильм выдан клиенту.", "Выдача", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
