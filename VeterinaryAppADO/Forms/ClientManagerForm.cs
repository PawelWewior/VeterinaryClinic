using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VeterinaryAppADO
{
    public partial class ClientManagerForm : Form
    {
        SqlConnection con = new SqlConnection("Server= localhost; Database= Vet;Integrated Security=SSPI;MultipleActiveResultSets=true;");
        DataTable animalTable = new DataTable();


        public ClientManagerForm()
        {

            InitializeComponent();
        }

        private void ClientManagerForm_Load(object sender, EventArgs e)
        {
            
            animalTable.Columns.Add("Imie", typeof(string));
            animalTable.Columns.Add("TypZwierzecia", typeof(string));
            animalTable.Columns.Add("Gatunek", typeof(string));
            animalTable.Columns.Add("Wiek", typeof(int));
            animalTable.Columns.Add("Nazwisko", typeof(string));
            //animalTable.Columns.Add("Lekarz", typeof(string));
           // animalTable.Columns.Add("Pomieszczenie Zwierzaka", typeof(string));
            GetOwners();
            GetAnimals();         
        }

        private void ButtonAddOwner_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(OwnerName.Text) || String.IsNullOrWhiteSpace(OwnerSurname.Text))
            {
                MessageBox.Show("Niepoprawne dane, proszę spróbować ponownie");
            }
            else
            {
                Opiekun opiekun = new Opiekun();

                opiekun.Imie = OwnerName.Text;
                opiekun.Nazwisko = OwnerSurname.Text;
                opiekun.Telefon = OwnerNumber.Value.ToString();

                opiekun.addOwner(opiekun.Imie, opiekun.Nazwisko, opiekun.Telefon);
                MessageBox.Show("Pomyślnie dodano opiekuna do bazy");
                ListOfOwners.Items.Add(opiekun.Imie);
                OwnerRefresh();

            }


        }


        void OwnerRefresh()
        {
            OwnerName.Clear();
            OwnerSurname.Clear();
            OwnerNumber.Value =0;
            ListOfOwners.Items.Clear();
            GetOwners();
        }

        void AnimalRefresh()
        {
            AnimalName.Clear();
            AnimalAge.Value = 0;
            AnimalType.Clear();
            AnimalRace.Clear();
            animalTable.Clear();
            GetAnimals();
        }

        private void ButtonAddAnimal_Click(object sender, EventArgs e)
        {
            if (ListOfOwners.SelectedItem == null || String.IsNullOrWhiteSpace(AnimalName.Text) || String.IsNullOrWhiteSpace(AnimalRace.Text) || String.IsNullOrWhiteSpace(AnimalAge.Text) || String.IsNullOrWhiteSpace(AnimalType.Text))
            {
                MessageBox.Show("Niepoprawne dane, proszę spróbować ponownie");

            }
            else
            {
                Zwierze zwierze = new Zwierze();
                zwierze.ImieZwierze = AnimalName.Text;
                zwierze.TypZwierze = AnimalType.Text;
                zwierze.Gatunek = AnimalRace.Text;
                zwierze.WiekZwierze = (int)AnimalAge.Value;

                string owner = ListOfOwners.SelectedItem.ToString();

                zwierze.addAnimal(zwierze.ImieZwierze, zwierze.TypZwierze, zwierze.Gatunek, zwierze.WiekZwierze, owner);
                MessageBox.Show("Pomyślnie dodano zwierzaka do bazy");
                AnimalRefresh();


            }



        }


        void GetOwners()
        {
            SqlConnection con = new SqlConnection("Server= localhost; Database= Vet;Integrated Security=SSPI");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Opiekun", con);

            SqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                Opiekun opiekun = new Opiekun();

                opiekun.Id = (int)da["IDOpiekun"];
                opiekun.Imie = da["Imie"].ToString();
                opiekun.Nazwisko = da["Nazwisko"].ToString();
                opiekun.Telefon = da["Telefon"].ToString();
                ListOfOwners.Items.Add(opiekun.Imie + " " + opiekun.Nazwisko);

            }
            con.Close();
            
        }

        void GetAnimals()
        {
           


            dataGridViewAnimal.DataSource = animalTable;
            SqlConnection con = new SqlConnection("Server= localhost; Database= Vet;Integrated Security=SSPI");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT dbo.Zwierze.Imie,dbo.Zwierze.TypZwierzecia,dbo.Zwierze.Gatunek,dbo.Zwierze.Wiek,dbo.Opiekun.Nazwisko FROM dbo.Zwierze INNER JOIN dbo.Opiekun on dbo.Zwierze.IDOpiekun = dbo.Opiekun.IDOpiekun ", con);


            SqlDataAdapter fillAnimals = new SqlDataAdapter(cmd);

            fillAnimals.Fill(animalTable);

            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteAnimal_Click(object sender, EventArgs e)
        {

        }
    }
}
