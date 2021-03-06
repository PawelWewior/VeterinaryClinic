using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAppADO
{
   public class Personel
    {
        SqlConnection con = new SqlConnection("Server= localhost; Database= Vet;Integrated Security=SSPI;MultipleActiveResultSets=true;");

        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Stanowisko { get; set; }
        public int Telefon { get; set; }

        public void addPersonel(string name, string surname, string proffesion, string nr)
        {
            con.Open();
            SqlCommand addPersonel = new SqlCommand("INSERT INTO dbo.Personel(Imie,Nazwisko,Stanowisko,Telefon)VALUES('" + name + "' , '" + surname + "' , '" + proffesion + "' , '" + nr + "')", con);
            SqlDataAdapter da = new SqlDataAdapter(addPersonel);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
        }

        public void deletePersonel(int id)
        {
            SqlCommand deletePersonel = new SqlCommand("DELETE FROM dbo.Personel WHERE IDPersonel = '" + id + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(deletePersonel);
            DataSet ds = new DataSet();
            da.Fill(ds);

        }

        public void deleteFromVisitPersonel(int id)
        {
            con.Open();
            SqlCommand deleteFrViPersonel = new SqlCommand("DELETE FROM dbo.Wizyta WHERE IDPersonel = '" + id + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(deleteFrViPersonel);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        public void setPersonelNull(int id)
        {
            SqlCommand updAni = new SqlCommand("UPDATE dbo.Zwierze SET IDPersonel = NULL WHERE IDPersonel = '" + id + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(updAni);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        public void modyfikujpersonel(int id, string name, string surname, string proffesion, string nr)
        {          
            con.Open();
            SqlCommand modyfikujPersonel = new SqlCommand("UPDATE dbo.Personel SET Imie = '" + name + "', Nazwisko = '" + surname + "', Stanowisko = '" + proffesion + "', Telefon = '" + nr + "' WHERE IDPersonel ='" + id + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(modyfikujPersonel);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }
    }
}
