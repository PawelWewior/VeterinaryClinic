
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitCost)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSickness
            // 
            this.dataGridViewSickness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSickness.Location = new System.Drawing.Point(705, 432);
            this.dataGridViewSickness.Name = "dataGridViewSickness";
            this.dataGridViewSickness.Size = new System.Drawing.Size(458, 220);
            this.dataGridViewSickness.TabIndex = 0;
            // 
            // dataGridViewVisit
            // 
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
            this.buttonDeleteVisit.Location = new System.Drawing.Point(269, 357);
            this.buttonDeleteVisit.Name = "buttonDeleteVisit";
            this.buttonDeleteVisit.Size = new System.Drawing.Size(158, 57);
            this.buttonDeleteVisit.TabIndex = 10;
            this.buttonDeleteVisit.Text = "Usuń wizytę";
            this.buttonDeleteVisit.UseVisualStyleBackColor = true;
            // 
            // buttonAddVisit
            // 
            this.buttonAddVisit.Location = new System.Drawing.Point(65, 357);
            this.buttonAddVisit.Name = "buttonAddVisit";
            this.buttonAddVisit.Size = new System.Drawing.Size(158, 57);
            this.buttonAddVisit.TabIndex = 11;
            this.buttonAddVisit.Text = "Dodaj wizytę ";
            this.buttonAddVisit.UseVisualStyleBackColor = true;
            this.buttonAddVisit.Click += new System.EventHandler(this.buttonAddVisit_Click);
            // 
            // VisitManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 664);
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
    }
}