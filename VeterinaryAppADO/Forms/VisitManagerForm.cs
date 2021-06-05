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
    public partial class VisitManagerForm : Form
    {
        DataTable VisitsData = new DataTable();

        SqlConnection con = new SqlConnection("Server= localhost; Database= Vet;Integrated Security=SSPI;MultipleActiveResultSets=true;");

        public VisitManagerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VisitManagerForm_Load(object sender, EventArgs e)
        {
            GetVisitsToDGV();
            GetAnimalsToBox();
            GetDocsToBox();
        }



        void GetVisitsToDGV()
        {
            dataGridViewVisit.DataSource = VisitsData;
            con.Open();
            SqlCommand getVisits = new SqlCommand("SELECT dbo.Wizyta.IDWizyta,dbo.Wizyta.DataWizyty,dbo.Wizyta.KosztWizyty,(dbo.Zwierze.Imie FROM dbo.Zwierze INNER JOIN dbo.Wizyta on dbo.Wizyta.IDZwierze = dbo.Zwierze.IDZwierze),(dbo.Personel.Nazwisko FROM dbo.Personel INNER JOIN dbo.Wizyta on dbo.Wizyta.IDPersonel = dbo.Personel.IDPersonel)",con);

            SqlDataAdapter da = new SqlDataAdapter(getVisits);

            da.Fill(VisitsData);
            con.Close();
                

        }


        void GetAnimalsToBox()
        {
            con.Open();
            SqlCommand getAnimals = new SqlCommand("SELECT IDZwierze,Imie FROM dbo.Zwierze",con);
            SqlDataReader da = getAnimals.ExecuteReader();

            while (da.Read())
            {
                int id = (int)da["IDZwierze"];
                string name = da["Imie"].ToString();
                PickAnimal.Items.Add(id + "," + name);
            }

            con.Close();

        }

        void GetDocsToBox()
        {
            con.Open();
            SqlCommand getDocs = new SqlCommand("SELECT Imie,Nazwisko FROM dbo.Personel WHERE Stanowisko = 'Lekarz'", con);
            SqlDataReader da = getDocs.ExecuteReader();

            while (da.Read())
            {
                string doc = da["Imie"].ToString() + " " + da["Nazwisko"].ToString();
                PickDoc.Items.Add(doc);

            }

            con.Close();
        }

        private void buttonAddVisit_Click(object sender, EventArgs e)
        {
            if (PickAnimal.SelectedItem == null || PickDoc.SelectedItem == null || VisitDate.SelectionStart == null || VisitCost.Value == null)
            {
                MessageBox.Show("Błąd w wprowadzaniu danych");
                
            }
            else
            {
                Wizyta vis = new Wizyta();
                vis.DataWizyty = VisitDate.SelectionStart;
                vis.KosztWizyty = (decimal)VisitCost.Value;
                string animal = PickAnimal.SelectedItem.ToString();
                string doc = PickDoc.SelectedItem.ToString();

                vis.addVisit(vis.DataWizyty, vis.KosztWizyty, animal, doc);

            }
        }
    }
}
