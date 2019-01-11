using System;
using System.Windows.Forms;
using FilmRental_CLibrary;
using System.Text.RegularExpressions;

namespace FilmRental_FApp.FilmRental_Forms
{
    public partial class RegIDForm : Form
    {
        MainMenuForm _menuForm = new MainMenuForm();
        Storage _storage = new Storage();
        Validator _validator = new Validator();
        RegFForm _regF = null;

        public RegIDForm()
        {
            InitializeComponent();
        }

        public RegIDForm(MainMenuForm mainMenu)
        {
            InitializeComponent();
           _menuForm = mainMenu;
           _storage = _menuForm.GetStorage();
        }

        public RegIDForm(MainMenuForm mainMenu, RegFForm regFForm)
        {
            InitializeComponent();
            _regF = regFForm;
            _menuForm = mainMenu;
            _storage = _menuForm.GetStorage();
        }

        //Обработка записи в поля ввода
        private void BTypeTextBox_Leave(object sender, EventArgs e)
        {
            string zipCodePattern3 = @"^[A-Z]{1}[a-z]*$";
            bool isZipValid = Regex.IsMatch(BTypeTextBox.Text, zipCodePattern3);
            if (!isZipValid)
            {
                MessageBox.Show("Please enter a right category");
            }
            else
                TextErrorProvider.Clear();
        }

        private void CNumTextBox_Leave(object sender, EventArgs e)
        {
            string zipCodePattern3 = @"^[A-Z]{2}$";
            bool isZipValid = Regex.IsMatch(CNumTextBox.Text, zipCodePattern3);
            if (!isZipValid)
            {
                MessageBox.Show("Please enter a right code");
            }
            else
                TextErrorProvider.Clear();
        }

        //Регистрация Категории
        private void RegIDButton_Click(object sender, EventArgs e)
        {
            if (BTypeTextBox.Text == String.Empty ||
                CNumTextBox.Text == String.Empty ||
                CNumTextBox.TextLength != 2)
            {
                MessageBox.Show("Недопустимые данные!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Category category = new Category(BTypeTextBox.Text, CNumTextBox.Text);
                if(_validator.CopyCategory(_storage, category))
                {
                    MessageBox.Show("Эта категория уже зарегистрирована.", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Категория успешно зарегистрирована.", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _storage.Add(category);
                    Close();
                    
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CNumTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
