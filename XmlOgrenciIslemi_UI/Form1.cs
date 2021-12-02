using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FormOrnek3
{
    public partial class Form1 : Form
    {
        // Global alan
        List<string> SiniflarLsitesi = new List<string>() { "A SINIFI", "B SINIFI" };
        List<Ogrenci> ASinifiOgrencileri = new List<Ogrenci>();
        List<Ogrenci> BSinifiOgrencileri = new List<Ogrenci>();
        List<string> SecilenSecmeliDersler = new List<string>();


        public Form1()//ctor
        {
            InitializeComponent();
            // AddRange ile ekleme yapabiliriz
            // fakat AddRange içeriye Array ister bu nedenle listeyi toArray ile çevirdik
            comboBox_Sınıf.Items.AddRange(SiniflarLsitesi.ToArray());


            // eğer add ile yapmak istersek döngü kurarak yazdırmak gerekir
            //foreach (var item in SiniflarLsitesi)
            //{
            //    comboBox_Sınıf.Items.Add(item);
            //}
            txt_Ad.TabIndex = 0;
            txt_Soyad.TabIndex = 1;
            DateTimePicker_Dogum.TabIndex = 2;
            comboBox_Sınıf.TabIndex = 3;
            btn_OgrEkle.TabIndex = 4;
            listBoxASinifi.TabIndex = 5;
            groupBox1.Enabled = false;
            checkedListBox1.CheckOnClick = true;





        }

        private void btn_OgrEkle_Click(object sender, EventArgs e)
        {
            // string olan bir metot daha : IsNullOrEmpty içine verilen value nun
            // null yada empty(boş) olup olmadıpını kontrol eder.
            //ÖĞRENCİ EKLEYECEĞİZ

            if (string.IsNullOrEmpty(txt_Ad.Text) && string.IsNullOrEmpty(txt_Soyad.Text))
            {
                MessageBox.Show("lütfen ad ve soyad giriniz");
            }
            else
            {
                Ogrenci ogr1 = new Ogrenci()
                {
                    ad = txt_Ad.Text,
                    Soyad = txt_Soyad.Text,
                    DTarihi = DateTimePicker_Dogum.Value
                };
                // comboboxta seçtiği değer

                //if (comboBoxSinif.SelectedIndex==-1)
                //{
                //    MessageBox.Show("Lütfen sınıf seçiniz.");
                //}
                //else
                //{
                // işlemler
                //}
                if (ASinifindaAyniOgrencidenVarMi(ogr1))
                {
                    MessageBox.Show("bu öğrenci A sınıfına zaten kayıt olmuş");
                }
                else if (BSinifindaAyniOgrencidenVarMi(ogr1))
                {
                    MessageBox.Show("bu öğrenci B sınıfına zaten kayıt olmuş");
                }

                else if (comboBox_Sınıf.SelectedIndex >= 0)
                {
                    //ögrencinin sınıfı combobaxtan gelen seçili değer olacak
                    ogr1.Sinifi = comboBox_Sınıf.SelectedItem.ToString();
                    //Artık öğrenciyi listeye ekleyelim
                    switch (comboBox_Sınıf.SelectedIndex)
                    {
                        case 0:
                            if (ASinifindaAyniOgrencidenVarMi(ogr1) == false)
                            {
                                ASinifiOgrencileri.Add(ogr1);
                            }
                            else
                            {
                                MessageBox.Show("bu öğrenci zaten ekli", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
                        case 1: //B sınıfııdır
                            if (BSinifindaAyniOgrencidenVarMi(ogr1) == false)
                            {
                                BSinifiOgrencileri.Add(ogr1);
                            }
                            break;
                        default:
                            break;
                    }
                    //ogrenci seçmeli ders alıyorsa listesine dersleri eklensin
                    ogr1.SecmeliDersAliyorMu = checkBox1.Checked;
                    if (ogr1.SecmeliDersAliyorMu)
                    {
                        ogr1.AldigiSecmeliDersler.AddRange(SecilenSecmeliDersler);
                    }
                    KontrolleriTemizle();
                    ListeleriDoldur();

                }
                else
                {
                    MessageBox.Show("Lütfen sınıf seçiniz.");
                }


            }

        }
        private bool ASinifindaAyniOgrencidenVarMi(Ogrenci ogrenci)
        {
            bool sonuc = false;
            foreach (var item in ASinifiOgrencileri)
            {
                if (item.ad == ogrenci.ad && item.Soyad == ogrenci.Soyad
                    && item.DTarihi.ToShortDateString() == ogrenci.DTarihi.ToShortDateString())
                {
                    sonuc = true;
                    break;
                }
            }
            return sonuc;
        }
        private bool BSinifindaAyniOgrencidenVarMi(Ogrenci ogrenci)
        {
            bool sonuc = false;
            foreach (var item in BSinifiOgrencileri)
            {
                if (item.ad == ogrenci.ad && item.Soyad == ogrenci.Soyad
                    && item.DTarihi == ogrenci.DTarihi)
                {
                    sonuc = true;
                    break;
                }
            }

            return sonuc;
        }


        private void KontrolleriTemizle()
        {
            txt_Ad.Text = "";
            txt_Soyad.Text = string.Empty;
            comboBox_Sınıf.SelectedIndex = -1;
            comboBox_Sınıf.Text = "sınıfınızı seçin";
            DateTimePicker_Dogum.Value = DateTime.Now;
            foreach (int index in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(index, CheckState.Unchecked);

            }
             SecilenSecmeliDersler.Clear();
             checkBox1.Checked = false;
             ListeleriDoldur();

        }
        private void ListeleriDoldur()
        {
            listBoxASinifi.Items.Clear();
            listBoxASinifi.BackColor = Color.AliceBlue;
            listBoxASinifi.Items.AddRange(ASinifiOgrencileri.ToArray());

            listBoxBSinifi.Items.Clear();
            listBoxBSinifi.BackColor = Color.Azure;
            listBoxBSinifi.Items.AddRange(BSinifiOgrencileri.ToArray());

        }

        private void btn_HepsiniSagaGöner_Click(object sender, EventArgs e)
        {
            foreach (var item in ASinifiOgrencileri)
            {
                item.Sinifi = "B SINIFI";
            }
            BSinifiOgrencileri.AddRange(ASinifiOgrencileri.ToArray());
            ASinifiOgrencileri.Clear();
            ListeleriDoldur();
        }

        private void btn_SagaGönder_Click(object sender, EventArgs e)
        {
            // SEÇİLİ OLANI SAĞA GÖNDER
            //KİM SEÇİLİ olduğunu listboxtan selectıtem ile alıyoruz.
            //selectıtem bize object tipinde değer gönderiyor
            //bu nedenle gelen object i kullanacağımız class a cast ediyoruz.
            Ogrenci transferEdilecekOgr = listBoxASinifi.SelectedItem as Ogrenci;
            //2.yöntem :Ogrenci transferEdilecekOgr = (Ogrenci)listBoxASinifi.SelectedItem;
            if (transferEdilecekOgr != null)
            {
                ASinifiOgrencileri.Remove(transferEdilecekOgr);
                transferEdilecekOgr.Sinifi = "B SINIFI";
                BSinifiOgrencileri.Add(transferEdilecekOgr);
                ListeleriDoldur();
            }


        }

        private void btn_HepsiniSolaGönder_Click(object sender, EventArgs e)
        {
            foreach (var item in BSinifiOgrencileri)
            {
                item.Sinifi = "A SINIFI";
            }
            ASinifiOgrencileri.AddRange(BSinifiOgrencileri.ToArray());
            BSinifiOgrencileri.Clear();
            ListeleriDoldur();

        }

        private void btn_SolaGöner_Click(object sender, EventArgs e)
        {
            // SEÇİLİ OLANI SAĞA GÖNDER
            //KİM SEÇİLİ olduğunu listboxtan selectıtem ile alıyoruz.
            //selectıtem bize object tipinde değer gönderiyor
            //bu nedenle gelen object i kullanacağımız class a cast ediyoruz.
            Ogrenci transferEdilecekOgr = listBoxBSinifi.SelectedItem as Ogrenci;
            //2.yöntem :Ogrenci transferEdilecekOgr = (Ogrenci)listBoxASinifi.SelectedItem;
            if (transferEdilecekOgr != null)
            {
                BSinifiOgrencileri.Remove(transferEdilecekOgr);
                transferEdilecekOgr.Sinifi = "A SINIFI";
                ASinifiOgrencileri.Add(transferEdilecekOgr);
                ListeleriDoldur();
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                if (SecilenSecmeliDersler.Count(x => x == item.ToString()) == 0)
                {

                    SecilenSecmeliDersler.Add(item.ToString());
                }

            }

        }

        private void XMLileDisariAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Ogrenci> DisariAktarilacaklar = new List<Ogrenci>();
            //a sınıfında öğrenci varsa
            if (ASinifiOgrencileri.Count > 0)
            {
                DisariAktarilacaklar.AddRange(ASinifiOgrencileri);
            }

            if (BSinifiOgrencileri.Count > 0)
            {
                DisariAktarilacaklar.AddRange(BSinifiOgrencileri);
            }
            saveFileDialog1.Title = "öğrenci XML dosyası kaydet";
            saveFileDialog1.Filter = "XML FORMATI |*.xml";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //açılan dialog penceresinde ok tuşuna basarsa xml dosyasını oluşturabiliriz.
                //xml'i seriliaze edecek işlemler
                XmlSerializer myXMLSerializer = new XmlSerializer(typeof(List<Ogrenci>));
                //Bu yazımda C#’ta using bloğundan bahsedeceğim.IDisposable interface inden 
                //    türemiş nesneler using(){} bloğu içinde oluşturulursa,using bloğundan 
                //    çıkılır çıkılmaz GC(Garbage Collector)’ye devredilir ve hemen 
                //    silinirler(Dispose edilirler).Çünkü IDisposable’den türemiş classlarda 
                //    %100 Dispose metodu vardır.using bloğuda aslında blok sonunda bu metodu 
                //    çalıştırmaktadır.
                //    Bu sayede manuel olarak nesneyi Dispose etmemize gerek kalmaz.
                using (TextWriter yazar = new StreamWriter(saveFileDialog1.FileName))
                {
                    myXMLSerializer.Serialize(yazar, DisariAktarilacaklar);
                }
                MessageBox.Show($"{DisariAktarilacaklar.Count} adet öğrenci xml dosyası olarak aktarıldı");
            }
        }

        private void XMLIleIceriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // bilgisayarda olan xml dosyasını açmamıza yardımcı olacak dialog nesnesine ihtiyaç vardır.
            KontrolleriTemizle();
            openFileDialog1.Title = "XML dosyanızı seçin";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer myXMLSerializer = new XmlSerializer(typeof(List<Ogrenci>));
                using (StreamReader okuyucu = new StreamReader(openFileDialog1.FileName))
                {

                    //2.yöntem: ASinifiOgrencileri= myXMLSerializer.Deserialize(okuyucu) as List<Ogrenci>
                    //kısayol
                    ASinifiOgrencileri = (List<Ogrenci>)myXMLSerializer.Deserialize(okuyucu);
                    MessageBox.Show($"{ASinifiOgrencileri.Count} adet kişi içeri aktarıldı");
                    ListeleriDoldur();
                }

            }
        }
    }
}
