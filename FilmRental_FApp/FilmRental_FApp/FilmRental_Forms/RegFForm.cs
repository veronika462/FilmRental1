using System;
using System.Drawing;
using System.Windows.Forms;
using FilmRental_CLibrary;

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
        private void TitleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) ||
            //    (TitleTextBox.TextLength == 0 && char.IsLower(e.KeyChar)) ||
            //    (TitleTextBox.TextLength > 0 && !char.IsLower(e.KeyChar) && !char.IsControl(e.KeyChar)))
            //{
            //    e.Handled = true;
            //    TextErrorProvider.SetError(TitleTextBox, "Недопустимый символ!");
            //}
            //else
            //    TextErrorProvider.Clear();
        }

        private void ProducerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) ||
            //    (ProducerTextBox.TextLength == 0 && char.IsLower(e.KeyChar)) ||
            //    (ProducerTextBox.TextLength > 0 && !char.IsLower(e.KeyChar) && !char.IsControl(e.KeyChar)))
            //{
            //    e.Handled = true;
            //    TextErrorProvider.SetError(ProducerTextBox, "Недопустимый символ!");
            //}
            //else
            //    TextErrorProvider.Clear();
        }

        private void YearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) ||
            //    (YearTextBox.TextLength == 4 && !char.IsControl(e.KeyChar)))
            //{
            //    e.Handled = true;
            //    TextErrorProvider.SetError(YearTextBox, "Недопустимый символ!");
            //}
            //else
            //    TextErrorProvider.Clear();
        }

        private void CountryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) ||
            //    (CountryTextBox.TextLength == 0 && char.IsLower(e.KeyChar)) ||
            //    (CountryTextBox.TextLength > 0 && !char.IsLower(e.KeyChar) && !char.IsControl(e.KeyChar)))
            //{
            //    e.Handled = true;
            //    TextErrorProvider.SetError(CountryTextBox, "Недопустимый символ!");
            //}
            //else
            //    TextErrorProvider.Clear();
        }

        private void EighteenTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //    TextErrorProvider.SetError(EighteenTextBox, "Недопустимый символ!");
            //}
            //else
            //    TextErrorProvider.Clear();
        }

        private void DVDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //    TextErrorProvider.SetError(DVDTextBox, "Недопустимый символ!");
            //}
            //else
            //    TextErrorProvider.Clear();
        }

        private void CassetteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //    TextErrorProvider.SetError(CassetteTextBox, "Недопустимый символ!");
            //}
            //else
            //    TextErrorProvider.Clear();
        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //    TextErrorProvider.SetError(PriceTextBox, "Недопустимый символ!");
            //}
            //else
            //    TextErrorProvider.Clear();
        }

        private void PenyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //    TextErrorProvider.SetError(PenyTextBox, "Недопустимая Цена!");
            //}
            //else
            //    TextErrorProvider.Clear();
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
            //if (TitleTextBox.Text == String.Empty || ProducerTextBox.Text == String.Empty ||
            //    YearTextBox.Text == String.Empty || CountryTextBox.Text == String.Empty ||
            //    EighteenTextBox.Text == String.Empty || DVDTextBox.Text == String.Empty ||
            //    PriceTextBox.Text == String.Empty || PenyTextBox.Text == String.Empty ||
            //    CassetteTextBox.Text == String.Empty || CategTextBox.Text == String.Empty || 
            //    PhotoPictureBox.Image == null  ||
            //    (!ARadioButton.Checked && !MRadioButton.Checked) ||
            //    YearTextBox.TextLength != 4 || validator.DotString(EighteenTextBox.Text) ||
            //    validator.DotString(DVDTextBox.Text) || validator.DotString(CassetteTextBox.Text) ||
            //    validator.DotString(PriceTextBox.Text) || validator.DotString(PenyTextBox.Text) ||
            //    Convert.ToDouble(PenyTextBox.Text) < 0.0 || Convert.ToDouble(PenyTextBox.Text) > 100.0)
            //{
            //    MessageBox.Show("Недопустимые данные!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{


            Film film = new Film(_storage, TitleTextBox.Text, ProducerTextBox.Text, Convert.ToInt32(YearTextBox.Text), CountryTextBox.Text, Convert.ToDouble(EighteenTextBox.Text), Convert.ToDouble(DVDTextBox.Text), Convert.ToDouble(CassetteTextBox.Text), PhotoPictureBox.Image, Convert.ToDouble(PriceTextBox.Text), Convert.ToDouble(PenyTextBox.Text), CategTextBox.Text, true);
            //    if(validator.CopyFilm(this.storage, film))
            //    {
            //        MessageBox.Show("Этот фильм уже зарегистрирован.", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            MessageBox.Show("Фильм успешно зарегистрирован.", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _storage.Add(film);
                    _menuForm.FilmUp(1);
                    Close();
            //    }
            //}
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
