namespace FilmRental_FApp.FilmRental_Forms
{
    partial class RegCForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegCForm));
            this.TextErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PNumTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.LimitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTextBox3 = new System.Windows.Forms.TextBox();
            this.NameTextBox2 = new System.Windows.Forms.TextBox();
            this.NameTextBox1 = new System.Windows.Forms.TextBox();
            this.RegCButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MRadioButton = new System.Windows.Forms.RadioButton();
            this.FRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.TextErrorProvider)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextErrorProvider
            // 
            this.TextErrorProvider.ContainerControl = this;
            // 
            // PNumTextBox
            // 
            this.PNumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PNumTextBox.Location = new System.Drawing.Point(136, 95);
            this.PNumTextBox.Name = "PNumTextBox";
            this.PNumTextBox.Size = new System.Drawing.Size(138, 20);
            this.PNumTextBox.TabIndex = 14;
            this.PNumTextBox.Leave += new System.EventHandler(this.PNumTextBox_Leave);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "№ паспорта:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Пол:";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AgeTextBox.Location = new System.Drawing.Point(136, 155);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(138, 20);
            this.AgeTextBox.TabIndex = 11;
            this.AgeTextBox.Leave += new System.EventHandler(this.AgeTextBox_Leave);
            // 
            // LimitDateTimePicker
            // 
            this.LimitDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LimitDateTimePicker.Location = new System.Drawing.Point(136, 191);
            this.LimitDateTimePicker.Name = "LimitDateTimePicker";
            this.LimitDateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.LimitDateTimePicker.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Возраст:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата регистрации:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // NameTextBox3
            // 
            this.NameTextBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameTextBox3.Location = new System.Drawing.Point(136, 65);
            this.NameTextBox3.Name = "NameTextBox3";
            this.NameTextBox3.Size = new System.Drawing.Size(138, 20);
            this.NameTextBox3.TabIndex = 10;
            this.NameTextBox3.Leave += new System.EventHandler(this.NameTextBox3_Leave);
            // 
            // NameTextBox2
            // 
            this.NameTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameTextBox2.Location = new System.Drawing.Point(136, 35);
            this.NameTextBox2.Name = "NameTextBox2";
            this.NameTextBox2.Size = new System.Drawing.Size(138, 20);
            this.NameTextBox2.TabIndex = 9;
            this.NameTextBox2.TextChanged += new System.EventHandler(this.NameTextBox2_TextChanged);
            this.NameTextBox2.Leave += new System.EventHandler(this.NameTextBox2_Leave);
            // 
            // NameTextBox1
            // 
            this.NameTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameTextBox1.Location = new System.Drawing.Point(136, 5);
            this.NameTextBox1.Name = "NameTextBox1";
            this.NameTextBox1.Size = new System.Drawing.Size(138, 20);
            this.NameTextBox1.TabIndex = 8;
            this.NameTextBox1.TextChanged += new System.EventHandler(this.NameTextBox1_TextChanged);
            this.NameTextBox1.Leave += new System.EventHandler(this.NameTextBox1_Leave);
            // 
            // RegCButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.RegCButton, 2);
            this.RegCButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegCButton.Location = new System.Drawing.Point(3, 225);
            this.RegCButton.Name = "RegCButton";
            this.RegCButton.Size = new System.Drawing.Size(290, 34);
            this.RegCButton.TabIndex = 7;
            this.RegCButton.Text = "Зарегистрировать клиента";
            this.RegCButton.UseVisualStyleBackColor = true;
            this.RegCButton.Click += new System.EventHandler(this.RegCButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.MRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.FRadioButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(136, 123);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(157, 24);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // MRadioButton
            // 
            this.MRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MRadioButton.AutoSize = true;
            this.MRadioButton.Location = new System.Drawing.Point(3, 3);
            this.MRadioButton.Name = "MRadioButton";
            this.MRadioButton.Size = new System.Drawing.Size(34, 17);
            this.MRadioButton.TabIndex = 0;
            this.MRadioButton.Text = "М";
            this.MRadioButton.UseVisualStyleBackColor = true;
            // 
            // FRadioButton
            // 
            this.FRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FRadioButton.AutoSize = true;
            this.FRadioButton.Location = new System.Drawing.Point(43, 3);
            this.FRadioButton.Name = "FRadioButton";
            this.FRadioButton.Size = new System.Drawing.Size(36, 17);
            this.FRadioButton.TabIndex = 1;
            this.FRadioButton.Text = "Ж";
            this.FRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.RegCButton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.NameTextBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.NameTextBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.NameTextBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.LimitDateTimePicker, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.AgeTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PNumTextBox, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(296, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // RegCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegCForm";
            this.Text = "Клиент";
            ((System.ComponentModel.ISupportInitialize)(this.TextErrorProvider)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider TextErrorProvider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton MRadioButton;
        private System.Windows.Forms.RadioButton FRadioButton;
        private System.Windows.Forms.Button RegCButton;
        private System.Windows.Forms.TextBox NameTextBox1;
        private System.Windows.Forms.TextBox NameTextBox2;
        private System.Windows.Forms.TextBox NameTextBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker LimitDateTimePicker;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PNumTextBox;
    }
}