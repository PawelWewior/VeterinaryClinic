
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
            this.TelefonPersonelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.buttonDodajPersonel.Location = new System.Drawing.Point(103, 153);
            this.buttonDodajPersonel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodajPersonel.Name = "buttonDodajPersonel";
            this.buttonDodajPersonel.Size = new System.Drawing.Size(107, 30);
            this.buttonDodajPersonel.TabIndex = 0;
            this.buttonDodajPersonel.Text = "Dodaj personel";
            this.buttonDodajPersonel.UseVisualStyleBackColor = true;
            this.buttonDodajPersonel.Click += new System.EventHandler(this.buttonDodajPersonel_Click);
            // 
            // ImiepersonelTextbox
            // 
            this.ImiepersonelTextbox.Location = new System.Drawing.Point(136, 27);
            this.ImiepersonelTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.ImiepersonelTextbox.Name = "ImiepersonelTextbox";
            this.ImiepersonelTextbox.Size = new System.Drawing.Size(76, 20);
            this.ImiepersonelTextbox.TabIndex = 1;
            // 
            // NazwiskoPersonelTextbox
            // 
            this.NazwiskoPersonelTextbox.Location = new System.Drawing.Point(136, 51);
            this.NazwiskoPersonelTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.NazwiskoPersonelTextbox.Name = "NazwiskoPersonelTextbox";
            this.NazwiskoPersonelTextbox.Size = new System.Drawing.Size(76, 20);
            this.NazwiskoPersonelTextbox.TabIndex = 2;
            // 
            // TelefonPersonelNumericUpDown
            // 
            this.TelefonPersonelNumericUpDown.Location = new System.Drawing.Point(120, 102);
            this.TelefonPersonelNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.TelefonPersonelNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.TelefonPersonelNumericUpDown.Name = "TelefonPersonelNumericUpDown";
            this.TelefonPersonelNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.TelefonPersonelNumericUpDown.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imię:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nazwisko:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stanowisko:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon:";
            // 
            // NazwaSprzetTextbox
            // 
            this.NazwaSprzetTextbox.Location = new System.Drawing.Point(330, 10);
            this.NazwaSprzetTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.NazwaSprzetTextbox.Name = "NazwaSprzetTextbox";
            this.NazwaSprzetTextbox.Size = new System.Drawing.Size(76, 20);
            this.NazwaSprzetTextbox.TabIndex = 11;
            // 
            // dodajsprzetbutton
            // 
            this.dodajsprzetbutton.Location = new System.Drawing.Point(423, 11);
            this.dodajsprzetbutton.Margin = new System.Windows.Forms.Padding(2);
            this.dodajsprzetbutton.Name = "dodajsprzetbutton";
            this.dodajsprzetbutton.Size = new System.Drawing.Size(107, 22);
            this.dodajsprzetbutton.TabIndex = 12;
            this.dodajsprzetbutton.Text = "Dodaj sprzęt";
            this.dodajsprzetbutton.UseVisualStyleBackColor = true;
            this.dodajsprzetbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nazwa:";
            // 
            // Stanowiskocombobox
            // 
            this.Stanowiskocombobox.FormattingEnabled = true;
            this.Stanowiskocombobox.Items.AddRange(new object[] {
            "Lekarz",
            "Asystent"});
            this.Stanowiskocombobox.Location = new System.Drawing.Point(120, 75);
            this.Stanowiskocombobox.Margin = new System.Windows.Forms.Padding(2);
            this.Stanowiskocombobox.Name = "Stanowiskocombobox";
            this.Stanowiskocombobox.Size = new System.Drawing.Size(92, 21);
            this.Stanowiskocombobox.TabIndex = 14;
            // 
            // PersonelDGV
            // 
            this.PersonelDGV.AllowUserToAddRows = false;
            this.PersonelDGV.AllowUserToDeleteRows = false;
            this.PersonelDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PersonelDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PersonelDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonelDGV.Location = new System.Drawing.Point(22, 328);
            this.PersonelDGV.Margin = new System.Windows.Forms.Padding(2);
            this.PersonelDGV.Name = "PersonelDGV";
            this.PersonelDGV.RowHeadersWidth = 51;
            this.PersonelDGV.RowTemplate.Height = 24;
            this.PersonelDGV.Size = new System.Drawing.Size(406, 205);
            this.PersonelDGV.TabIndex = 15;
            this.PersonelDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonelDGV_CellClick);
            // 
            // Przypiszsprzetbutton
            // 
            this.Przypiszsprzetbutton.Location = new System.Drawing.Point(432, 41);
            this.Przypiszsprzetbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Przypiszsprzetbutton.Name = "Przypiszsprzetbutton";
            this.Przypiszsprzetbutton.Size = new System.Drawing.Size(98, 33);
            this.Przypiszsprzetbutton.TabIndex = 16;
            this.Przypiszsprzetbutton.Text = "Przypisz sprzęt";
            this.Przypiszsprzetbutton.UseVisualStyleBackColor = true;
            this.Przypiszsprzetbutton.Click += new System.EventHandler(this.Przypiszsprzetbutton_Click);
            // 
            // usunpersonelbutton
            // 
            this.usunpersonelbutton.Location = new System.Drawing.Point(41, 284);
            this.usunpersonelbutton.Margin = new System.Windows.Forms.Padding(2);
            this.usunpersonelbutton.Name = "usunpersonelbutton";
            this.usunpersonelbutton.Size = new System.Drawing.Size(110, 29);
            this.usunpersonelbutton.TabIndex = 17;
            this.usunpersonelbutton.Text = "Usuń personel";
            this.usunpersonelbutton.UseVisualStyleBackColor = true;
            this.usunpersonelbutton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // modyfikujpersonelbutton
            // 
            this.modyfikujpersonelbutton.Location = new System.Drawing.Point(166, 284);
            this.modyfikujpersonelbutton.Margin = new System.Windows.Forms.Padding(2);
            this.modyfikujpersonelbutton.Name = "modyfikujpersonelbutton";
            this.modyfikujpersonelbutton.Size = new System.Drawing.Size(110, 32);
            this.modyfikujpersonelbutton.TabIndex = 18;
            this.modyfikujpersonelbutton.Text = "Modyfikuj personel";
            this.modyfikujpersonelbutton.UseVisualStyleBackColor = true;
            this.modyfikujpersonelbutton.Click += new System.EventHandler(this.modyfikujpersonelbutton_Click);
            // 
            // ClinicManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 565);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TelefonPersonelNumericUpDown);
            this.Controls.Add(this.NazwiskoPersonelTextbox);
            this.Controls.Add(this.ImiepersonelTextbox);
            this.Controls.Add(this.buttonDodajPersonel);
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
        private System.Windows.Forms.NumericUpDown TelefonPersonelNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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