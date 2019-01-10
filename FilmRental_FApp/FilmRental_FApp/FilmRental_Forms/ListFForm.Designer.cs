namespace FilmRental_FApp.FilmRental_Forms
{
    partial class ListFForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListFForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleRadioButton = new System.Windows.Forms.RadioButton();
            this.YearRadioButton = new System.Windows.Forms.RadioButton();
            this.INumRadioButton = new System.Windows.Forms.RadioButton();
            this.CategRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.UpDButton = new System.Windows.Forms.Button();
            this.FilmListTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TextErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.FilmListTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 470F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SearchButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UpDButton, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 63);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.TitleRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.YearRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.INumRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.CategRadioButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(464, 27);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск по:";
            // 
            // TitleRadioButton
            // 
            this.TitleRadioButton.AutoSize = true;
            this.TitleRadioButton.Location = new System.Drawing.Point(66, 3);
            this.TitleRadioButton.Name = "TitleRadioButton";
            this.TitleRadioButton.Size = new System.Drawing.Size(75, 17);
            this.TitleRadioButton.TabIndex = 1;
            this.TitleRadioButton.Text = "Название";
            this.TitleRadioButton.UseVisualStyleBackColor = true;
            this.TitleRadioButton.CheckedChanged += new System.EventHandler(this.TitleRadioButton_CheckedChanged);
            // 
            // YearRadioButton
            // 
            this.YearRadioButton.AutoSize = true;
            this.YearRadioButton.Location = new System.Drawing.Point(147, 3);
            this.YearRadioButton.Name = "YearRadioButton";
            this.YearRadioButton.Size = new System.Drawing.Size(89, 17);
            this.YearRadioButton.TabIndex = 2;
            this.YearRadioButton.TabStop = true;
            this.YearRadioButton.Text = "Год выпуска";
            this.YearRadioButton.UseVisualStyleBackColor = true;
            this.YearRadioButton.CheckedChanged += new System.EventHandler(this.YearRadioButton_CheckedChanged);
            // 
            // INumRadioButton
            // 
            this.INumRadioButton.AutoSize = true;
            this.INumRadioButton.Location = new System.Drawing.Point(242, 3);
            this.INumRadioButton.Name = "INumRadioButton";
            this.INumRadioButton.Size = new System.Drawing.Size(62, 17);
            this.INumRadioButton.TabIndex = 3;
            this.INumRadioButton.TabStop = true;
            this.INumRadioButton.Text = "Инв. №";
            this.INumRadioButton.UseVisualStyleBackColor = true;
            this.INumRadioButton.CheckedChanged += new System.EventHandler(this.INumRadioButton_CheckedChanged);
            // 
            // CategRadioButton
            // 
            this.CategRadioButton.AutoSize = true;
            this.CategRadioButton.Location = new System.Drawing.Point(310, 3);
            this.CategRadioButton.Name = "CategRadioButton";
            this.CategRadioButton.Size = new System.Drawing.Size(78, 17);
            this.CategRadioButton.TabIndex = 4;
            this.CategRadioButton.TabStop = true;
            this.CategRadioButton.Text = "Категория";
            this.CategRadioButton.UseVisualStyleBackColor = true;
            this.CategRadioButton.CheckedChanged += new System.EventHandler(this.CategRadioButton_CheckedChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(473, 3);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(66, 23);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = " Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Location = new System.Drawing.Point(3, 5);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(464, 20);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // UpDButton
            // 
            this.UpDButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpDButton.Location = new System.Drawing.Point(473, 35);
            this.UpDButton.Name = "UpDButton";
            this.UpDButton.Size = new System.Drawing.Size(66, 23);
            this.UpDButton.TabIndex = 3;
            this.UpDButton.Text = "Обновить";
            this.UpDButton.UseVisualStyleBackColor = true;
            this.UpDButton.Click += new System.EventHandler(this.UpDButton_Click);
            // 
            // FilmListTableLayoutPanel
            // 
            this.FilmListTableLayoutPanel.BackColor = System.Drawing.SystemColors.Window;
            this.FilmListTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.FilmListTableLayoutPanel.ColumnCount = 11;
            this.FilmListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.FilmListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.FilmListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.FilmListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.FilmListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.FilmListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.FilmListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.FilmListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.FilmListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.FilmListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.FilmListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.FilmListTableLayoutPanel.Controls.Add(this.label2, 0, 0);
            this.FilmListTableLayoutPanel.Controls.Add(this.label3, 1, 0);
            this.FilmListTableLayoutPanel.Controls.Add(this.label4, 2, 0);
            this.FilmListTableLayoutPanel.Controls.Add(this.label5, 3, 0);
            this.FilmListTableLayoutPanel.Controls.Add(this.label7, 4, 0);
            this.FilmListTableLayoutPanel.Controls.Add(this.label8, 5, 0);
            this.FilmListTableLayoutPanel.Controls.Add(this.label9, 6, 0);
            this.FilmListTableLayoutPanel.Controls.Add(this.label10, 7, 0);
            this.FilmListTableLayoutPanel.Controls.Add(this.label14, 8, 0);
            this.FilmListTableLayoutPanel.Controls.Add(this.label15, 9, 0);
            this.FilmListTableLayoutPanel.Controls.Add(this.label16, 10, 0);
            this.FilmListTableLayoutPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.FilmListTableLayoutPanel.Location = new System.Drawing.Point(12, 81);
            this.FilmListTableLayoutPanel.Name = "FilmListTableLayoutPanel";
            this.FilmListTableLayoutPanel.RowCount = 1;
            this.FilmListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.FilmListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.FilmListTableLayoutPanel.Size = new System.Drawing.Size(742, 85);
            this.FilmListTableLayoutPanel.TabIndex = 2;
            this.FilmListTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FilmListTableLayoutPanel_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ины. №";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Название";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 39);
            this.label4.TabIndex = 2;
            this.label4.Text = "Режиссёр";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Год";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Страна";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "18+";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "DVD";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(379, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Кассеты";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(440, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Цена";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(481, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Пени";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(615, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Действ.";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 0;
            // 
            // TextErrorProvider
            // 
            this.TextErrorProvider.ContainerControl = this;
            // 
            // ListFForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1045, 325);
            this.Controls.Add(this.FilmListTableLayoutPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListFForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Видеотека";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.FilmListTableLayoutPanel.ResumeLayout(false);
            this.FilmListTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton TitleRadioButton;
        private System.Windows.Forms.RadioButton YearRadioButton;
        private System.Windows.Forms.RadioButton CategRadioButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button UpDButton;
        private System.Windows.Forms.TableLayoutPanel FilmListTableLayoutPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton INumRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ErrorProvider TextErrorProvider;
    }
}