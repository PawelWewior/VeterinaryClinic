
namespace VeterinaryAppADO
{
    partial class VisitManagerForm
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
            this.dataGridViewSickness = new System.Windows.Forms.DataGridView();
            this.dataGridViewVisit = new System.Windows.Forms.DataGridView();
            this.VisitDate = new System.Windows.Forms.MonthCalendar();
            this.VisitCost = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PickDoc = new System.Windows.Forms.ComboBox();
            this.PickAnimal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDeleteVisit = new System.Windows.Forms.Button();
            this.buttonAddVisit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PickAnimal2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SickName = new System.Windows.Forms.TextBox();
            this.SickDesc = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Hosp = new System.Windows.Forms.CheckBox();
            this.buttonAddSick = new System.Windows.Forms.Button();
            this.buttonModifySick = new System.Windows.Forms.Button();
            this.buttonDeleteSick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitCost)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSickness
            // 
            this.dataGridViewSickness.AllowUserToAddRows = false;
            this.dataGridViewSickness.AllowUserToDeleteRows = false;
            this.dataGridViewSickness.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSickness.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSickness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSickness.Location = new System.Drawing.Point(705, 432);
            this.dataGridViewSickness.Name = "dataGridViewSickness";
            this.dataGridViewSickness.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewSickness.Size = new System.Drawing.Size(458, 220);
            this.dataGridViewSickness.TabIndex = 0;
            this.dataGridViewSickness.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSickness_CellClick);
            // 
            // dataGridViewVisit
            // 
            this.dataGridViewVisit.AllowUserToAddRows = false;
            this.dataGridViewVisit.AllowUserToDeleteRows = false;
            this.dataGridViewVisit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewVisit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisit.Location = new System.Drawing.Point(29, 432);
            this.dataGridViewVisit.Name = "dataGridViewVisit";
            this.dataGridViewVisit.Size = new System.Drawing.Size(432, 220);
            this.dataGridViewVisit.TabIndex = 1;
            // 
            // VisitDate
            // 
            this.VisitDate.Location = new System.Drawing.Point(192, 124);
            this.VisitDate.MaxSelectionCount = 1;
            this.VisitDate.Name = "VisitDate";
            this.VisitDate.TabIndex = 2;
            this.VisitDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.VisitDate_DateChanged);
            // 
            // VisitCost
            // 
            this.VisitCost.Location = new System.Drawing.Point(192, 313);
            this.VisitCost.Name = "VisitCost";
            this.VisitCost.Size = new System.Drawing.Size(269, 20);
            this.VisitCost.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wybierz datę wizyty :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(26, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wprowadź koszt wizyty :";
            // 
            // PickDoc
            // 
            this.PickDoc.FormattingEnabled = true;
            this.PickDoc.Location = new System.Drawing.Point(340, 66);
            this.PickDoc.Name = "PickDoc";
            this.PickDoc.Size = new System.Drawing.Size(121, 21);
            this.PickDoc.TabIndex = 6;
            // 
            // PickAnimal
            // 
            this.PickAnimal.FormattingEnabled = true;
            this.PickAnimal.Location = new System.Drawing.Point(340, 25);
            this.PickAnimal.Name = "PickAnimal";
            this.PickAnimal.Size = new System.Drawing.Size(121, 21);
            this.PickAnimal.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(26, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wybierz pacjenta :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(26, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wybierz lekarza :";
            // 
            // buttonDeleteVisit
            // 
            this.buttonDeleteVisit.Location = new System.Drawing.Point(303, 357);
            this.buttonDeleteVisit.Name = "buttonDeleteVisit";
            this.buttonDeleteVisit.Size = new System.Drawing.Size(158, 57);
            this.buttonDeleteVisit.TabIndex = 10;
            this.buttonDeleteVisit.Text = "Usuń wizytę";
            this.buttonDeleteVisit.UseVisualStyleBackColor = true;
            this.buttonDeleteVisit.Click += new System.EventHandler(this.buttonDeleteVisit_Click);
            // 
            // buttonAddVisit
            // 
            this.buttonAddVisit.Location = new System.Drawing.Point(29, 357);
            this.buttonAddVisit.Name = "buttonAddVisit";
            this.buttonAddVisit.Size = new System.Drawing.Size(158, 57);
            this.buttonAddVisit.TabIndex = 11;
            this.buttonAddVisit.Text = "Dodaj wizytę ";
            this.buttonAddVisit.UseVisualStyleBackColor = true;
            this.buttonAddVisit.Click += new System.EventHandler(this.buttonAddVisit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(702, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Wybierz pacjenta :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PickAnimal2
            // 
            this.PickAnimal2.FormattingEnabled = true;
            this.PickAnimal2.Location = new System.Drawing.Point(1042, 24);
            this.PickAnimal2.Name = "PickAnimal2";
            this.PickAnimal2.Size = new System.Drawing.Size(121, 21);
            this.PickAnimal2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(702, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Podaj nazwę choroby :";
            // 
            // SickName
            // 
            this.SickName.Location = new System.Drawing.Point(1042, 67);
            this.SickName.Name = "SickName";
            this.SickName.Size = new System.Drawing.Size(121, 20);
            this.SickName.TabIndex = 15;
            // 
            // SickDesc
            // 
            this.SickDesc.Location = new System.Drawing.Point(923, 103);
            this.SickDesc.Name = "SickDesc";
            this.SickDesc.Size = new System.Drawing.Size(240, 73);
            this.SickDesc.TabIndex = 16;
            this.SickDesc.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(702, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Opis :";
            // 
            // Hosp
            // 
            this.Hosp.AutoSize = true;
            this.Hosp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Hosp.Location = new System.Drawing.Point(1042, 210);
            this.Hosp.Name = "Hosp";
            this.Hosp.Size = new System.Drawing.Size(110, 19);
            this.Hosp.TabIndex = 18;
            this.Hosp.Text = "Hospitalizacja?";
            this.Hosp.UseVisualStyleBackColor = true;
            // 
            // buttonAddSick
            // 
            this.buttonAddSick.Location = new System.Drawing.Point(705, 357);
            this.buttonAddSick.Name = "buttonAddSick";
            this.buttonAddSick.Size = new System.Drawing.Size(135, 57);
            this.buttonAddSick.TabIndex = 19;
            this.buttonAddSick.Text = "Dodaj chorobę";
            this.buttonAddSick.UseVisualStyleBackColor = true;
            this.buttonAddSick.Click += new System.EventHandler(this.buttonAddSick_Click);
            // 
            // buttonModifySick
            // 
            this.buttonModifySick.Location = new System.Drawing.Point(865, 357);
            this.buttonModifySick.Name = "buttonModifySick";
            this.buttonModifySick.Size = new System.Drawing.Size(135, 57);
            this.buttonModifySick.TabIndex = 20;
            this.buttonModifySick.Text = "Modyfikuj chorobę";
            this.buttonModifySick.UseVisualStyleBackColor = true;
            this.buttonModifySick.Click += new System.EventHandler(this.buttonModifySick_Click);
            // 
            // buttonDeleteSick
            // 
            this.buttonDeleteSick.Location = new System.Drawing.Point(1028, 357);
            this.buttonDeleteSick.Name = "buttonDeleteSick";
            this.buttonDeleteSick.Size = new System.Drawing.Size(135, 57);
            this.buttonDeleteSick.TabIndex = 21;
            this.buttonDeleteSick.Text = "Usuń chorobę";
            this.buttonDeleteSick.UseVisualStyleBackColor = true;
            this.buttonDeleteSick.Click += new System.EventHandler(this.buttonDeleteSick_Click);
            // 
            // VisitManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 664);
            this.Controls.Add(this.buttonDeleteSick);
            this.Controls.Add(this.buttonModifySick);
            this.Controls.Add(this.buttonAddSick);
            this.Controls.Add(this.Hosp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SickDesc);
            this.Controls.Add(this.SickName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PickAnimal2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAddVisit);
            this.Controls.Add(this.buttonDeleteVisit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PickAnimal);
            this.Controls.Add(this.PickDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VisitCost);
            this.Controls.Add(this.VisitDate);
            this.Controls.Add(this.dataGridViewVisit);
            this.Controls.Add(this.dataGridViewSickness);
            this.Name = "VisitManagerForm";
            this.Text = "VisitManagerForm";
            this.Load += new System.EventHandler(this.VisitManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSickness;
        private System.Windows.Forms.DataGridView dataGridViewVisit;
        private System.Windows.Forms.MonthCalendar VisitDate;
        private System.Windows.Forms.NumericUpDown VisitCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PickDoc;
        private System.Windows.Forms.ComboBox PickAnimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDeleteVisit;
        private System.Windows.Forms.Button buttonAddVisit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PickAnimal2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SickName;
        private System.Windows.Forms.RichTextBox SickDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox Hosp;
        private System.Windows.Forms.Button buttonAddSick;
        private System.Windows.Forms.Button buttonModifySick;
        private System.Windows.Forms.Button buttonDeleteSick;
    }
}