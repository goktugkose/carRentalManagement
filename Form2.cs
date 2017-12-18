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
    public partial class Form2 : Form
    {
        double asıl_fiyat = 0;
        double degisen_fiyat = 0;
        string[] n = new string[9];
        public Rent rentACar;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            button1.Visible = false;

            label8.Text = "Seçtiğiniz aracın yanında alabileceğiniz ekstra hizmetler";

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            Cars a = new Cars();
            a.initializeCars();


            foreach (Cars car in a.cars)
            {
                ListViewItem lvi = new ListViewItem(car.marka);
                lvi.SubItems.Add(car.model);
                lvi.SubItems.Add(car.motorHacmi.ToString());
                lvi.SubItems.Add(car.sanziman);
                lvi.SubItems.Add(car.yakıt);

                listView1.Items.Add(lvi);
            }

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void setFields(int index)
        {
            Cars a = new Cars();
            a.initializeCars();

            if (index < a.cars.Count)
            {
                label1.Text = "Marka: " + a.cars[index].marka;
                label2.Text = "Model: " + a.cars[index].model;
                label3.Text = "Kasa Tipi: " + a.cars[index].kasaTipi;
                label4.Text = "Motor Hacmi: " + a.cars[index].motorHacmi.ToString();
                label5.Text = "Şanzıman: " + a.cars[index].sanziman;
                label6.Text = "Yakıt: " + a.cars[index].yakıt;
                label7.Text = "Fiyat: " + a.cars[index].fiyat + " ₺";
                pictureBox1.Image = Image.FromFile(a.cars[index].resim);
                asıl_fiyat = a.cars[index].fiyat;

            }

            else
            {
                MessageBox.Show("Error");
            }

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.FocusedItem == null) return;
            int selectedIndex = listView1.FocusedItem.Index;
            setFields(selectedIndex);
        }

        private void btnKirala_Click_1(object sender, EventArgs e)
        {

            if (btnKirala.Text == "İleri")
            {
                getFinalDeal();
                panel3.Visible = true;
                checkOut();
                button1.Visible = false;
                btnKirala.Visible = false;
            }

            else if (btnKirala.Text == "Kirala")
            {
                panel2.Visible = true;
                button1.Visible = true;
                btnKirala.Text = "İleri";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            btnKirala.Text = "Kirala";
            button1.Visible = false;
        }

        public void getFinalDeal()
        {
            degisen_fiyat = asıl_fiyat;
            int i = 0;

            foreach (var item in checkedListBox1.CheckedItems)
            {
                n[i] = item.ToString();
                i++;
            }
            
            Array.Resize(ref n, i);

            for (int y = 0; y < n.Length; y++)
            {
                int lastIndexOf = n[y].LastIndexOf("-") + 1;
                int indexOf = n[y].IndexOf("₺");

                string final = n[y].Substring(lastIndexOf, indexOf - lastIndexOf);
                degisen_fiyat += Convert.ToDouble(final);
            }

            label7.Text = "Fiyat: " + degisen_fiyat + " ₺";

        }

        public void checkOut()
        {

            TimeSpan süre = rentACar.teslimTarihi.Subtract(rentACar.alisTarihi);
            int days = (int)Math.Round(süre.TotalDays);

            if (days == 0) { days = 1; };

            String[] ekstra = n;


            foreach (string item in ekstra)
            {
                listBox1.Items.Add(item);
            }

            label9.Text += "\n" + rentACar.alisOfisi + " -- " + rentACar.alisTarihi.ToShortDateString()
               + " -- " + rentACar.alisSaati.ToShortTimeString();
            label10.Text += "\n" + rentACar.alisOfisi + " -- " + rentACar.teslimTarihi.ToShortDateString()
                + " -- " + rentACar.teslimSaati.ToShortTimeString();


            label11.Text += "\n" + +days + " Gün";

            label13.Text += "\n" + degisen_fiyat * days + "₺";


        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //getFinalDeal();
            //MessageBox.Show("Test");
        }
    }


}


