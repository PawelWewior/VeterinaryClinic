using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinaryAppADO
{
    public partial class ClinicManagerForm : Form
    {
        SqlConnection con = new SqlConnection("Server= localhost; Database= Vet;Integrated Security=SSPI;MultipleActiveResultSets=true;");
        Personel personel = new Personel();
        Sprzet sprzet = new Sprzet();
        public ClinicManagerForm()
        {
            InitializeComponent();
        }

        private void ClinicManagerForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server= localhost; Database= Vet;Integrated Security=SSPI");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Personel", con);

            SqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                personel.Id = (int)da["IDPersonel"];
                personel.Imie = da["Imie"].ToString();
                personel.Nazwisko = da["Nazwisko"].ToString();
                personel.dataUr = (DateTime)da["DataUrodzenia"];
                personel.Stanowisko = da["Stanowisko"].ToString();
                personel.Telefon = (int)da["Telefon"];
                sprzet.Nazwa = da["Nazwa"].ToString();
                sprzet.CzyDostepny = da["CzyDostepny"].ToString();
                              
            }
            con.Close();

        }

        private void buttonDodajPersonel_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ImiepersonelTextbox.Text) || String.IsNullOrWhiteSpace(StanowiskoTextBox.Text) || String.IsNullOrWhiteSpace(NazwiskoPersonelTextbox.Text))
            {
                MessageBox.Show("Niepoprawne dane, proszę spróbować ponownie");
            }
            else
            {
                personel.Imie = ImiepersonelTextbox.Text;
                personel.Nazwisko = NazwiskoPersonelTextbox.Text;
                personel.dataUr = monthCalendar1.SelectionRange.Start;
                personel.Stanowisko = StanowiskoTextBox.Text;
                personel.Telefon = (int)TelefonPersonelNumericUpDown.Value;
                personel.addPersonel(personel.Imie, personel.Nazwisko, personel.dataUr, personel.Stanowisko, personel.Telefon.ToString());
                
                MessageBox.Show("Pomyślnie dodano personel do bazy");               
                Refresh();

            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.MaxDate = DateTime.Now;
        }

        void Refresh()
        {
            ImiepersonelTextbox.Clear();
            NazwiskoPersonelTextbox.Clear();
            monthCalendar1.MaxDate = DateTime.Now;
            StanowiskoTextBox.Clear();
            TelefonPersonelNumericUpDown.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
