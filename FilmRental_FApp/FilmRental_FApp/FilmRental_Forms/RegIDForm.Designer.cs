namespace FilmRental_FApp.FilmRental_Forms
{
    partial class RegIDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegIDForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RegIDButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTypeTextBox = new System.Windows.Forms.TextBox();
            this.CNumTextBox = new System.Windows.Forms.TextBox();
            this.TextErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.RegIDButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTypeTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CNumTextBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(253, 138);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // RegIDButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.RegIDButton, 2);
            this.RegIDButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegIDButton.Location = new System.Drawing.Point(3, 101);
            this.RegIDButton.Name = "RegIDButton";
            this.RegIDButton.Size = new System.Drawing.Size(247, 34);
            this.RegIDButton.TabIndex = 0;
            this.RegIDButton.Text = "Зарегистрировать категорию";
            this.RegIDButton.UseVisualStyleBackColor = true;
            this.RegIDButton.Click += new System.EventHandler(this.RegIDButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Категория:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Буквенный код:";
            // 
            // BTypeTextBox
            // 
            this.BTypeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BTypeTextBox.Location = new System.Drawing.Point(129, 14);
            this.BTypeTextBox.Name = "BTypeTextBox";
            this.BTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.BTypeTextBox.TabIndex = 3;
            this.BTypeTextBox.TextChanged += new System.EventHandler(this.BTypeTextBox_TextChanged);
            this.BTypeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BTypeTextBox_KeyPress);
            // 
            // CNumTextBox
            // 
            this.CNumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CNumTextBox.Location = new System.Drawing.Point(129, 63);
            this.CNumTextBox.Name = "CNumTextBox";
            this.CNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.CNumTextBox.TabIndex = 4;
            this.CNumTextBox.TextChanged += new System.EventHandler(this.CNumTextBox_TextChanged);
            this.CNumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CNumTextBox_KeyPress);
            // 
            // TextErrorProvider
            // 
            this.TextErrorProvider.ContainerControl = this;
            // 
            // RegIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 138);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegIDForm";
            this.Text = "Категория";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button RegIDButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BTypeTextBox;
        private System.Windows.Forms.TextBox CNumTextBox;
        private System.Windows.Forms.ErrorProvider TextErrorProvider;
    }
}