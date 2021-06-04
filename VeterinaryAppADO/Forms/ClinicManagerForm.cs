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
        DataTable PersonelTable = new DataTable();
        public ClinicManagerForm()
        {
            InitializeComponent();
        }

        private void ClinicManagerForm_Load(object sender, EventArgs e)
        {
            PersonelTable.Columns.Add("IDPersonel", typeof(int));
            PersonelTable.Columns.Add("Imie", typeof(string));
            PersonelTable.Columns.Add("Nazwisko", typeof(string));
            PersonelTable.Columns.Add("Stanowisko", typeof(string));
            PersonelTable.Columns.Add("Telefon", typeof(int));
          //  GetPersonel();
            SetPersonelInDGV();


        

        }

        private void buttonDodajPersonel_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ImiepersonelTextbox.Text) || String.IsNullOrWhiteSpace(Stanowiskocombobox.Text) || String.IsNullOrWhiteSpace(NazwiskoPersonelTextbox.Text))
            {
                MessageBox.Show("Niepoprawne dane, proszę spróbować ponownie");
            }
            else
            {
                personel.Imie = ImiepersonelTextbox.Text;
                personel.Nazwisko = NazwiskoPersonelTextbox.Text;
                personel.dataUr = monthCalendar1.SelectionRange.Start;
                personel.Stanowisko = Stanowiskocombobox.SelectedItem.ToString();
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
            
            TelefonPersonelNumericUpDown.Value = 0;
            SetPersonelInDGV();
        }

        void GetPersonel()
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

        void SetPersonelInDGV()
        {
            PersonelDGV.DataSource = PersonelTable;
            SqlConnection con = new SqlConnection("Server= localhost; Database= Vet;Integrated Security=SSPI");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT dbo.Personel.IDPersonel, dbo.Personel.Imie, dbo.Personel.Nazwisko, dbo.Personel.Stanowisko, dbo.Personel.Telefon FROM dbo.Personel", con);


            SqlDataAdapter fillPersonel = new SqlDataAdapter(cmd);

            fillPersonel.Fill(PersonelTable);

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(NazwaSprzetTextbox.Text))
            {
                MessageBox.Show("Niepoprawne dane, proszę spróbować ponownie");
            }
            else
            {
                sprzet.Nazwa = NazwaSprzetTextbox.Text;
                sprzet.CzyDostepny = "Tak";
                sprzet.addSprzet(sprzet.Nazwa, sprzet.CzyDostepny);
                MessageBox.Show("Pomyślnie dodano sprzęt do bazy");
                Refresh();

            }

        }

        private void Przypiszsprzetbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
