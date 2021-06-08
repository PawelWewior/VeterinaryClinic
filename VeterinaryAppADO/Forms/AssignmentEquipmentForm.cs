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

namespace VeterinaryAppADO.Forms
{
    public partial class AssignmentEquipmentForm : Form
    {
        SqlConnection con = new SqlConnection("Server= localhost; Database= Vet;Integrated Security=SSPI;MultipleActiveResultSets=true;");
        DataTable PersonelSprzetTable = new DataTable();
        DataTable PersonelTable = new DataTable();
        DataTable SprzetTable = new DataTable();

        public AssignmentEquipmentForm()
        {
            InitializeComponent();
        }

        private void AssignmentEquipmentForm_Load(object sender, EventArgs e)
        {
            SprzetTable.Columns.Add("IDSprzet", typeof(int));
            SprzetTable.Columns.Add("Nazwa", typeof(string));
            SprzetTable.Columns.Add("CzyDostepny", typeof(string));
            GetSprzet();

            PersonelTable.Columns.Add("IDPersonel", typeof(int));
            PersonelTable.Columns.Add("Imie", typeof(string));
            PersonelTable.Columns.Add("Nazwisko", typeof(string));
            PersonelTable.Columns.Add("Stanowisko", typeof(string));
            PersonelTable.Columns.Add("Telefon", typeof(int));
            GetPersonel();
            
            PersonelSprzetTable.Columns.Add("IDSprzet", typeof(int));
            PersonelSprzetTable.Columns.Add("Nazwa", typeof(string));
            PersonelSprzetTable.Columns.Add("IDPersonel", typeof(string));
            PersonelSprzetTable.Columns.Add("Imie", typeof(string));
            PersonelSprzetTable.Columns.Add("Nazwisko", typeof(string));
            GetPersonelSprzet();


        }

        void GetPersonel()
        {
            PersonelDGV.DataSource = null;
            
            PersonelDGV.DataSource = PersonelTable;
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT dbo.Personel.IDPersonel, dbo.Personel.Imie, dbo.Personel.Nazwisko, dbo.Personel.Stanowisko, dbo.Personel.Telefon FROM dbo.Personel", con);


            SqlDataAdapter fillPersonel = new SqlDataAdapter(cmd);

            fillPersonel.Fill(PersonelTable);

            con.Close();
        }

        void GetSprzet()
        {
            SprzetDGV.DataSource = null;
            SprzetDGV.Update();
            SprzetDGV.Refresh();
            SprzetTable.Clear();
            SprzetDGV.DataSource = SprzetTable;
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT dbo.Sprzet.IDSprzet, dbo.Sprzet.Nazwa, dbo.Sprzet.CzyDostepny FROM dbo.Sprzet", con);


            SqlDataAdapter fillSprzet = new SqlDataAdapter(cmd);

            fillSprzet.Fill(SprzetTable);

            con.Close();
        }

        private void PrzypiszpersonelButton_Click(object sender, EventArgs e)
        {
           
            String n = "Nie";

            if (SprzetDGV.CurrentRow.Cells[2].Value.Equals("Tak"))
            {
                con.Open();
                SqlCommand UpdateSprzet = new SqlCommand("UPDATE dbo.Sprzet SET dbo.Sprzet.CzyDostepny = '" + n + "', dbo.Sprzet.IDPersonel = '"
                    + PersonelDGV.CurrentRow.Cells[0].Value + "'  WHERE dbo.Sprzet.IDSprzet =  '" + SprzetDGV.CurrentRow.Cells[0].Value + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(UpdateSprzet);
                DataSet ds = new DataSet();
                da.Fill(ds);              
                con.Close();
                GetSprzet();
                GetPersonelSprzet();            
                

            }
            else
            {
                MessageBox.Show("Wybrany sprzęt jest zajęty.");
            }
        }

        void GetPersonelSprzet()
        {
            PersonelSprzetDGV.DataSource = null;
            PersonelSprzetTable.Clear();
            PersonelSprzetDGV.DataSource = PersonelSprzetTable;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT dbo.Personel.IDPersonel, dbo.Personel.Imie, dbo.Personel.Nazwisko, dbo.Sprzet.IDSprzet, dbo.Sprzet.Nazwa FROM dbo.Sprzet INNER JOIN dbo.Personel ON dbo.Sprzet.IDPersonel = dbo.Personel.IDPersonel", con);
            SqlDataAdapter fillPersonelSprzet = new SqlDataAdapter(cmd);

            fillPersonelSprzet.Fill(PersonelSprzetTable);
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String t = "Tak";
            con.Open();
           SqlCommand UpdatePersonelSprzet = new SqlCommand("UPDATE dbo.Sprzet SET dbo.Sprzet.CzyDostepny = '" + t + "', dbo.Sprzet.IDPersonel = NULL  WHERE dbo.Sprzet.IDSprzet =  '" + PersonelSprzetDGV.CurrentRow.Cells[0].Value + "'", con);

        //   SqlCommand UpdatePersonelSprzet = new SqlCommand("UPDATE dbo.Sprzet SET dbo.Sprzet.CzyDostepny = '" + t + "'" +
        //        "WHERE dbo.Sprzet.IDSprzet =  '" + PersonelSprzetDGV.CurrentRow.Cells[0].Value + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(UpdatePersonelSprzet);
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.Close();
            
            GetSprzet();
            GetPersonelSprzet();
        }
    }
}
