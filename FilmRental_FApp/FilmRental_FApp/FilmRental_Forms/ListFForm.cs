using System;
using System.Windows.Forms;
using FilmRental_CLibrary;
using System.Text.RegularExpressions;

namespace FilmRental_FApp.FilmRental_Forms
{
    public partial class ListFForm : Form
    {
        Storage _storage = new Storage();
        MainMenuForm _mainMenuForm = new MainMenuForm();
        Client _client = null;
        Film _film = null;

        public ListFForm()
        {
            InitializeComponent();
        }

        public ListFForm(MainMenuForm mainMenu)
        {
            InitializeComponent();
            this._mainMenuForm = mainMenu;
            this._storage = mainMenu.GetStorage();

            for (int i = 0; i < this._storage.GetFilmList().Count; i++)
            {
                PrintRow(this._storage.GetFilmList()[i]);
            }
        }

        public ListFForm(MainMenuForm mainMenu, Client cl)
        {
            InitializeComponent();
            this._mainMenuForm = mainMenu;
            this._storage = mainMenu.GetStorage();
            this._client = cl;

            for (int i = 0; i < this._storage.GetFilmList().Count; i++)
            {
                PrintRow(this._storage.GetFilmList()[i]);
            }
        }

        //Действия с таблицей
        private void PrintRow(Film auto)
        {
            if (!auto.Available)
                return;
            this._film = auto;
            TextBox FilmID = new TextBox();
            FilmID.Enabled = false;
            FilmID.Text = auto.FilmID;
            TextBox Title = new TextBox();
            Title.Enabled = false;
            Title.Text = auto.Title;
            TextBox Producer = new TextBox();
            Producer.Enabled = false;
            Producer.Text = auto.Producer;
            TextBox Year = new TextBox();
            Year.Enabled = false;
            Year.Text = Convert.ToString(auto.Year);
            TextBox Country = new TextBox();
            Country.Enabled = false;
            Country.Text = auto.Country;
            TextBox Eighteen = new TextBox();
            Eighteen.Enabled = false;
            Eighteen.Text = Convert.ToString(auto.Eighteen);
            TextBox DVD = new TextBox();
            DVD.Enabled = false;
            DVD.Text = Convert.ToString(auto.DVD);
            TextBox Cassette = new TextBox();
            Cassette.Enabled = false;
            Cassette.Text = Convert.ToString(auto.Cassette);
            TextBox Price = new TextBox();
            Price.Enabled = false;
            Price.Text = Convert.ToString(auto.Price);
            TextBox Peny = new TextBox();
            Peny.Enabled = false;
            Peny.Text = Convert.ToString(auto.Peny);
            Button button = new Button();
            if (this._client != null)
                button.Enabled = true;
            else
                button.Enabled = false;
            button.Text = "Выдать";
            button.Click += addbutton_Click;
            
            int i = this.FilmListTableLayoutPanel.RowCount;
            this.FilmListTableLayoutPanel.RowCount++;
            this.FilmListTableLayoutPanel.Size = new System.Drawing.Size(FilmListTableLayoutPanel.Size.Width, FilmListTableLayoutPanel.Size.Height + 70);
            this.FilmListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70));
            this.FilmListTableLayoutPanel.Controls.Add(FilmID, 0, i);
            this.FilmListTableLayoutPanel.Controls.Add(Title, 1, i);
            this.FilmListTableLayoutPanel.Controls.Add(Producer,2, i);
            this.FilmListTableLayoutPanel.Controls.Add(Year, 3, i);
            this.FilmListTableLayoutPanel.Controls.Add(Country, 4, i);
            this.FilmListTableLayoutPanel.Controls.Add(Eighteen, 5, i);
            this.FilmListTableLayoutPanel.Controls.Add(DVD, 6, i);
            this.FilmListTableLayoutPanel.Controls.Add(Cassette, 7, i);
            this.FilmListTableLayoutPanel.Controls.Add(Price, 8, i);
            this.FilmListTableLayoutPanel.Controls.Add(Peny, 9, i);
            this.FilmListTableLayoutPanel.Controls.Add(button, 10, i);
        }

        private void ClearTable()
        {
            int row_index_to_remove = 1;
            TableLayoutPanel panel = this.FilmListTableLayoutPanel;
            if (row_index_to_remove >= panel.RowCount)
            {
                return;
            }
            for (int j = 1; j < panel.RowCount; j++)
            {
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
                this.FilmListTableLayoutPanel.Size = new System.Drawing.Size(FilmListTableLayoutPanel.Size.Width, FilmListTableLayoutPanel.Size.Height - 70);
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            FilmRental_Forms.DayAmount dayAmount = new DayAmount(this._mainMenuForm, this._client, this._film);
            dayAmount.Show();
            this.Close();
        }

        private void UpDButton_Click(object sender, EventArgs e)
        {
            FilmRental_Forms.ListFForm listA = new FilmRental_Forms.ListFForm(this._mainMenuForm);
            listA.Show();
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == String.Empty) 
            {
                SearchTextBox.Clear();
                MessageBox.Show("Недопустимые данные!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.FilmListTableLayoutPanel.Hide();
                TextErrorProvider.Clear();
                ClearTable();

                for (int i = 0; i < this._storage.GetFilmList().Count; i++)
                {
                    if (TitleRadioButton.Checked)
                    {
                        if (this._storage.GetFilmList()[i].Producer.Contains(SearchTextBox.Text))
                            PrintRow(this._storage.GetFilmList()[i]);
                    }
                    else if (YearRadioButton.Checked)
                    {
                        if (Convert.ToString(this._storage.GetFilmList()[i].Year).Contains(SearchTextBox.Text))
                            PrintRow(this._storage.GetFilmList()[i]);
                    }
                    else if (INumRadioButton.Checked)
                    {
                        if (this._storage.GetFilmList()[i].FilmID.Contains(SearchTextBox.Text))
                            PrintRow(this._storage.GetFilmList()[i]);
                    }
                    else 
                    {
                        if (this._storage.GetFilmList()[i].Category.Contains(SearchTextBox.Text))
                            PrintRow(this._storage.GetFilmList()[i]);
                    }
                }
                this.FilmListTableLayoutPanel.Show();
            }
        }

        //Обработка ввода
       
        private void TitleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            TextErrorProvider.Clear();
        }

        private void YearRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            TextErrorProvider.Clear();
        }

        private void INumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            TextErrorProvider.Clear();
        }

        private void CategRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            TextErrorProvider.Clear();
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (YearRadioButton.Checked)
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
            else if (INumRadioButton.Checked)
            {
                string zipCodePattern1 = @"^[A-Z]{1}[a-z]*$";
                bool isZipValid = Regex.IsMatch(SearchTextBox.Text, zipCodePattern1);
                if (!isZipValid)
                {
                    MessageBox.Show("Please enter a valid zip code");
                }
                else
                    TextErrorProvider.Clear();
            }
            else if (CategRadioButton.Checked)
            {
                string zipCodePattern2 = @"^[A-Z]{1}[a-z]*$";
                bool isZipValid = Regex.IsMatch(SearchTextBox.Text, zipCodePattern2);
                if (!isZipValid)
                {
                    MessageBox.Show("Please enter a valid zip code");
                }
                else
                    TextErrorProvider.Clear();
            }
            else
            {
                string zipCodePattern3 = @"^[A-Z]{1}[a-z]*$";
                bool isZipValid = Regex.IsMatch(SearchTextBox.Text, zipCodePattern3);
                if (!isZipValid)
                {
                    MessageBox.Show("Please enter a valid zip code");
                }
                else
                    TextErrorProvider.Clear();
            }
        }

        private void FilmListTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BrandRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
