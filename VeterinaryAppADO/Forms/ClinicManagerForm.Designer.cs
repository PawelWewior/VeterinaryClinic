
namespace VeterinaryAppADO
{
    partial class ClinicManagerForm
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
            this.buttonDodajPersonel = new System.Windows.Forms.Button();
            this.ImiepersonelTextbox = new System.Windows.Forms.TextBox();
            this.NazwiskoPersonelTextbox = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.TelefonPersonelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NazwaSprzetTextbox = new System.Windows.Forms.TextBox();
            this.dodajsprzetbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Stanowiskocombobox = new System.Windows.Forms.ComboBox();
            this.PersonelDGV = new System.Windows.Forms.DataGridView();
            this.Przypiszsprzetbutton = new System.Windows.Forms.Button();
            this.usunpersonelbutton = new System.Windows.Forms.Button();
            this.modyfikujpersonelbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonPersonelNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDodajPersonel
            // 
            this.buttonDodajPersonel.Location = new System.Drawing.Point(12, 387);
            this.buttonDodajPersonel.Name = "buttonDodajPersonel";
            this.buttonDodajPersonel.Size = new System.Drawing.Size(143, 27);
            this.buttonDodajPersonel.TabIndex = 0;
            this.buttonDodajPersonel.Text = "Dodaj personel";
            this.buttonDodajPersonel.UseVisualStyleBackColor = true;
            this.buttonDodajPersonel.Click += new System.EventHandler(this.buttonDodajPersonel_Click);
            // 
            // ImiepersonelTextbox
            // 
            this.ImiepersonelTextbox.Location = new System.Drawing.Point(88, 37);
            this.ImiepersonelTextbox.Name = "ImiepersonelTextbox";
            this.ImiepersonelTextbox.Size = new System.Drawing.Size(100, 22);
            this.ImiepersonelTextbox.TabIndex = 1;
            // 
            // NazwiskoPersonelTextbox
            // 
            this.NazwiskoPersonelTextbox.Location = new System.Drawing.Point(88, 65);
            this.NazwiskoPersonelTextbox.Name = "NazwiskoPersonelTextbox";
            this.NazwiskoPersonelTextbox.Size = new System.Drawing.Size(100, 22);
            this.NazwiskoPersonelTextbox.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 116);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // TelefonPersonelNumericUpDown
            // 
            this.TelefonPersonelNumericUpDown.Location = new System.Drawing.Point(101, 359);
            this.TelefonPersonelNumericUpDown.Name = "TelefonPersonelNumericUpDown";
            this.TelefonPersonelNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.TelefonPersonelNumericUpDown.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imię:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nazwisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data urodzenia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stanowisko:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon:";
            // 
            // NazwaSprzetTextbox
            // 
            this.NazwaSprzetTextbox.Location = new System.Drawing.Point(440, 12);
            this.NazwaSprzetTextbox.Name = "NazwaSprzetTextbox";
            this.NazwaSprzetTextbox.Size = new System.Drawing.Size(100, 22);
            this.NazwaSprzetTextbox.TabIndex = 11;
            // 
            // dodajsprzetbutton
            // 
            this.dodajsprzetbutton.Location = new System.Drawing.Point(397, 54);
            this.dodajsprzetbutton.Name = "dodajsprzetbutton";
            this.dodajsprzetbutton.Size = new System.Drawing.Size(143, 27);
            this.dodajsprzetbutton.TabIndex = 12;
            this.dodajsprzetbutton.Text = "Dodaj sprzęt";
            this.dodajsprzetbutton.UseVisualStyleBackColor = true;
            this.dodajsprzetbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nazwa:";
            // 
            // Stanowiskocombobox
            // 
            this.Stanowiskocombobox.FormattingEnabled = true;
            this.Stanowiskocombobox.Items.AddRange(new object[] {
            "Lekarz",
            "Asystent"});
            this.Stanowiskocombobox.Location = new System.Drawing.Point(101, 325);
            this.Stanowiskocombobox.Name = "Stanowiskocombobox";
            this.Stanowiskocombobox.Size = new System.Drawing.Size(121, 24);
            this.Stanowiskocombobox.TabIndex = 14;
            // 
            // PersonelDGV
            // 
            this.PersonelDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonelDGV.Location = new System.Drawing.Point(12, 429);
            this.PersonelDGV.Name = "PersonelDGV";
            this.PersonelDGV.RowHeadersWidth = 51;
            this.PersonelDGV.RowTemplate.Height = 24;
            this.PersonelDGV.Size = new System.Drawing.Size(328, 119);
            this.PersonelDGV.TabIndex = 15;
            // 
            // Przypiszsprzetbutton
            // 
            this.Przypiszsprzetbutton.Location = new System.Drawing.Point(397, 106);
            this.Przypiszsprzetbutton.Name = "Przypiszsprzetbutton";
            this.Przypiszsprzetbutton.Size = new System.Drawing.Size(130, 41);
            this.Przypiszsprzetbutton.TabIndex = 16;
            this.Przypiszsprzetbutton.Text = "Przypisz sprzęt";
            this.Przypiszsprzetbutton.UseVisualStyleBackColor = true;
            this.Przypiszsprzetbutton.Click += new System.EventHandler(this.Przypiszsprzetbutton_Click);
            // 
            // usunpersonelbutton
            // 
            this.usunpersonelbutton.Location = new System.Drawing.Point(381, 416);
            this.usunpersonelbutton.Name = "usunpersonelbutton";
            this.usunpersonelbutton.Size = new System.Drawing.Size(146, 36);
            this.usunpersonelbutton.TabIndex = 17;
            this.usunpersonelbutton.Text = "Usuń personel";
            this.usunpersonelbutton.UseVisualStyleBackColor = true;
            this.usunpersonelbutton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // modyfikujpersonelbutton
            // 
            this.modyfikujpersonelbutton.Location = new System.Drawing.Point(381, 459);
            this.modyfikujpersonelbutton.Name = "modyfikujpersonelbutton";
            this.modyfikujpersonelbutton.Size = new System.Drawing.Size(146, 39);
            this.modyfikujpersonelbutton.TabIndex = 18;
            this.modyfikujpersonelbutton.Text = "Modyfikuj personel";
            this.modyfikujpersonelbutton.UseVisualStyleBackColor = true;
            this.modyfikujpersonelbutton.Click += new System.EventHandler(this.modyfikujpersonelbutton_Click);
            // 
            // ClinicManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 573);
            this.Controls.Add(this.modyfikujpersonelbutton);
            this.Controls.Add(this.usunpersonelbutton);
            this.Controls.Add(this.Przypiszsprzetbutton);
            this.Controls.Add(this.PersonelDGV);
            this.Controls.Add(this.Stanowiskocombobox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dodajsprzetbutton);
            this.Controls.Add(this.NazwaSprzetTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TelefonPersonelNumericUpDown);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.NazwiskoPersonelTextbox);
            this.Controls.Add(this.ImiepersonelTextbox);
            this.Controls.Add(this.buttonDodajPersonel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClinicManagerForm";
            this.Text = "ClinicManagerForm";
            this.Load += new System.EventHandler(this.ClinicManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TelefonPersonelNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodajPersonel;
        private System.Windows.Forms.TextBox ImiepersonelTextbox;
        private System.Windows.Forms.TextBox NazwiskoPersonelTextbox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.NumericUpDown TelefonPersonelNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NazwaSprzetTextbox;
        private System.Windows.Forms.Button dodajsprzetbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Stanowiskocombobox;
        private System.Windows.Forms.DataGridView PersonelDGV;
        private System.Windows.Forms.Button Przypiszsprzetbutton;
        private System.Windows.Forms.Button usunpersonelbutton;
        private System.Windows.Forms.Button modyfikujpersonelbutton;
    }
}