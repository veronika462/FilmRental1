using System;
using System.Windows.Forms;
using FilmRental_CLibrary;

namespace FilmRental_FApp.FilmRental_Forms
{
    public partial class PayForm : Form
    {
        Storage _storage = new Storage();
        MainMenuForm _mainMenuForm = new MainMenuForm();
        Client _client = new Client();
        double _end = 0;
        Validator _validator = new Validator();
        TableLayoutPanel _CCardpanel = new TableLayoutPanel();

        public PayForm()
        {
            InitializeComponent();
        }

        public PayForm(Client client, double end, TableLayoutPanel panel, MainMenuForm mainMenu)
        {
            InitializeComponent();
            _mainMenuForm = mainMenu;
            _storage = mainMenu.GetStorage();
            _client = client;
            _end = end;
            _CCardpanel = panel;
            TotalTextBox.Text = Convert.ToString(end);
        }

        private void PaidTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                TextErrorProvider.SetError(PaidTextBox, "Недопустимый символ!");
            }
            else
                TextErrorProvider.Clear();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (_validator.DotString(PaidTextBox.Text))
            {
                PaidTextBox.Clear();
                MessageBox.Show("Недопустимая оплата!", "Ошибка оплаты", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double test = Convert.ToDouble(PaidTextBox.Text) - _end;
                if(test < 0)
                {
                    PaidTextBox.Clear();
                    MessageBox.Show("Недопустимая оплата!", "Ошибка оплаты", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SurrTextBox.Text = Convert.ToString(Convert.ToDouble(PaidTextBox.Text) - _end);
                    var res = MessageBox.Show("Транзакция прошла успешно?", "Оплата", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(res == DialogResult.Yes)
                    {
                        for (int i = 0; i < _client.ListClientFilm.Count; i++)
                        {
                            if (_client.ListClientFilm[i].CheckFlag && _client.ListClientFilm[i].returnDate.Date.Year == 1)
                            {
                                _CCardpanel.Hide();
                                var control = _CCardpanel.GetControlFromPosition(4, i + 9);
                                _CCardpanel.Controls.Remove(control);
                                TextBox ReturnDate = new TextBox();
                                ReturnDate.Enabled = false;
                                ReturnDate.Text = DateTime.Today.ToString("d");
                                _client.ListClientFilm[i].returnDate = DateTime.Today;
                                _CCardpanel.Controls.Add(ReturnDate, 4, i + 9);
                                var checkcontrol = _CCardpanel.GetControlFromPosition(i + 9, 9);
                                checkcontrol.Enabled = false;
                                checkcontrol.Hide();
                                //в сигнал из списка

                                foreach(Film a in _storage.GetFilmList())
                                {
                                    if(a == _client.ListClientFilm[i].clientFilm)
                                    {
                                        a.Available = true;
                                        _mainMenuForm.FilmUp(1);
                                    }
                                }

                                _CCardpanel.Show();
                            }
                        }
                    }
                    Close();
                } 
            }
        }
    }
}
