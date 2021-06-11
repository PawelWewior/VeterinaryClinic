using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAppADO
{
   public class Wizyta
    {
        public int Id { get; set; }
        public string DataWizyty { get; set; }
        public decimal KosztWizyty { get; set; }
        public int IDZwierze { get; set; }
        public int IDPersonel { get; set; }
        SqlConnection con = new SqlConnection("Server= localhost; Database= Vet;Integrated Security=SSPI;MultipleActiveResultSets=true;");





        public void addVisit(string data, decimal cost, string animal, string doc)
        {
            con.Open();
            var animalCut = animal.Split(',');
            string animalId = animalCut[0];
            string animalName = animalCut[1];


            var users = doc.Split(' ');
            string docImie = users[0];
            string docNazwisko = users[1];

            SqlCommand addVisit = new SqlCommand("INSERT INTO dbo.Wizyta(DataWizyty,KosztWizyty,IDZwierze,IDPersonel)VALUES('"+data.ToString()+"','"+cost+"',(SELECT IDZwierze FROM dbo.Zwierze WHERE IDZwierze = '"+animalId+"'),(SELECT IDPersonel FROM dbo.Personel WHERE Imie = '"+docImie+"' AND Nazwisko = '"+docNazwisko+"'))",con);
            SqlDataAdapter da = new SqlDataAdapter(addVisit);
            DataSet ds = new DataSet();
            da.Fill(ds);

        }

        public void deleteVisit(int id)
        {
            con.Open();
            SqlCommand deleteVisit = new SqlCommand("DELETE FROM dbo.Wizyta WHERE IDWizyta = '" + id + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(deleteVisit);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }


    }
}
