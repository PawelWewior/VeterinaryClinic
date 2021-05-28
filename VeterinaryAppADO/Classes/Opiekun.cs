using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace VeterinaryAppADO
{
   public class Opiekun
    {
        SqlConnection con = new SqlConnection("Server= localhost; Database= Vet;Integrated Security=SSPI;MultipleActiveResultSets=true;");


        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Telefon { get; set; }
        

        public void addOwner(string name, string surname, string nr)
        {
            con.Open();
            SqlCommand addOwner = new SqlCommand("INSERT INTO dbo.Opiekun(Imie,Nazwisko,Telefon)VALUES('" + name + "' , '" + surname + "' , '" + nr + "')", con);
            SqlDataAdapter da = new SqlDataAdapter(addOwner);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

    }
}
