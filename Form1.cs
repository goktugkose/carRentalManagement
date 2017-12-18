using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class Form1 : Form 
    {
        public Rent rentACar;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {

            rentACar = new Rent(cmbAlıs.Text, cmbSatıs.Text,
                dtAlısTarih.Value, dtAlısSaat.Value,
                dtTeslimTarih.Value, dtTeslimSaat.Value);

            Form2 f2 = new Form2();
            rentACar.returnRentToForm2(this, f2);
            f2.Show();
            this.Hide();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtAlısTarih.MinDate = DateTime.UtcNow;
            dtTeslimTarih.MinDate = DateTime.UtcNow;

            cmbSatıs.Items.AddRange(Enum.GetNames(typeof(ERentOffices)));
            cmbAlıs.Items.AddRange(Enum.GetNames(typeof(ERentOffices)));
        }
    }
}
