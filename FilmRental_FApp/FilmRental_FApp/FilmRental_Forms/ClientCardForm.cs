using System;
using System.Windows.Forms;
using FilmRental_CLibrary;
using Microsoft.Office.Interop.Excel;

namespace FilmRental_FApp.FilmRental_Forms
{
    public partial class ClientCardForm : Form
    {
        private Microsoft.Office.Interop.Excel.Application exapp;
        private Microsoft.Office.Interop.Excel.Worksheet exsheet;
        private Microsoft.Office.Interop.Excel.Workbook exbook;

        private Storage _storage = new Storage();
        MainMenuForm _mainMenuForm = new MainMenuForm();
        Client _client = null;
        ClientFilm _clientFilm = new ClientFilm();
        Validator _validator = new Validator();

        public ClientCardForm()
        {
            InitializeComponent();
        }

        public ClientCardForm(MainMenuForm mainMenu, Client cl)
        {
            InitializeComponent();
            _mainMenuForm = mainMenu;
            _storage = mainMenu.GetStorage();
            _client = cl;
            AboutClient();
            int i = 0;
            foreach(var auto in cl.ListClientFilm)
            {
               PrintRow(auto, i);
               i++;
            }
        }

        private void AboutClient()
        {
            string[] FIOclient = { _client.Name, _client.SecondName, _client.ThirdName };
            ClientLabel.Text = string.Join(" ", FIOclient);
            SexLabel.Text = _client.Sex;
            AgeLabel.Text = Convert.ToString(_client.Age);
            RegLabel.Text = _client.RegTime.ToString("d");
            
            if (_client.Debt)
                DebtLabel.Text = "должник";
            else
                DebtLabel.Text = "не должник";
        }
        
        private void checkBox_Checked(object sender, EventArgs e)
        {
            var temp = _clientFilm.CheckFlag;
            _clientFilm.CheckFlag = !temp;
        }

