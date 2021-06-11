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
        DataTable SickData = new DataTable();

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
            VisitsData.Columns.Add("IDWizyta", typeof(int));
            VisitsData.Columns.Add("DataWizyty", typeof(DateTime));
            VisitsData.Columns.Add("KosztWizyty", typeof(decimal));
            VisitsData.Columns.Add("Imie", typeof(string));
            VisitsData.Columns.Add("Nazwisko", typeof(string));

            SickData.Columns.Add("IDChoroba", typeof(int));
            SickData.Columns.Add("Imie", typeof(string));
            SickData.Columns.Add("NazwaCh", typeof(string));
            SickData.Columns.Add("OpisCh", typeof(string));
            SickData.Columns.Add("WymogHospitalizacji", typeof(string));








            GetVisitsToDGV();
            GetSickToDGV();
            GetAnimalsToBox();
            GetDocsToBox();


        }

        public int GetnumberofPersonel()
        {
            string stmt = "SELECT COUNT(*) FROM dbo.Personel";
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection("Server= localhost; Database= Vet;Integrated Security=SSPI"))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
            }
            return count;
        }


        public int GetnumberofHospitalizacja()
        {
            string stmt = "SELECT COUNT(IDZwierze) FROM dbo.Choroba WHERE WymogHospitalizacji = 'Tak' ";
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection("Server= localhost; Database= Vet;Integrated Security=SSPI"))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
            }
            return count;
        }

        void GetVisitsToDGV()
        {
            dataGridViewVisit.DataSource = VisitsData;
            con.Open();
            SqlCommand getVisits = new SqlCommand("SELECT dbo.Wizyta.IDWizyta,dbo.Wizyta.DataWizyty,dbo.Wizyta.KosztWizyty,dbo.Zwierze.Imie,dbo.Personel.Nazwisko FROM dbo.Wizyta INNER JOIN dbo.Zwierze on dbo.Wizyta.IDZwierze = dbo.Zwierze.IDZwierze INNER JOIN dbo.Personel on dbo.Wizyta.IDPersonel = dbo.Personel.IDPersonel", con);

            SqlDataAdapter da = new SqlDataAdapter(getVisits);

            da.Fill(VisitsData);
            con.Close();


        }

        void GetSickToDGV()
        {
            dataGridViewSickness.DataSource = SickData;
            con.Open();
            SqlCommand getSickness = new SqlCommand("SELECT dbo.Choroba.IDChoroba,dbo.Zwierze.Imie,dbo.Choroba.NazwaCh,dbo.Choroba.OpisCh,dbo.Choroba.WymogHospitalizacji FROM dbo.Choroba INNER JOIN dbo.Zwierze on dbo.Choroba.IDZwierze = dbo.Zwierze.IDZwierze", con);

            SqlDataAdapter da = new SqlDataAdapter(getSickness);

            da.Fill(SickData);
            con.Close();
        }


        void GetAnimalsToBox()
        {
            con.Open();
            SqlCommand getAnimals = new SqlCommand("SELECT IDZwierze,Imie FROM dbo.Zwierze", con);
            SqlDataReader da = getAnimals.ExecuteReader();

            while (da.Read())
            {
                int id = (int)da["IDZwierze"];
                string name = da["Imie"].ToString();
                PickAnimal.Items.Add(id + "," + name);
                PickAnimal2.Items.Add(id + "," + name);


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

        void VisitRefresh()
        {

            PickAnimal.Items.Clear();
            PickDoc.Items.Clear();
            VisitCost.Value = 0;
            VisitsData.Clear();

            GetVisitsToDGV();
            GetAnimalsToBox();
            GetDocsToBox();

        }

        void SicknessRefresh()
        {
            PickAnimal.Items.Clear();
            PickAnimal2.Items.Clear();
            SickData.Clear();
            SickName.Text = "";
            SickDesc.Text = "";
            Hosp.Checked = false;

            GetSickToDGV();
            GetAnimalsToBox();
        }

        private void buttonAddVisit_Click(object sender, EventArgs e)
        {
            if (PickAnimal.SelectedItem == null || PickDoc.SelectedItem == null || VisitDate.SelectionEnd == null || VisitCost.Value == null)
            {
                MessageBox.Show("Błąd w wprowadzaniu danych");

            }
            else
            {
                Wizyta vis = new Wizyta();
                vis.DataWizyty = VisitDate.SelectionEnd.ToLongDateString();
                vis.KosztWizyty = (decimal)VisitCost.Value;
                string animal = PickAnimal.SelectedItem.ToString();
                string doc = PickDoc.SelectedItem.ToString();

                vis.addVisit(vis.DataWizyty, vis.KosztWizyty, animal, doc);
                MessageBox.Show("Dodano wizytę do bazy");

                VisitRefresh();

            }
        }

        private void buttonDeleteVisit_Click(object sender, EventArgs e)
        {
            if (dataGridViewVisit.SelectedRows.Count > 0)
            {
                Wizyta vis = new Wizyta();
                int IDDelete = (int)dataGridViewVisit.CurrentRow.Cells["IDWizyta"].Value;

                vis.Id = IDDelete;
                vis.deleteVisit(vis.Id);
                MessageBox.Show("Pomyślnie usunięto wizytę z bazy");

                VisitRefresh();
            }
            else
            {
                MessageBox.Show("Nie wybrano rekordu do usunięcia");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddSick_Click(object sender, EventArgs e)
        {
            if (PickAnimal2.SelectedItem == null || String.IsNullOrWhiteSpace(SickName.Text) || String.IsNullOrWhiteSpace(SickDesc.Text))
            {
                MessageBox.Show("Błąd w wprowadzaniu danych");

            }
            else if (GetnumberofHospitalizacja() / GetnumberofPersonel() > 5)
            {
                MessageBox.Show("Nie może przypadać więcej niż 5 zwierząt hospitalizowanych na jednego członka personelu.");
            }

            else
            {
                Choroba ch = new Choroba();
                ch.Nazwa = SickName.Text;
                ch.Opis = SickDesc.Text;
                if (Hosp.Checked == true)
                {
                    ch.WymogHosp = "TAK";
                }
                else
                {
                    ch.WymogHosp = "NIE";
                }
                string animal = PickAnimal2.SelectedItem.ToString();
                ch.addSickness(ch.Nazwa, ch.Opis, ch.WymogHosp, animal);

                MessageBox.Show("Pomyślnie dodano chorobę do bazy");
                SicknessRefresh();

            }
        }

        private void buttonDeleteSick_Click(object sender, EventArgs e)
        {
            if (dataGridViewSickness.SelectedRows.Count > 0)
            {
                Choroba ch = new Choroba();
                int IDDelete = (int)dataGridViewSickness.CurrentRow.Cells["IDChoroba"].Value;

                ch.Id = IDDelete;
                ch.deleteSickness(ch.Id);
                MessageBox.Show("Pomyślnie usunięto chorobę z bazy");
                SicknessRefresh();

            }
            else
            {
                MessageBox.Show("Nie wybrano rekordu do usunięcia");
            }

        }

        private void dataGridViewSickness_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSickness.SelectedRows.Count > 0)
            {

                string nazwa = dataGridViewSickness.SelectedRows[0].Cells[2].Value + string.Empty;
                string opis = dataGridViewSickness.SelectedRows[0].Cells[3].Value + string.Empty;
                string ischecked = dataGridViewSickness.SelectedRows[0].Cells[4].Value + string.Empty;

                SickName.Text = nazwa;
                SickDesc.Text = opis;

                if (ischecked == "TAK")
                {
                    Hosp.Checked = true;
                }
                else
                {
                    Hosp.Checked = false;
                }

            }
        }

        private void buttonModifySick_Click(object sender, EventArgs e)
        {
            if (PickAnimal2.SelectedItem == null || String.IsNullOrWhiteSpace(SickName.Text) || String.IsNullOrWhiteSpace(SickDesc.Text))
            {
                MessageBox.Show("Błąd w wprowadzaniu danych");

            }
            else
            {
                Choroba ch = new Choroba();
                ch.Nazwa = SickName.Text;
                ch.Opis = SickDesc.Text;
                ch.Id = (int)dataGridViewSickness.SelectedRows[0].Cells[0].Value;
                if (Hosp.Checked == true)
                {
                    ch.WymogHosp = "TAK";
                }
                else
                {
                    ch.WymogHosp = "NIE";
                }
                string animal = PickAnimal2.SelectedItem.ToString();

                ch.modifySickness(ch.Id, ch.Nazwa, ch.Opis, ch.WymogHosp, animal);
                MessageBox.Show("Pomyślnie zedytowano chorobę");
                SicknessRefresh();
            }
        }

        private void VisitDate_DateChanged(object sender, DateRangeEventArgs e)
        {

            if (e.End.CompareTo(DateTime.Today) < 0)
            {
                MessageBox.Show("Nie można wybrać przeszłej daty");
                VisitDate.SelectionEnd = DateTime.Today;

            }


        }
    }
}
