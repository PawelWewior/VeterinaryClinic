
namespace VeterinaryAppADO
{
    partial class EntryForm
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
            this.ClinicManager = new System.Windows.Forms.Button();
            this.ClientMenu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleScreen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClinicManager
            // 
            this.ClinicManager.Location = new System.Drawing.Point(319, 241);
            this.ClinicManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClinicManager.Name = "ClinicManager";
            this.ClinicManager.Size = new System.Drawing.Size(180, 58);
            this.ClinicManager.TabIndex = 12;
            this.ClinicManager.Text = "Zarządzanie kliniką";
            this.ClinicManager.UseVisualStyleBackColor = true;
            this.ClinicManager.Click += new System.EventHandler(this.ClinicManager_Click);
            // 
            // ClientMenu
            // 
            this.ClientMenu.Location = new System.Drawing.Point(319, 182);
            this.ClientMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientMenu.Name = "ClientMenu";
            this.ClientMenu.Size = new System.Drawing.Size(180, 52);
            this.ClientMenu.TabIndex = 13;
            this.ClientMenu.Text = "Zarządzanie klientami";
            this.ClientMenu.UseVisualStyleBackColor = true;
            this.ClientMenu.Click += new System.EventHandler(this.ClientMenu_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 306);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 58);
            this.button2.TabIndex = 14;
            this.button2.Text = "Zarządzanie wizytami";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(92, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 45);
            this.label1.TabIndex = 15;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TitleScreen
            // 
            this.TitleScreen.AutoSize = true;
            this.TitleScreen.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleScreen.Location = new System.Drawing.Point(91, 100);
            this.TitleScreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleScreen.Name = "TitleScreen";
            this.TitleScreen.Size = new System.Drawing.Size(617, 51);
            this.TitleScreen.TabIndex = 16;
            this.TitleScreen.Text = "Pro-Vet : Centrum Zarządzania";
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 556);
            this.Controls.Add(this.TitleScreen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ClientMenu);
            this.Controls.Add(this.ClinicManager);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EntryForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ClinicManager;
        private System.Windows.Forms.Button ClientMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TitleScreen;
    }
}

