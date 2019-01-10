namespace FilmRental_FApp.FilmRental_Forms
{
    partial class DayAmount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayAmount));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GiveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DayAmountTextBox = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.GiveButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DayAmountTextBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 103);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GiveButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.GiveButton, 2);
            this.GiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GiveButton.Location = new System.Drawing.Point(3, 66);
            this.GiveButton.Name = "GiveButton";
            this.GiveButton.Size = new System.Drawing.Size(258, 34);
            this.GiveButton.TabIndex = 0;
            this.GiveButton.Text = "Выдать";
            this.GiveButton.UseVisualStyleBackColor = true;
            this.GiveButton.Click += new System.EventHandler(this.GiveButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество дней (не больше 7):";
            // 
            // DayAmountTextBox
            // 
            this.DayAmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DayAmountTextBox.Location = new System.Drawing.Point(135, 21);
            this.DayAmountTextBox.Name = "DayAmountTextBox";
            this.DayAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.DayAmountTextBox.TabIndex = 3;
            this.DayAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DayAmountTextBox_KeyPress);
            // 
            // TextErrorProvider
            // 
            this.TextErrorProvider.ContainerControl = this;
            // 
            // DayAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 103);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DayAmount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выдать";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button GiveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DayAmountTextBox;
        private System.Windows.Forms.ErrorProvider TextErrorProvider;
    }
}