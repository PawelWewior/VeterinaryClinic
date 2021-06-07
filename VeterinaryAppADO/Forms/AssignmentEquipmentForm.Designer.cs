namespace VeterinaryAppADO.Forms
{
    partial class AssignmentEquipmentForm
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
            this.SprzetDGV = new System.Windows.Forms.DataGridView();
            this.PersonelDGV = new System.Windows.Forms.DataGridView();
            this.PrzypiszpersonelButton = new System.Windows.Forms.Button();
            this.PersonelSprzetDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usunprzypisaniebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SprzetDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelSprzetDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SprzetDGV
            // 
            this.SprzetDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SprzetDGV.Location = new System.Drawing.Point(42, 153);
            this.SprzetDGV.Name = "SprzetDGV";
            this.SprzetDGV.RowHeadersWidth = 51;
            this.SprzetDGV.RowTemplate.Height = 24;
            this.SprzetDGV.Size = new System.Drawing.Size(822, 82);
            this.SprzetDGV.TabIndex = 0;
            // 
            // PersonelDGV
            // 
            this.PersonelDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonelDGV.Location = new System.Drawing.Point(42, 37);
            this.PersonelDGV.Name = "PersonelDGV";
            this.PersonelDGV.RowHeadersWidth = 51;
            this.PersonelDGV.RowTemplate.Height = 24;
            this.PersonelDGV.Size = new System.Drawing.Size(822, 75);
            this.PersonelDGV.TabIndex = 2;
            // 
            // PrzypiszpersonelButton
            // 
            this.PrzypiszpersonelButton.Location = new System.Drawing.Point(335, 241);
            this.PrzypiszpersonelButton.Name = "PrzypiszpersonelButton";
            this.PrzypiszpersonelButton.Size = new System.Drawing.Size(232, 30);
            this.PrzypiszpersonelButton.TabIndex = 3;
            this.PrzypiszpersonelButton.Text = "Przypisz personel do sprzętu";
            this.PrzypiszpersonelButton.UseVisualStyleBackColor = true;
            this.PrzypiszpersonelButton.Click += new System.EventHandler(this.PrzypiszpersonelButton_Click);
            // 
            // PersonelSprzetDGV
            // 
            this.PersonelSprzetDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonelSprzetDGV.Location = new System.Drawing.Point(42, 302);
            this.PersonelSprzetDGV.Name = "PersonelSprzetDGV";
            this.PersonelSprzetDGV.RowHeadersWidth = 51;
            this.PersonelSprzetDGV.RowTemplate.Height = 24;
            this.PersonelSprzetDGV.Size = new System.Drawing.Size(822, 100);
            this.PersonelSprzetDGV.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wybierz personel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(37, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wybierz sprzęt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(37, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Personel z przypisanym sprzętem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(37, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(756, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jezeli chcesz usunąć przypisanie sprzętu wybierz przypisanie i kliknij przycisk: " +
    "USUŃ.";
            // 
            // usunprzypisaniebutton
            // 
            this.usunprzypisaniebutton.Location = new System.Drawing.Point(370, 463);
            this.usunprzypisaniebutton.Name = "usunprzypisaniebutton";
            this.usunprzypisaniebutton.Size = new System.Drawing.Size(181, 28);
            this.usunprzypisaniebutton.TabIndex = 9;
            this.usunprzypisaniebutton.Text = "USUŃ";
            this.usunprzypisaniebutton.UseVisualStyleBackColor = true;
            this.usunprzypisaniebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AssignmentEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 602);
            this.Controls.Add(this.usunprzypisaniebutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PersonelSprzetDGV);
            this.Controls.Add(this.PrzypiszpersonelButton);
            this.Controls.Add(this.PersonelDGV);
            this.Controls.Add(this.SprzetDGV);
            this.Name = "AssignmentEquipmentForm";
            this.Text = "AssignmentEquipmentForm";
            this.Load += new System.EventHandler(this.AssignmentEquipmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SprzetDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelSprzetDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SprzetDGV;
        private System.Windows.Forms.DataGridView PersonelDGV;
        private System.Windows.Forms.Button PrzypiszpersonelButton;
        private System.Windows.Forms.DataGridView PersonelSprzetDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button usunprzypisaniebutton;
    }
}