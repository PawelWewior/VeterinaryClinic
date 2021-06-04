
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
            this.AnimalRace = new System.Windows.Forms.TextBox();
            this.AnimalType = new System.Windows.Forms.TextBox();
            this.AnimalName = new System.Windows.Forms.TextBox();
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
            this.ModifyAnimal = new System.Windows.Forms.Button();
            this.DeleteAnimal = new System.Windows.Forms.Button();
            this.AnimalAge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalAge)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAddAnimal
            // 
            this.ButtonAddAnimal.Location = new System.Drawing.Point(147, 437);
            this.ButtonAddAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonAddAnimal.Name = "ButtonAddAnimal";
            this.ButtonAddAnimal.Size = new System.Drawing.Size(172, 66);
            this.ButtonAddAnimal.TabIndex = 0;
            this.ButtonAddAnimal.Text = "Dodaj zwierzaka";
            this.ButtonAddAnimal.UseVisualStyleBackColor = true;
            this.ButtonAddAnimal.Click += new System.EventHandler(this.ButtonAddAnimal_Click);
            // 
            // ButtonAddOwner
            // 
            this.ButtonAddOwner.Location = new System.Drawing.Point(287, 631);
            this.ButtonAddOwner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonAddOwner.Name = "ButtonAddOwner";
            this.ButtonAddOwner.Size = new System.Drawing.Size(179, 66);
            this.ButtonAddOwner.TabIndex = 1;
            this.ButtonAddOwner.Text = "Dodaj opiekuna";
            this.ButtonAddOwner.UseVisualStyleBackColor = true;
            this.ButtonAddOwner.Click += new System.EventHandler(this.ButtonAddOwner_Click);
            // 
            // AnimalRace
            // 
            this.AnimalRace.Location = new System.Drawing.Point(147, 319);
            this.AnimalRace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AnimalRace.Name = "AnimalRace";
            this.AnimalRace.Size = new System.Drawing.Size(132, 22);
            this.AnimalRace.TabIndex = 3;
            // 
            // AnimalType
            // 
            this.AnimalType.Location = new System.Drawing.Point(147, 262);
            this.AnimalType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AnimalType.Name = "AnimalType";
            this.AnimalType.Size = new System.Drawing.Size(132, 22);
            this.AnimalType.TabIndex = 4;
            // 
            // AnimalName
            // 
            this.AnimalName.Location = new System.Drawing.Point(147, 203);
            this.AnimalName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AnimalName.Name = "AnimalName";
            this.AnimalName.Size = new System.Drawing.Size(132, 22);
            this.AnimalName.TabIndex = 5;
            // 
            // OwnerSurname
            // 
            this.OwnerSurname.Location = new System.Drawing.Point(128, 628);
            this.OwnerSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OwnerSurname.Name = "OwnerSurname";
            this.OwnerSurname.Size = new System.Drawing.Size(132, 22);
            this.OwnerSurname.TabIndex = 7;
            // 
            // OwnerName
            // 
            this.OwnerName.Location = new System.Drawing.Point(128, 587);
            this.OwnerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.Size = new System.Drawing.Size(132, 22);
            this.OwnerName.TabIndex = 8;
            // 
            // ListOfOwners
            // 
            this.ListOfOwners.FormattingEnabled = true;
            this.ListOfOwners.Location = new System.Drawing.Point(147, 145);
            this.ListOfOwners.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListOfOwners.Name = "ListOfOwners";
            this.ListOfOwners.Size = new System.Drawing.Size(160, 24);
            this.ListOfOwners.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Wybierz opiekuna:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Podaj imię:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Podaj typ zwierzaka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Podaj rasę:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 391);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Podaj wiek:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 591);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Podaj imię:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 631);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Podaj nazwisko:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 677);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Podaj nr telefonu:";
            // 
            // dataGridViewAnimal
            // 
            this.dataGridViewAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimal.Location = new System.Drawing.Point(607, 34);
            this.dataGridViewAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAnimal.Name = "dataGridViewAnimal";
            this.dataGridViewAnimal.RowHeadersWidth = 51;
            this.dataGridViewAnimal.Size = new System.Drawing.Size(780, 432);
            this.dataGridViewAnimal.TabIndex = 18;
            // 
            // OwnerNumber
            // 
            this.OwnerNumber.Location = new System.Drawing.Point(120, 668);
            this.OwnerNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OwnerNumber.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.OwnerNumber.Name = "OwnerNumber";
            this.OwnerNumber.Size = new System.Drawing.Size(160, 22);
            this.OwnerNumber.TabIndex = 19;
            this.OwnerNumber.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // ModifyAnimal
            // 
            this.ModifyAnimal.Location = new System.Drawing.Point(607, 486);
            this.ModifyAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModifyAnimal.Name = "ModifyAnimal";
            this.ModifyAnimal.Size = new System.Drawing.Size(193, 60);
            this.ModifyAnimal.TabIndex = 20;
            this.ModifyAnimal.Text = "Edytuj zwierzaka";
            this.ModifyAnimal.UseVisualStyleBackColor = true;
            this.ModifyAnimal.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteAnimal
            // 
            this.DeleteAnimal.Location = new System.Drawing.Point(869, 486);
            this.DeleteAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteAnimal.Name = "DeleteAnimal";
            this.DeleteAnimal.Size = new System.Drawing.Size(193, 60);
            this.DeleteAnimal.TabIndex = 21;
            this.DeleteAnimal.Text = "Usuń zwierzaka";
            this.DeleteAnimal.UseVisualStyleBackColor = true;
            this.DeleteAnimal.Click += new System.EventHandler(this.DeleteAnimal_Click);
            // 
            // AnimalAge
            // 
            this.AnimalAge.Location = new System.Drawing.Point(147, 383);
            this.AnimalAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AnimalAge.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.AnimalAge.Name = "AnimalAge";
            this.AnimalAge.Size = new System.Drawing.Size(160, 22);
            this.AnimalAge.TabIndex = 22;
            this.AnimalAge.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // ClientManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 767);
            this.Controls.Add(this.AnimalAge);
            this.Controls.Add(this.DeleteAnimal);
            this.Controls.Add(this.ModifyAnimal);
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
            this.Controls.Add(this.AnimalName);
            this.Controls.Add(this.AnimalType);
            this.Controls.Add(this.AnimalRace);
            this.Controls.Add(this.ButtonAddOwner);
            this.Controls.Add(this.ButtonAddAnimal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClientManagerForm";
            this.Text = "ClientManagerForm";
            this.Load += new System.EventHandler(this.ClientManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddAnimal;
        private System.Windows.Forms.Button ButtonAddOwner;
        private System.Windows.Forms.TextBox AnimalRace;
        private System.Windows.Forms.TextBox AnimalType;
        private System.Windows.Forms.TextBox AnimalName;
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
        private System.Windows.Forms.Button ModifyAnimal;
        private System.Windows.Forms.Button DeleteAnimal;
        private System.Windows.Forms.NumericUpDown AnimalAge;
    }
}