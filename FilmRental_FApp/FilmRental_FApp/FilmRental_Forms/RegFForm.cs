using System;
using System.Drawing;
using System.Windows.Forms;
using FilmRental_CLibrary;
using System.Text.RegularExpressions;

namespace FilmRental_FApp.FilmRental_Forms
{
    public partial class RegFForm : Form
    {
        MainMenuForm _menuForm = new MainMenuForm();
        Storage _storage = new Storage();
        Validator _validator = new Validator();

        public RegFForm()
        {
            InitializeComponent();
        }

        public RegFForm(MainMenuForm mainMenu)
        {
            InitializeComponent();
            _menuForm = mainMenu;
            _storage = _menuForm.GetStorage();
            
        }
        
        //Обработка записи в поля ввода
        private void TitleTextBox_Leave(object sender, EventArgs e)
        {
            string zipCodePattern3 = @"^[A-Z]{1}[a-z]*$";
            bool isZipValid = Regex.IsMatch(TitleTextBox.Text, zipCodePattern3);
            if (!isZipValid)
            {
                MessageBox.Show("Please enter a right title");
            }
            else
                TextErrorProvider.Clear();
        }

        private void ProducerTextBox_Leave(object sender, EventArgs e)
        {
            string zipCodePattern3 = @"^[A-Z]{1}[a-z]*$";
            bool isZipValid = Regex.IsMatch(ProducerTextBox.Text, zipCodePattern3);
            if (!isZipValid)
            {
                MessageBox.Show("Please enter a right producer");
            }
            else
                TextErrorProvider.Clear();
        }

        private void YearTextBox_Leave(object sender, EventArgs e)
        {
            string zipCodePattern3 = @"^[0-9]{4}$";
            bool isZipValid = Regex.IsMatch(YearTextBox.Text, zipCodePattern3);
            if (!isZipValid)
            {
                MessageBox.Show("Please enter a right year");
            }
            else
                TextErrorProvider.Clear();
        }

        private void CountryTextBox_Leave(object sender, EventArgs e)
        {
            string zipCodePattern3 = @"^[A-Z]{1}[a-z]*$";
            bool isZipValid = Regex.IsMatch(CountryTextBox.Text, zipCodePattern3);
            if (!isZipValid)
            {
                MessageBox.Show("Please enter a right country");
            }
            else
                TextErrorProvider.Clear();
        }

        private void EighteenTextBox_Leave(object sender, EventArgs e)
        {
            string zipCodePattern3 = @"^[A-Z]{1}[a-z]*$";
            bool isZipValid = Regex.IsMatch(EighteenTextBox.Text, zipCodePattern3);
            if (!isZipValid)
            {
                MessageBox.Show("Please enter a right age");
            }
            else
                TextErrorProvider.Clear();
        }

        private void DVDTextBox_Leave(object sender, EventArgs e)
        {
            string zipCodePattern3 = @"^[0-9]*$";
            bool isZipValid = Regex.IsMatch(DVDTextBox.Text, zipCodePattern3);
            if (!isZipValid)
            {
                MessageBox.Show("Please enter a right amount of DVD");
            }
            else
                TextErrorProvider.Clear();
        }

        private void CassetteTextBox_Leave(object sender, EventArgs e)
        {
            string zipCodePattern3 = @"^[0-9]*$";
            bool isZipValid = Regex.IsMatch(CassetteTextBox.Text, zipCodePattern3);
            if (!isZipValid)
            {
                MessageBox.Show("Please enter a right amount of cassette");
            }
            else
                TextErrorProvider.Clear();
        }

        private void PriceTextBox_Leave(object sender, EventArgs e)
        {
            string zipCodePattern3 = @"^[0-9]{2}.[0-9]{2}$";
            bool isZipValid = Regex.IsMatch(PriceTextBox.Text, zipCodePattern3);
            if (!isZipValid)
            {
                MessageBox.Show("Please enter a right price");
            }
            else
                TextErrorProvider.Clear();
        }

        private void PenyTextBox_Leave(object sender, EventArgs e)
        {
            string zipCodePattern3 = @"^[0-9]{1}.[0-9]{2}$";
            bool isZipValid = Regex.IsMatch(PenyTextBox.Text, zipCodePattern3);
            if (!isZipValid)
            {
                MessageBox.Show("Please enter a right peny");
            }
            else
                TextErrorProvider.Clear();
        }
        
        //Нажатия кнопок
        private void PhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PhotoPictureBox.Image = new Bitmap(open_dialog.FileName);
                    PhotoPictureBox.Invalidate();
                }
                catch
                {
                    DialogResult result = MessageBox.Show("Невозможно открыть выбранный файл",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
       
        private void RegAButton_Click(object sender, EventArgs e)
        {
            if (TitleTextBox.Text == String.Empty || ProducerTextBox.Text == String.Empty ||
                YearTextBox.Text == String.Empty || CountryTextBox.Text == String.Empty ||
                EighteenTextBox.Text == String.Empty || DVDTextBox.Text == String.Empty ||
                PriceTextBox.Text == String.Empty || PenyTextBox.Text == String.Empty ||
                CassetteTextBox.Text == String.Empty || CategTextBox.Text == String.Empty ||
                PhotoPictureBox.Image == null)
            
            {
                MessageBox.Show("Недопустимые данные!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Film film = new Film(_storage, TitleTextBox.Text, ProducerTextBox.Text, Convert.ToInt32(YearTextBox.Text), CountryTextBox.Text, EighteenTextBox.Text, Convert.ToInt32(DVDTextBox.Text), Convert.ToInt32(CassetteTextBox.Text), PhotoPictureBox.Image, Convert.ToDouble(PriceTextBox.Text), Convert.ToDouble(PenyTextBox.Text), CategTextBox.Text, true);
                if (_validator.CopyFilm(this._storage, film))
                {
                    MessageBox.Show("Этот фильм уже зарегистрирован.", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Фильм успешно зарегистрирован.", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _storage.Add(film);
                    _menuForm.FilmUp(1);
                    Close();
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void CategTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void VolTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ProducerTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void EighteenTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}