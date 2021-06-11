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
using VeterinaryAppADO.Forms;

namespace VeterinaryAppADO
{
    public partial class ClinicManagerForm : Form
    {
        SqlConnection con = new SqlConnection("Server= localhost; Database= Vet;Integrated Security=SSPI;MultipleActiveResultSets=true;");
        Personel personel = new Personel();
        Sprzet sprzet = new Sprzet();
        DataTable PersonelTable = new DataTable();
       string licznikpersonelu;

        ClientManagerForm frm = new ClientManagerForm();
        


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

           // PersonelSprzetTable.Columns.Add("IDPersonel", typeof(int));
           // PersonelSprzetTable.Columns.Add("Imie", typeof(string));
           // PersonelSprzetTable.Columns.Add("Nazwisko", typeof(string));
           
            //  GetPersonel();
            SetPersonelInDGV();



           

        }

        //private void RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        //{
        //    licznikpersonelu = PersonelDGV.Rows.Count;
        //}

        //private void RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        //{
        //    licznikpersonelu = PersonelDGV.Rows.Count;
        //}

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
                //   PersonelDGV.RowsAdded += RowsAdded;
               

                label7.Text = PersonelDGV.Rows.Count.ToString();
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
            PersonelDGV.DataSource = null;
            PersonelTable.Clear();
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

            var przejscie = new AssignmentEquipmentForm();
            przejscie.Show();
        }

        private void Listasprzetowcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (PersonelDGV.SelectedRows.Count > 0)
            {
                Personel personel = new Personel();
                int IDDelete = (int)PersonelDGV.CurrentRow.Cells["IDPersonel"].Value;
                personel.Id = IDDelete;
                personel.deletePersonel(personel.Id);
                MessageBox.Show("Pomyślnie usunięto personel z bazy");
                PersonelTable.Clear();
               

                licznikpersonelu = (PersonelDGV.Rows.Count - 1).ToString();
                label8.Text = licznikpersonelu.ToString();

                SetPersonelInDGV();
                
                //    PersonelDGV.RowsRemoved += RowsRemoved;

            }
            else
            {
                MessageBox.Show("Nie wybrano rekordu do usunięcia");
            }
        }

        private void modyfikujpersonelbutton_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrWhiteSpace(ImiepersonelTextbox.Text) || String.IsNullOrWhiteSpace(Stanowiskocombobox.Text) || String.IsNullOrWhiteSpace(NazwiskoPersonelTextbox.Text))
            {
                MessageBox.Show("Niepoprawne dane, proszę spróbować ponownie");
            }
            else
            {
                Personel personel = new Personel();

                personel.Imie = ImiepersonelTextbox.Text;
                personel.Nazwisko = NazwiskoPersonelTextbox.Text;
                personel.dataUr = monthCalendar1.SelectionRange.Start;
                personel.Stanowisko = Stanowiskocombobox.SelectedItem.ToString();
                personel.Telefon = (int)TelefonPersonelNumericUpDown.Value;

             
                personel.Id = (int)PersonelDGV.CurrentRow.Cells[0].Value;

                personel.modyfikujpersonel(personel.Id, personel.Imie, personel.Nazwisko, personel.dataUr, personel.Stanowisko, personel.Telefon.ToString());


                MessageBox.Show("Pomyślnie zedytowano personel");
                PersonelTable.Clear();
                SetPersonelInDGV();
            }
                
            
        }
    }
}
