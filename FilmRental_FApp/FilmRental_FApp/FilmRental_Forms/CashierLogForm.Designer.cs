namespace FilmRental_FApp
{
    partial class CashierLogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierLogForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ListClientButton1 = new System.Windows.Forms.Button();
            this.ListFilmButton1 = new System.Windows.Forms.Button();
            this.RegCButton1 = new System.Windows.Forms.Button();
            this.NumCTextBox1 = new System.Windows.Forms.TextBox();
            this.NumFTextBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ListClientButton1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ListFilmButton1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.RegCButton1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.NumCTextBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.NumFTextBox1, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 260);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиентов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(153, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фильмов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 4);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Открыть:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 4);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Регистрация:";
            // 
            // ListClientButton1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ListClientButton1, 2);
            this.ListClientButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListClientButton1.Location = new System.Drawing.Point(3, 78);
            this.ListClientButton1.Name = "ListClientButton1";
            this.ListClientButton1.Size = new System.Drawing.Size(144, 42);
            this.ListClientButton1.TabIndex = 4;
            this.ListClientButton1.Text = "Список клиентов";
            this.ListClientButton1.UseVisualStyleBackColor = true;
            // 
            // ListFilmButton1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ListFilmButton1, 2);
            this.ListFilmButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListFilmButton1.Location = new System.Drawing.Point(153, 78);
            this.ListFilmButton1.Name = "ListFilmButton1";
            this.ListFilmButton1.Size = new System.Drawing.Size(144, 42);
            this.ListFilmButton1.TabIndex = 5;
            this.ListFilmButton1.Text = "Видеотека";
            this.ListFilmButton1.UseVisualStyleBackColor = true;
            // 
            // RegCButton1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.RegCButton1, 2);
            this.RegCButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegCButton1.Location = new System.Drawing.Point(78, 172);
            this.RegCButton1.Name = "RegCButton1";
            this.RegCButton1.Size = new System.Drawing.Size(143, 85);
            this.RegCButton1.TabIndex = 6;
            this.RegCButton1.Text = "Клиента";
            this.RegCButton1.UseVisualStyleBackColor = true;
            // 
            // NumCTextBox1
            // 
            this.NumCTextBox1.Location = new System.Drawing.Point(78, 3);
            this.NumCTextBox1.Name = "NumCTextBox1";
            this.NumCTextBox1.Size = new System.Drawing.Size(69, 20);
            this.NumCTextBox1.TabIndex = 7;
            // 
            // NumFTextBox1
            // 
            this.NumFTextBox1.Location = new System.Drawing.Point(227, 3);
            this.NumFTextBox1.Name = "NumFTextBox1";
            this.NumFTextBox1.Size = new System.Drawing.Size(70, 20);
            this.NumFTextBox1.TabIndex = 8;
            // 
            // CashierLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 260);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashierLogForm";
            this.Text = "Вход через кассира";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ListClientButton1;
        private System.Windows.Forms.Button ListFilmButton1;
        private System.Windows.Forms.Button RegCButton1;
        private System.Windows.Forms.TextBox NumCTextBox1;
        private System.Windows.Forms.TextBox NumFTextBox1;
    }
}