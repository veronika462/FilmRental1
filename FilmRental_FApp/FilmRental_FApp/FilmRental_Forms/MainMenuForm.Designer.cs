namespace FilmRental_FApp
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ListClientButton = new System.Windows.Forms.Button();
            this.ListFilmButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.RegCButton = new System.Windows.Forms.Button();
            this.RegFButton = new System.Windows.Forms.Button();
            this.RegIDButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumCTextBox = new System.Windows.Forms.TextBox();
            this.NumFTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.NumCTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.NumFTextBox, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(337, 155);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Открыть:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 4);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Регистрация:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 4);
            this.flowLayoutPanel1.Controls.Add(this.ListClientButton);
            this.flowLayoutPanel1.Controls.Add(this.ListFilmButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 68);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(314, 29);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ListClientButton
            // 
            this.ListClientButton.Location = new System.Drawing.Point(3, 3);
            this.ListClientButton.Name = "ListClientButton";
            this.ListClientButton.Size = new System.Drawing.Size(151, 23);
            this.ListClientButton.TabIndex = 0;
            this.ListClientButton.Text = "Список клиентов";
            this.ListClientButton.UseVisualStyleBackColor = true;
            this.ListClientButton.Click += new System.EventHandler(this.ListClientButton_Click);
            // 
            // ListFilmButton
            // 
            this.ListFilmButton.Location = new System.Drawing.Point(160, 3);
            this.ListFilmButton.Name = "ListFilmButton";
            this.ListFilmButton.Size = new System.Drawing.Size(151, 23);
            this.ListFilmButton.TabIndex = 1;
            this.ListFilmButton.Text = "Видеотека";
            this.ListFilmButton.UseVisualStyleBackColor = true;
            this.ListFilmButton.Click += new System.EventHandler(this.ListFilmButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel2, 4);
            this.flowLayoutPanel2.Controls.Add(this.RegCButton);
            this.flowLayoutPanel2.Controls.Add(this.RegFButton);
            this.flowLayoutPanel2.Controls.Add(this.RegIDButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(11, 123);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(314, 29);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // RegCButton
            // 
            this.RegCButton.Location = new System.Drawing.Point(3, 3);
            this.RegCButton.Name = "RegCButton";
            this.RegCButton.Size = new System.Drawing.Size(98, 23);
            this.RegCButton.TabIndex = 0;
            this.RegCButton.Text = "Клиента";
            this.RegCButton.UseVisualStyleBackColor = true;
            this.RegCButton.Click += new System.EventHandler(this.RegCButton_Click);
            // 
            // RegFButton
            // 
            this.RegFButton.Location = new System.Drawing.Point(107, 3);
            this.RegFButton.Name = "RegFButton";
            this.RegFButton.Size = new System.Drawing.Size(98, 23);
            this.RegFButton.TabIndex = 1;
            this.RegFButton.Text = "Фильма";
            this.RegFButton.UseVisualStyleBackColor = true;
            this.RegFButton.Click += new System.EventHandler(this.RegFButton_Click);
            // 
            // RegIDButton
            // 
            this.RegIDButton.Location = new System.Drawing.Point(211, 3);
            this.RegIDButton.Name = "RegIDButton";
            this.RegIDButton.Size = new System.Drawing.Size(98, 23);
            this.RegIDButton.TabIndex = 2;
            this.RegIDButton.Text = "Категории";
            this.RegIDButton.UseVisualStyleBackColor = true;
            this.RegIDButton.Click += new System.EventHandler(this.RegIDButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Клиентов:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Фильмов:";
            // 
            // NumCTextBox
            // 
            this.NumCTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumCTextBox.Enabled = false;
            this.NumCTextBox.Location = new System.Drawing.Point(87, 12);
            this.NumCTextBox.Name = "NumCTextBox";
            this.NumCTextBox.Size = new System.Drawing.Size(78, 20);
            this.NumCTextBox.TabIndex = 6;
            this.NumCTextBox.Text = "0";
            // 
            // NumFTextBox
            // 
            this.NumFTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumFTextBox.Enabled = false;
            this.NumFTextBox.Location = new System.Drawing.Point(255, 12);
            this.NumFTextBox.Name = "NumFTextBox";
            this.NumFTextBox.Size = new System.Drawing.Size(79, 20);
            this.NumFTextBox.TabIndex = 7;
            this.NumFTextBox.Text = "0";
            this.NumFTextBox.TextChanged += new System.EventHandler(this.NumFTextBox_TextChanged);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 155);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "Пункт видеопроката";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ListClientButton;
        private System.Windows.Forms.Button ListFilmButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button RegCButton;
        private System.Windows.Forms.Button RegFButton;
        private System.Windows.Forms.Button RegIDButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumCTextBox;
        private System.Windows.Forms.TextBox NumFTextBox;
    }
}

