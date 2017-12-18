using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public class Cars
    {
        private string _resim;
        private string _marka;
        private string _model;
        private double _motorHacmi;
        private string _kasaTipi;
        private string _sanziman;
        private string _yakıt;
        private double _fiyat;
        private List<Cars> _cars = new List<Cars>();

    

        public string marka
        {
            get
            {
                return _marka;
            }
        }

        public string model
        {
            get
            {
                return _model;
            }
        }

        public double motorHacmi
        {
            get
            {
                return _motorHacmi;
            }
        }

        public string kasaTipi
        {
            get
            {
                return _kasaTipi;
            }
        }

        public string sanziman
        {
            get
            {
                return _sanziman;
            }
        }

        public string yakıt
        {
            get
            {
                return _yakıt;
            }
        }

        public double fiyat
        {
            get
            {
                return _fiyat;
            }
        }

        public string resim
        {
            get
            {
                return _resim;
            }
        }

        public List<Cars> cars
        {
            get
            {
                return _cars;
            }
        }
        
        public void initializeCars()
        {

        Cars renault_Clio = new Cars()
            {
                _marka = "Renault",
                _model = "Clio",
                _kasaTipi = "HB",
                _motorHacmi = 1.5,
                _sanziman = "Manuel",
                _fiyat = 90,
                _yakıt = "Dizel",
                _resim = @"Images/clio.png"
            };


            Cars hyundai_i20 = new Cars()
            {
                _marka = "Hyundai",
                _model = "i20",
                _kasaTipi = "HB",
                _motorHacmi = 1.4,
                _sanziman = "Otomatik",
                _fiyat = 110,
                _yakıt = "Dizel",
                _resim = @"Images/i20.png"

            };



            Cars fiat_Linea = new Cars()
            {
                _marka = "Fiat",
                _model = "Linea",
                _kasaTipi = "Sedan",
                _motorHacmi = 1.4,
                _sanziman = "Manuel",
                _fiyat = 95,
                _yakıt = "Dizel",
                _resim = @"Images/linea.png"

            };

            cars.Add(renault_Clio);
            cars.Add(hyundai_i20);
            cars.Add(fiat_Linea);

        }
    }


}
