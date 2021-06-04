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
        public DateTime dataUr { get; set; }
        public string Stanowisko { get; set; }
        public int Telefon { get; set; }

        public void addPersonel(string name, string surname, DateTime birthdate, string proffesion, string nr)
        {
            con.Open();
            SqlCommand addPersonel = new SqlCommand("INSERT INTO dbo.Personel(Imie,Nazwisko,DataUrodzenia,Stanowisko,Telefon)VALUES('" + name + "' , '" + surname + "' , '" + birthdate + "' , '" + proffesion + "' , '" + nr + "')", con);
            SqlDataAdapter da = new SqlDataAdapter(addPersonel);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }
    }
}
