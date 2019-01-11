using System;
using System.Windows.Forms;
using FilmRental_CLibrary;
using System.Text.RegularExpressions;

namespace FilmRental_FApp.FilmRental_Forms
{
    public partial class RegCForm : Form
    {
        MainMenuForm _menuForm = new MainMenuForm();
        Storage _storage = new Storage();
        Validator _validator = new Validator();

        public RegCForm(MainMenuForm mainMenu)
        {
            InitializeComponent();
            _menuForm = mainMenu;
            _storage = _menuForm.GetStorage();
        }

        //Обработка записи в поля ввода
        private void NameTextBox1_Leave(object sender, EventArgs e)
        {
            string zipCodePattern1 = @"^[A-Z]{1}[a-z]*$";
            bool isZipValid = Regex.IsMatch(NameTextBox1.Text, zipCodePattern1);
            if (!isZipValid)
            {
                MessageBox.Show("Please enter a right first name");
            }
            else
                TextErrorProvider.Clear();
        }

        private void NameTextBox2_Leave(object sender, EventArgs e)
        {
            string zipCodePattern2 = @"^[A-Z]{1}[a-z]*$";
            bool isZipValid = Regex.IsMatch(NameTextBox2.Text, zipCodePattern2);
            if (!isZipValid)
            {
                MessageBox.Show("Please enter a right second name");
            }
            else
                TextErrorProvider.Clear();
        }

        private void NameTextBox3_Leave(object sender, EventArgs e)
        {
            string zipCodePattern3 = @"^[A-Z]{1}[a-z]*$";
            bool isZipValid = Regex.IsMatch(NameTextBox3.Text, zipCodePattern3);
            if (!isZipValid)
            {
                MessageBox.Show("Please enter a right third name");
            }
            else
                TextErrorProvider.Clear();
        }

        private void PNumTextBox_Leave(object sender, EventArgs e)
        {
            string zipCodePattern = @"^[A-Z]{2}[0-9]{7}$";
            bool isZipValid = Regex.IsMatch(PNumTextBox.Text, zipCodePattern);
            if (!isZipValid)
            {
                MessageBox.Show("Please enter a right first name");
            }
            else
                TextErrorProvider.Clear();
        }

        private void AgeTextBox_Leave(object sender, EventArgs e)
        {
            string zipCodePattern = @"^[0-9]{2}$";
            bool isZipValid = Regex.IsMatch(AgeTextBox.Text, zipCodePattern);
            if (!isZipValid)
            {
                MessageBox.Show("Please enter a right age");
            }
            else
                TextErrorProvider.Clear();
        }

        //Регистрация клиента
        private void RegCButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox1.Text == String.Empty || NameTextBox2.Text == String.Empty ||
                NameTextBox3.Text == String.Empty || PNumTextBox.Text == String.Empty ||
                AgeTextBox.Text == String.Empty || (!MRadioButton.Checked && !FRadioButton.Checked) ||
                LimitDateTimePicker.Value <= DateTime.Today || PNumTextBox.TextLength != 9 || Convert.ToInt16(AgeTextBox.Text) > 100)
            {
                MessageBox.Show("Недопустимые данные!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sexT;
                if (MRadioButton.Checked)
                    sexT = "М";
                else
                    sexT = "Ж";

                Client client = new Client(NameTextBox1.Text, NameTextBox2.Text, NameTextBox3.Text, PNumTextBox.Text, sexT, Convert.ToInt16(AgeTextBox.Text), LimitDateTimePicker.Value, DateTime.Today);
                if (_validator.CopyClient(_storage, client))
                {
                    MessageBox.Show("Этот клиент уже зарегистрирован.", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Клиент успешно зарегистрирован.", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _storage.Add(client);
                    _menuForm.ClientUp(1);
                    Close();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LimitDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
