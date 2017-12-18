using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public class Rent
    {
        private string _alisOfisi;
        private string _teslimOfisi;
        private DateTime _alisTarihi;
        private DateTime _teslimTarihi;
        private DateTime _alisSaati;
        private DateTime _teslimSaati;

        public string alisOfisi
        {
            get { return _alisOfisi; }
            set { _alisOfisi = value; }
        }

        public string teslimOfisi
        {
            get { return _teslimOfisi; }
            set { _teslimOfisi = value; }
        }

        public DateTime alisTarihi
        {
            get { return _alisTarihi; }
            set { _alisTarihi = value; }
        }

        public DateTime teslimTarihi
        {
            get { return _teslimTarihi; }
            set { _teslimTarihi = value; }
        }

        public DateTime alisSaati
        {
            get { return _alisSaati; }
            set { _alisSaati = value; }
        }

        public DateTime teslimSaati
        {
            get { return _teslimSaati; }
            set { _teslimSaati = value; }
        }

        public Rent(string alisOfisi, string teslimOfisi,
            DateTime alisTarihi, DateTime alisSaati,
            DateTime teslimTarihi, DateTime teslimSaati)
        {
            this.alisOfisi = alisOfisi;
            this.teslimOfisi = teslimOfisi;
            this.alisTarihi = alisTarihi;
            this.alisSaati = alisSaati;
            this.teslimTarihi = teslimTarihi;
            this.teslimSaati = teslimSaati;



            MessageBox.Show(
            string.Format(
            "Alış Ofisi: {0}" +
            "\nTeslim Ofisi: {1}" +
            "\nAlış Tarihi: {2}" +
            "\nAlış Saati: {3}" +
            "\nTeslim Tarihi: {4}" +
            "\nTeslim Saati: {5}",
            alisOfisi, teslimOfisi, alisTarihi.ToShortDateString(), alisSaati.ToShortTimeString(), teslimTarihi.ToShortDateString(), teslimSaati.ToShortTimeString()));
        }

        public void returnRentToForm2(Form1 f1, Form2 f2)
        {
            f2.rentACar = f1.rentACar;
        }

    }



}


