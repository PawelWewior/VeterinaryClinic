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


        public void deleteAnimal()
        {

        }

    }
}
