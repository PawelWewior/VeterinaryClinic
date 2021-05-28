
namespace VeterinaryAppADO
{
    partial class ClientManagerForm
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
            this.ButtonAddAnimal = new System.Windows.Forms.Button();
            this.ButtonAddOwner = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.OwnerSurname = new System.Windows.Forms.TextBox();
            this.OwnerName = new System.Windows.Forms.TextBox();
            this.ListOfOwners = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewAnimal = new System.Windows.Forms.DataGridView();
            this.OwnerNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAddAnimal
            // 
            this.ButtonAddAnimal.Location = new System.Drawing.Point(110, 355);
            this.ButtonAddAnimal.Name = "ButtonAddAnimal";
            this.ButtonAddAnimal.Size = new System.Drawing.Size(129, 54);
            this.ButtonAddAnimal.TabIndex = 0;
            this.ButtonAddAnimal.Text = "Dodaj zwierzaka";
            this.ButtonAddAnimal.UseVisualStyleBackColor = true;
            // 
            // ButtonAddOwner
            // 
            this.ButtonAddOwner.Location = new System.Drawing.Point(215, 513);
            this.ButtonAddOwner.Name = "ButtonAddOwner";
            this.ButtonAddOwner.Size = new System.Drawing.Size(134, 54);
            this.ButtonAddOwner.TabIndex = 1;
            this.ButtonAddOwner.Text = "Dodaj opiekuna";
            this.ButtonAddOwner.UseVisualStyleBackColor = true;
            this.ButtonAddOwner.Click += new System.EventHandler(this.ButtonAddOwner_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 311);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 259);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 213);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(110, 165);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // OwnerSurname
            // 
            this.OwnerSurname.Location = new System.Drawing.Point(96, 510);
            this.OwnerSurname.Name = "OwnerSurname";
            this.OwnerSurname.Size = new System.Drawing.Size(100, 20);
            this.OwnerSurname.TabIndex = 7;
            // 
            // OwnerName
            // 
            this.OwnerName.Location = new System.Drawing.Point(96, 477);
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.Size = new System.Drawing.Size(100, 20);
            this.OwnerName.TabIndex = 8;
            // 
            // ListOfOwners
            // 
            this.ListOfOwners.FormattingEnabled = true;
            this.ListOfOwners.Location = new System.Drawing.Point(110, 118);
            this.ListOfOwners.Name = "ListOfOwners";
            this.ListOfOwners.Size = new System.Drawing.Size(121, 21);
            this.ListOfOwners.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Wybierz opiekuna:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Podaj imię:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Podaj typ zwierzaka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Podaj rasę:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Podaj wiek:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Podaj imię:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 513);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Podaj nazwisko:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 550);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Podaj nr telefonu:";
            // 
            // dataGridViewAnimal
            // 
            this.dataGridViewAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimal.Location = new System.Drawing.Point(455, 28);
            this.dataGridViewAnimal.Name = "dataGridViewAnimal";
            this.dataGridViewAnimal.Size = new System.Drawing.Size(342, 351);
            this.dataGridViewAnimal.TabIndex = 18;
            // 
            // OwnerNumber
            // 
            this.OwnerNumber.Location = new System.Drawing.Point(90, 543);
            this.OwnerNumber.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.OwnerNumber.Name = "OwnerNumber";
            this.OwnerNumber.Size = new System.Drawing.Size(120, 20);
            this.OwnerNumber.TabIndex = 19;
            this.OwnerNumber.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // ClientManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 590);
            this.Controls.Add(this.OwnerNumber);
            this.Controls.Add(this.dataGridViewAnimal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListOfOwners);
            this.Controls.Add(this.OwnerName);
            this.Controls.Add(this.OwnerSurname);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonAddOwner);
            this.Controls.Add(this.ButtonAddAnimal);
            this.Name = "ClientManagerForm";
            this.Text = "ClientManagerForm";
            this.Load += new System.EventHandler(this.ClientManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddAnimal;
        private System.Windows.Forms.Button ButtonAddOwner;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox OwnerSurname;
        private System.Windows.Forms.TextBox OwnerName;
        private System.Windows.Forms.ComboBox ListOfOwners;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewAnimal;
        private System.Windows.Forms.NumericUpDown OwnerNumber;
    }
}