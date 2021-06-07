using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAppADO
{
   public class Choroba
    {
        SqlConnection con = new SqlConnection("Server= localhost; Database= Vet;Integrated Security=SSPI;MultipleActiveResultSets=true;");

        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string WymogHosp { get; set; }




       public void addSickness(string name, string desc,string isChecked,string animal)
        {
                con.Open(); 
                     var animalCut = animal.Split(',');
                     string animalId = animalCut[0];
                    string animalName = animalCut[1];

            SqlCommand addSick = new SqlCommand("INSERT INTO dbo.Choroba(NazwaCh,OpisCh,WymogHospitalizacji,IDZwierze)VALUES('"+name+"','"+desc+"','"+isChecked+"',(SELECT IDZwierze FROM dbo.Zwierze WHERE IDZwierze = '"+animalId+"'))",con);
            SqlDataAdapter da = new SqlDataAdapter(addSick);
            DataSet ds = new DataSet();
            da.Fill(ds);



        }

        public void deleteSickness(int id)
        {
            con.Open();
            SqlCommand deleteSickness = new SqlCommand("DELETE FROM dbo.Choroba WHERE IDChoroba = '" + id + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(deleteSickness);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        public void modifySickness(int id,string name,string desc,string isChecked,string animal)
        {
            con.Open();
            var animalCut = animal.Split(',');
            string animalId = animalCut[0];
            string animalName = animalCut[1];

            SqlCommand modifySickness = new SqlCommand("UPDATE dbo.Choroba SET NazwaCh = '"+name+"', OpisCh = '"+desc+"', WymogHospitalizacji = '"+isChecked+"',IDZwierze =(SELECT IDZwierze FROM dbo.Zwierze WHERE IDZwierze = '"+animalId+"') WHERE IDChoroba ='"+id+"' ",con);
            SqlDataAdapter da = new SqlDataAdapter(modifySickness);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

    }


    }
