using System;
using System.Windows.Forms;
using FilmRental_CLibrary;

namespace FilmRental_FApp.FilmRental_Forms
{
    public partial class RegCForm : Form
    {
        MainMenuForm _menuForm = new MainMenuForm();
        Storage _storage = new Storage();
        Validator _validator = new Validator();

        //public RegCForm(CashierLogForm cashierLogForm)
        //{
        //    InitializeComponent();
        //}

        public RegCForm(MainMenuForm mainMenu)
        {
            InitializeComponent();
            _menuForm = mainMenu;
            _storage = _menuForm.GetStorage();
        }

        //Обработка записи в поля ввода
        private void NameTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) ||
                (NameTextBox1.TextLength == 0 && char.IsLower(e.KeyChar)) ||
                (NameTextBox1.TextLength > 0 && !char.IsLower(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                TextErrorProvider.SetError(NameTextBox1, "Недопустимый символ!");
            }
            else
                TextErrorProvider.Clear();
        }

        private void NameTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) ||
                (NameTextBox2.TextLength == 0 && char.IsLower(e.KeyChar)) ||
                (NameTextBox2.TextLength > 0 && !char.IsLower(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                TextErrorProvider.SetError(NameTextBox2, "Недопустимый символ!");
            }
            else
                TextErrorProvider.Clear();
        }

        private void NameTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) ||
                (NameTextBox3.TextLength == 0 && char.IsLower(e.KeyChar)) ||
                (NameTextBox3.TextLength > 0 && !char.IsLower(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                TextErrorProvider.SetError(NameTextBox3, "Недопустимый символ!");
            }
            else
                TextErrorProvider.Clear();
        }

        private void PNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar) && PNumTextBox.TextLength > 1 && PNumTextBox.TextLength < 9 && !char.IsControl(e.KeyChar)) ||
               (PNumTextBox.TextLength < 2 && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) ||
               (PNumTextBox.TextLength < 2 && char.IsLower(e.KeyChar) && !char.IsControl(e.KeyChar)) ||
               (PNumTextBox.TextLength > 8 && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                TextErrorProvider.SetError(PNumTextBox, "Недопустимый символ!");
            }
            else
                TextErrorProvider.Clear();
        }

        private void AgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                TextErrorProvider.SetError(AgeTextBox, "Недопустимый символ!");
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

        private void LimitDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
