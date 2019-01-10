using System;
using System.Windows.Forms;
using FilmRental_CLibrary;
using System.Text.RegularExpressions;

namespace FilmRental_FApp.FilmRental_Forms
{
    public partial class ListCForm : Form
    {
        Storage _storage = new Storage();
        MainMenuForm _mainMenuForm = new MainMenuForm();
        Client _client = new Client();

        //Создание списка на экране
        public ListCForm()
        {
            InitializeComponent();
        }

        public ListCForm(MainMenuForm mainMenu)
        {
            InitializeComponent();
            _mainMenuForm = mainMenu;
            _storage = mainMenu.GetStorage();

            for (int i = 0; i < _storage.GetClientList().Count; i++)
            {
                PrintRow(_storage.GetClientList()[i]);
            }
        }

        private void PrintRow(Client client)
        {
            _client = client;
            TextBox PassNum = new TextBox();
            PassNum.Enabled = false;
            PassNum.Text = client.PassNum;
            TextBox Name = new TextBox();
            Name.Enabled = false;
            Name.Text = client.Name;
            TextBox SecondName = new TextBox();
            SecondName.Enabled = false;
            SecondName.Text = client.SecondName;
            TextBox ThirdName = new TextBox();
            ThirdName.Enabled = false;
            ThirdName.Text = client.ThirdName;
            TextBox Sex = new TextBox();
            Sex.Enabled = false;
            Sex.Text = client.Sex;
            TextBox Age = new TextBox();
            Age.Enabled = false;
            Age.Text = Convert.ToString(client.Age);
            TextBox LicenseLimit = new TextBox();
            LicenseLimit.Text = client.Limit.ToString("d");
            LicenseLimit.Enabled = false;
            CheckBox Debt = new CheckBox();
            Debt.Checked = client.Debt;
            Debt.Enabled = false;
            Button button = new Button();
            button.Text = "Открыть";
            button.Click += openbutton_Click;
            int i = ClientListTableLayoutPanel.RowCount;
            ClientListTableLayoutPanel.RowCount++;
            ClientListTableLayoutPanel.Size = new System.Drawing.Size(ClientListTableLayoutPanel.Size.Width, ClientListTableLayoutPanel.Size.Height + 40);
            ClientListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40));
            ClientListTableLayoutPanel.Controls.Add(PassNum, 0, i);
            ClientListTableLayoutPanel.Controls.Add(Name, 1, i);
            ClientListTableLayoutPanel.Controls.Add(SecondName, 2, i);
            ClientListTableLayoutPanel.Controls.Add(ThirdName, 3, i);
            ClientListTableLayoutPanel.Controls.Add(Sex, 4, i);
            ClientListTableLayoutPanel.Controls.Add(Age, 5, i);
            ClientListTableLayoutPanel.Controls.Add(LicenseLimit, 6, i);
            ClientListTableLayoutPanel.Controls.Add(Debt, 7, i);
            ClientListTableLayoutPanel.Controls.Add(button, 8, i);
        }

        private void ClearTable()
        {
            int row_index_to_remove = 1;
            TableLayoutPanel panel = ClientListTableLayoutPanel;
            if (row_index_to_remove >= panel.RowCount)
            {
                return;
            }
            for (int j = 1; j < panel.RowCount; j++)
            {
                // delete all controls of row that we want to delete
                for (int i = 0; i < panel.ColumnCount; i++)
                {
                    var control = panel.GetControlFromPosition(i, j);
                    panel.Controls.Remove(control);
                }
            }
            int end = panel.RowCount;
            for (int j = 1; j < end; j++)
            {
                panel.RowStyles.RemoveAt(panel.RowCount - 1);
                panel.RowCount--;
                ClientListTableLayoutPanel.Size = new System.Drawing.Size(ClientListTableLayoutPanel.Size.Width, ClientListTableLayoutPanel.Size.Height - 40);
            }
        }

        private void openbutton_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            FilmRental_Forms.ClientCardForm cCard = new ClientCardForm(this._mainMenuForm, this._client);
            cCard.Show();
        }

        //Действия ГУИ
        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (NameRadioButton1.Checked)
            {
                string zipCodePattern = @"^[A-Z]{1}[a-z]*$";
                bool isZipValid = Regex.IsMatch(SearchTextBox.Text, zipCodePattern);
                if (!isZipValid)
                {
                MessageBox.Show("Please enter a valid zip code");
                }
                else
                    TextErrorProvider.Clear();
            }
            else
            {
                string zipCodePattern1 = @"^[A-Z]{2}[0-9]{7}$";
                bool isZipValid = Regex.IsMatch(SearchTextBox.Text, zipCodePattern1);
                if (!isZipValid)
                {
                    MessageBox.Show("Please enter a valid zip code");
                }
                else
                    TextErrorProvider.Clear();
            }
            //else
            //    TextErrorProvider.Clear();
        
        }

        private void PNumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            TextErrorProvider.Clear();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == String.Empty) //|| (PNumRadioButton.Checked && SearchTextBox.TextLength != 9))
            {
                SearchTextBox.Clear();
                MessageBox.Show("Недопустимые данные!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.ClientListTableLayoutPanel.Hide();
                TextErrorProvider.Clear();
                ClearTable();
                for (int i = 0; i < _storage.GetClientList().Count; i++)
                {
                    if (PNumRadioButton.Checked)
                    {
                        if (_storage.GetClientList()[i].PassNum.Contains(SearchTextBox.Text))
                            PrintRow(_storage.GetClientList()[i]);
                    }
                    else
                    {
                        if (_storage.GetClientList()[i].Name.Contains(SearchTextBox.Text))
                            PrintRow(_storage.GetClientList()[i]);
                    }
                }
                ClientListTableLayoutPanel.Show();
            }
        }

        private void UpDButton_Click(object sender, EventArgs e)
        {
            FilmRental_Forms.ListCForm listC = new FilmRental_Forms.ListCForm(_mainMenuForm);
            listC.Show();
            Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void ClientListTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