        public void PrintRow(ClientFilm cFilm, int row)
        {
            _clientFilm = cFilm;
            int j = row;
            System.Windows.Forms.TextBox filmID = new System.Windows.Forms.TextBox();
            filmID.Enabled = false;
            filmID.Text = cFilm.clientFilm.FilmID;
            System.Windows.Forms.TextBox Title = new System.Windows.Forms.TextBox();
            Title.Enabled = false;
            Title.Text = cFilm.clientFilm.Producer;
            System.Windows.Forms.TextBox LeaseDate = new System.Windows.Forms.TextBox();
            LeaseDate.Text = cFilm.leaseDate.ToString("d");
            LeaseDate.Enabled = false;
            System.Windows.Forms.TextBox ReturnDate = new System.Windows.Forms.TextBox();
            ReturnDate.Enabled = false;
            System.Windows.Forms.TextBox LateDay = new System.Windows.Forms.TextBox();
            LateDay.Enabled = false;
            if (cFilm.returnDate.Date.Year == 1)
            {
                ReturnDate.Text = "";
                LateDay.Text = "";
            }
            else
            {
                LateDay.Text = Convert.ToString(cFilm.LateDayCount());
                ReturnDate.Text = cFilm.returnDate.ToString("d");
            }
            System.Windows.Forms.TextBox Price = new System.Windows.Forms.TextBox();
            Price.Enabled = false;
            Price.Text = Convert.ToString(cFilm.Price);
            System.Windows.Forms.TextBox Peny = new System.Windows.Forms.TextBox();
            Peny.Enabled = false;
            Peny.Text = Convert.ToString(cFilm.Peny);
            System.Windows.Forms.TextBox End = new System.Windows.Forms.TextBox();
            End.Enabled = false;
            End.Text = Convert.ToString(cFilm.EndPrice());
            System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
            checkBox.Checked = false;
            checkBox.Name = Convert.ToString(j);
            checkBox.CheckedChanged += checkBox_Checked;

            int i = ClientCardTableLayoutPanel.RowCount;
            ClientCardTableLayoutPanel.RowCount++;
            ClientCardTableLayoutPanel.Size = new System.Drawing.Size(ClientCardTableLayoutPanel.Size.Width, ClientCardTableLayoutPanel.Size.Height + 40);
            ClientCardTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40));
            ClientCardTableLayoutPanel.Controls.Add(filmID, 0, i);
            ClientCardTableLayoutPanel.Controls.Add(Title, 1, i);
            ClientCardTableLayoutPanel.Controls.Add(LeaseDate, 2, i);
            ClientCardTableLayoutPanel.Controls.Add(ReturnDate, 3, i);
            ClientCardTableLayoutPanel.Controls.Add(LateDay, 4, i);
            ClientCardTableLayoutPanel.Controls.Add(Price, 5, i);
            ClientCardTableLayoutPanel.Controls.Add(Peny, 6, i);
            ClientCardTableLayoutPanel.Controls.Add(End, 7, i);
            ClientCardTableLayoutPanel.Controls.Add(checkBox, 8, i);
        }

        private void GiveButton_Click(object sender, EventArgs e)
        {
            if(_validator.FilmHands(_client.ListClientFilm))
            {
                MessageBox.Show("У клиента уже 5 фильмов - выдача не возможна!", "Ошибка выдачи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListFForm listF = new ListFForm(_mainMenuForm, _client);
                listF.Show();
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            double End = 0;
            bool flag = true;
            for(int i = 0; i < _client.ListClientFilm.Count; i++)
            {
                if (_client.ListClientFilm[i].CheckFlag && _client.ListClientFilm[i].returnDate.Date.Year == 1)
                {
                    End += _client.ListClientFilm[i].EndPrice();
                    flag = false;
                }
                    
            }
            if (flag)
            {
                MessageBox.Show("Не выбран фильм для возврата!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                FilmRental_Forms.PayForm pay = new PayForm(_client, End, ClientCardTableLayoutPanel, _mainMenuForm);
                pay.Show();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            FilmRental_Forms.ClientCardForm cCard = new FilmRental_Forms.ClientCardForm(_mainMenuForm, _client);
            cCard.Show();
            Close();
        }

        //Вывод карты клиента в Excel
        private void ExcelButton_Click(object sender, EventArgs e)
        {
            exapp = new Microsoft.Office.Interop.Excel.Application();
            exapp.SheetsInNewWorkbook = 1;
            exbook = exapp.Workbooks.Add(Type.Missing);
            exsheet = (Microsoft.Office.Interop.Excel.Worksheet)exbook.Sheets[1];
            //установка стиля
            exsheet.Cells.Font.Size = 11;
            exsheet.Range[exsheet.Cells[1, 1], exsheet.Cells[6, 3]].Font.Bold = true;
            exsheet.Range[exsheet.Cells[8, 1], exsheet.Cells[9, 9]].Font.Bold = true;
            exsheet.Range[exsheet.Cells[1, 1], exsheet.Cells[6, 3]].Font.Bold = true;
            exsheet.Range[exsheet.Cells[7, 1], exsheet.Cells[7, 9]].Font.Italic = true;
            exsheet.Cells.VerticalAlignment = true;
            exsheet.Cells.WrapText = true;
            exsheet.Range[exsheet.Cells[8, 1], exsheet.Cells[8, 9]].RowHeight = exsheet.Cells[9, 1].RowHeight * 2;
            exsheet.Range[exsheet.Cells[1, 4], exsheet.Cells[_client.ListClientFilm.Count + 9, 4]].ColumnWidth = 15;
            exsheet.Range[exsheet.Cells[1, 5], exsheet.Cells[_client.ListClientFilm.Count + 9, 5]].ColumnWidth = 15;
            //объеднение ячеек
            for (int i = 1; i < 7; i++)
            {
                exsheet.Range[exsheet.Cells[i, 1], exsheet.Cells[i, 3]].Merge();
                exsheet.Range[exsheet.Cells[i, 4], exsheet.Cells[i, 9]].Merge();
            }
            exsheet.Range[exsheet.Cells[7, 1], exsheet.Cells[7, 9]].Merge();
            exsheet.Range[exsheet.Cells[8, 1], exsheet.Cells[8, 3]].Merge();
            exsheet.Range[exsheet.Cells[8, 4], exsheet.Cells[8, 5]].Merge();
            exsheet.Range[exsheet.Cells[8, 6], exsheet.Cells[9, 6]].Merge();
            exsheet.Range[exsheet.Cells[8, 7], exsheet.Cells[8, 9]].Merge();
            //заполнение шаблона
            exsheet.Cells[1, 1] = "Клиент:";
            exsheet.Cells[2, 1] = "Пол:";
            exsheet.Cells[3, 1] = "Возраст:";
            exsheet.Cells[4, 1] = "Зарегистрирован:";
            exsheet.Cells[6, 1] = "Задолженник:";
            exsheet.Cells[7, 1] = "Список заказов";
            exsheet.Cells[8, 1] = "Фильм";
            exsheet.Cells[8, 4] = "Даты";
            exsheet.Cells[8, 6] = "Кол-во дней опаздания возврата";
            exsheet.Cells[8, 7] = "Сумма";
            exsheet.Cells[9, 1] = "Инв. №";
            exsheet.Cells[9, 3] = "Название";
            exsheet.Cells[9, 4] = "выдачи";
            exsheet.Cells[9, 5] = "возврата";
            exsheet.Cells[9, 7] = "проката";
            exsheet.Cells[9, 8] = "пени";
            exsheet.Cells[9, 9] = "ИТОГО";
            //заполнение
            exsheet.Cells[1, 4] = ClientLabel.Text;
            exsheet.Cells[2, 4] = SexLabel.Text;
            exsheet.Cells[3, 4] = AgeLabel.Text;
            exsheet.Cells[4, 4] = RegLabel.Text;
            exsheet.Cells[5, 4] = LicenseLabel.Text;
            exsheet.Cells[6, 4] = DebtLabel.Text;
            for (int i = 0; i < _client.ListClientFilm.Count; i++)
            {
                exsheet.Cells[i + 10, 1] = _client.ListClientFilm[i].clientFilm.FilmID; 
                exsheet.Cells[i + 10, 3] = _client.ListClientFilm[i].clientFilm.Producer;
                exsheet.Cells[i + 10, 4] = _client.ListClientFilm[i].leaseDate.ToString("d");
                exsheet.Cells[i + 10, 5] = _client.ListClientFilm[i].returnDate.ToString("d");
                exsheet.Cells[i + 10, 6] = Convert.ToString(_client.ListClientFilm[i].LateDayCount());
                exsheet.Cells[i + 10, 7] = Convert.ToString(_client.ListClientFilm[i].Price);
                exsheet.Cells[i + 10, 8] = Convert.ToString(_client.ListClientFilm[i].Peny);
                exsheet.Cells[i + 10, 9] = Convert.ToString(_client.ListClientFilm[i].EndPrice());
            }
            //границы
            exsheet.Range[exsheet.Cells[1, 1], exsheet.Cells[_client.ListClientFilm.Count + 9, 9]].Borders.Color = XlRgbColor.rgbBlack;
            //запуск
            exsheet.Protect();
            exapp.Visible = true;
        }

        private void LicenseLabel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
