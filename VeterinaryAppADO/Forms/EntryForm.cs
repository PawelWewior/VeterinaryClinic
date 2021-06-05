using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinaryAppADO
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void buttonAddOwner_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            VisitManagerForm vi = new VisitManagerForm();
            vi.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EntryForm_Load(object sender, EventArgs e)
        {

        }

        private void ClientMenu_Click(object sender, EventArgs e)
        {
            var ClientForm = new ClientManagerForm();
            ClientForm.Show();
        }

        private void ClinicManager_Click(object sender, EventArgs e)
        {
            var ClinicForm = new ClinicManagerForm();
            ClinicForm.Show();

        }
    }
}
