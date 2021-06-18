using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAppADO
{
   public class Sprzet
    {

        SqlConnection con = new SqlConnection("Server= localhost; Database= Vet;Integrated Security=SSPI;MultipleActiveResultSets=true;");

        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string CzyDostepny { get; set; }

        public void addSprzet(string name, string available)
        {
            con.Open();
            SqlCommand addPersonel = new SqlCommand("INSERT INTO dbo.Sprzet(Nazwa,CzyDostepny)VALUES('" + name + "' , '" + available  + "')", con);
            SqlDataAdapter da = new SqlDataAdapter(addPersonel);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
        }



    }
}
