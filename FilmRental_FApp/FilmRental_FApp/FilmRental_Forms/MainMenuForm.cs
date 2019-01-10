using System;
using System.Windows.Forms;
using FilmRental_CLibrary;

namespace FilmRental_FApp
{
    public partial class MainMenuForm : Form
    {
        private Storage storage;

        public Storage GetStorage()
        {
            return storage;
        }

        public MainMenuForm()
        {
            InitializeComponent();
            storage = new Storage();
        }

        //Обновление статусбара
        public void ClientUp(int i)
        {
            int now = Convert.ToInt32(NumCTextBox.Text) + i;
            NumCTextBox.Text = Convert.ToString(now);
            if (now < 0)
            {
                MessageBox.Show("Количество клиентов стало отрицательным!", "Ошибка статуса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        public void FilmUp(int i)
        {
            int now = Convert.ToInt32(NumFTextBox.Text) + i;
            NumFTextBox.Text = Convert.ToString(now);
            if (now < 0)
            {
                MessageBox.Show("Количество автомобилей стало отрицательным!", "Ошибка статуса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        //Кнопки
        private void ListClientButton_Click(object sender, EventArgs e)
        {
            FilmRental_Forms.ListCForm listC = new FilmRental_Forms.ListCForm(this);
            listC.Show();
        }

        private void ListFilmButton_Click(object sender, EventArgs e)
        {
            FilmRental_Forms.ListFForm listF = new FilmRental_Forms.ListFForm(this);
            listF.Show();
        }

        private void RegCButton_Click(object sender, EventArgs e)
        {
            FilmRental_Forms.RegCForm regC = new FilmRental_Forms.RegCForm(this);
            regC.Show();
        }

        private void RegFButton_Click(object sender, EventArgs e)
        {
            FilmRental_Forms.RegFForm regA = new FilmRental_Forms.RegFForm(this);
            regA.Show();
        }

        private void RegIDButton_Click(object sender, EventArgs e)
        {
            FilmRental_Forms.RegIDForm regID = new FilmRental_Forms.RegIDForm();
            regID.Show();
        }

        private void NumFTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
