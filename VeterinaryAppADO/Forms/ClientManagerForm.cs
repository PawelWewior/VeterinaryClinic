using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VeterinaryAppADO
{
    public partial class ClientManagerForm : Form
    {
        SqlConnection con = new SqlConnection("Server= localhost; Database= Vet;Integrated Security=SSPI;MultipleActiveResultSets=true;");
        Opiekun opiekun = new Opiekun();



        public ClientManagerForm()
        {

            InitializeComponent();
        }

        private void ClientManagerForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server= localhost; Database= Vet;Integrated Security=SSPI");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Opiekun", con);

            SqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                opiekun.Id = (int)da["IDOpiekun"];
                opiekun.Imie = da["Imie"].ToString();
                opiekun.Nazwisko = da["Nazwisko"].ToString();
                opiekun.Telefon = da["Telefon"].ToString();
                ListOfOwners.Items.Add(opiekun.Imie);

            }
            con.Close();
           
           

        }

        private void ButtonAddOwner_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(OwnerName.Text) || String.IsNullOrWhiteSpace(OwnerSurname.Text) || OwnerNumber.Value == null)
            {
                MessageBox.Show("Niepoprawne dane, proszę spróbować ponownie");
            }
            else
            {
                opiekun.Imie = OwnerName.Text;
                opiekun.Nazwisko = OwnerSurname.Text;
                opiekun.Telefon = OwnerNumber.Value.ToString();

                opiekun.addOwner(opiekun.Imie, opiekun.Nazwisko, opiekun.Telefon);
                MessageBox.Show("Pomyślnie dodano opiekuna do bazy");
                ListOfOwners.Items.Add(opiekun.Imie);
                Refresh();

            }


        }


        void Refresh()
        {
            OwnerName.Clear();
            OwnerSurname.Clear();
            OwnerNumber.Value =0;
        }
        
    }
}
