using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAppADO
{
   public class Zwierze : Opiekun
    {
        public int IdZwierze { get; set; }
        public string ImieZwierze { get; set; }
        public string TypZwierze { get; set; }
        public string Gatunek { get; set; }
        public int WiekZwierze { get;set; }


        public int Wiek { get; set; }
        SqlConnection con = new SqlConnection("Server= localhost; Database= Vet;Integrated Security=SSPI;MultipleActiveResultSets=true;");


        public void addAnimal(string name,string type,string gatunek,int age,string owner)

        {
            con.Open();
            var users = owner.Split(' ');
            string ownerImie = users[0];
            string ownerNazwisko = users[1];
            SqlCommand addAnimal = new SqlCommand("INSERT INTO dbo.Zwierze(Imie,TypZwierzecia,Gatunek,Wiek,IDOpiekun)VALUES('" + name + "' , '" + type + "' , '" + gatunek + "', '" + age + "', (SELECT IDOpiekun FROM dbo.Opiekun WHERE Imie = '" + ownerImie + "' AND Nazwisko = '"+ownerNazwisko+"'))", con);
            SqlDataAdapter da = new SqlDataAdapter(addAnimal);
            DataSet ds = new DataSet();
            da.Fill(ds);
           
        }


        public void deleteAnimal(int id)
        {
            con.Open();
            SqlCommand deleteAnimal = new SqlCommand("DELETE FROM dbo.Zwierze WHERE IDZwierze = '"+id+"'",con);
            SqlDataAdapter da = new SqlDataAdapter(deleteAnimal);
            DataSet ds = new DataSet();
            da.Fill(ds);

        }

        public void modifyAnimal(int id, string name,string type, string gatunek,int age, string owner)
        {
            var users = owner.Split(' ');
            string ownerImie = users[0];
            string ownerNazwisko = users[1];
            con.Open();
            SqlCommand modifyAnimal = new SqlCommand("UPDATE dbo.Zwierze SET Imie = '" + name + "', TypZwierzecia = '"+type+"', Gatunek = '"+gatunek+"', Wiek = '"+age+ "',IDOpiekun =(SELECT IDOpiekun FROM dbo.Opiekun WHERE Imie = '" + ownerImie + "' AND Nazwisko = '" + ownerNazwisko + "') WHERE IDZwierze ='"+id+"'",  con);
            SqlDataAdapter da = new SqlDataAdapter(modifyAnimal);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

    }
}
