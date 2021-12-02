using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormOrnek3
{
public    class Ogrenci
    {
        public string ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DTarihi { get; set; }
        public string Sinifi { get; set; }
        public bool SecmeliDersAliyorMu { get; set; }
        public List<string> AldigiSecmeliDersler { get; set; } = new List<string>();

        private byte _yas;
        public byte Yas
        {
            get
            {

                _yas = Convert.ToByte(DateTime.Now.Year - DTarihi.Year);
                return _yas;

            }
        }
        //ToString() metodunu ezeceğiz
        public override string ToString()
        {
            return this.ad + "" + this.Soyad.ToUpper() +"_"+this.Yas+" yaşında"+this.AldigiSecmeliDersler.Count+"adet seçmeli dersi var";
        }
    }
}
