using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hayvanat_Bahcesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        HayvanatBahcesiEntities hayvan = new HayvanatBahcesiEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hayvanatBahcesiDataSet.Bilet' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.biletTableAdapter.Fill(this.hayvanatBahcesiDataSet.Bilet);
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)//görüntüle
        {
            
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = hayvan.Bilets.ToList();
                    break;

                case 1:
                    dataGridView1.DataSource = hayvan.Calisans.ToList();
                    break;
                case 2:
                    dataGridView1.DataSource = hayvan.Hayvans.ToList();
                    break;
                case 3:
                    dataGridView1.DataSource = hayvan.HayvanatBahcesis.ToList();
                    break;
                case 4:
                    dataGridView1.DataSource = hayvan.HayvanDetays.ToList();
                    break;
                case 5:
                    dataGridView1.DataSource = hayvan.Musteris.ToList();
                    break;
                case 6:
                    dataGridView1.DataSource = hayvan.Ctelefons.ToList();
                    break;
                case 7:
                    dataGridView1.DataSource = hayvan.Mtelefons.ToList();
                    break;
            }
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            switch (comboBox2.SelectedIndex)
            {
                case 0://bilet
                    label3.Text = "Bilet id:";
                    label4.Text = "Bilet ucret:";
                    label5.Text = "Bilet tarih:";
                    label6.Text = "Müşteri id:";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    label7.Text = "";
                    label8.Text = "";
                    label9.Text = "";

                    break;
                case 1://calisan
                    label3.Text = "Calisan id:";
                    label4.Text = "Calisan ad:";
                    label5.Text = "Calisan soyad:"; 
                    label6.Text = "Calisan maas:";
                    label7.Text = "Calisan kıdem:";
                    label8.Text = "Hayvanat Bahcesi id:";
                    label9.Text = "";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = false;
                    break;
                case 2://hayvan
                    label3.Text = "Hayvan id:";
                    label4.Text = "Hayvan cins:";
                    label5.Text = "Kafes no:";
                    label6.Text = "Dogum tarihi:";
                    label7.Text = "Habitat:";
                    label8.Text = "Calisan id:";
                    label9.Text = "Hayvanat Bahcesi id:";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true; 
                    break;
                case 3://hayvanat bahcesi
                    label3.Text = "Hayvanat bahcesi id:";
                    label4.Text = "Hayvanat bahcesi adı:";
                    label5.Text = "Hayvanat bahcesi tel:";
                    label6.Text = "Hayvanat bahcesi adresi:";
                    label7.Text = "Acilis:";
                    label8.Text = "Kapanis:";
                    label9.Text = "";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = false;
                    break;
                case 4://hayvna detay
                    label3.Text = "Hayvan detay id:";
                    label4.Text = "Hayvan id:";
                    label5.Text = "Hayvan boy:";
                    label6.Text = "Hayvan genislik:";
                    label7.Text = "Diyet:";
                    label8.Text = "Beslenme:";
                    label9.Text = "";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    break;
                case 5://musteri
                    label3.Text = "Musteri id:";
                    label4.Text = "Musteri ad:";
                    label5.Text = "Musteri soyad:";
                    label6.Text = "Musteri adresi:";
                    label7.Text = "Hayvanat bahcesi id:";
                    label8.Text = "";
                    label9.Text = "";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    break;
                case 6://Calisan tel
                    label3.Text = "Calisan telefon:";                
                    label4.Text = "Calisan id:";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    label5.Text = "";
                    label6.Text = ""; 
                    label7.Text = "";
                    label8.Text = ""; 
                    label9.Text = "";
                    break;
                case 7://musteri tel
                    label3.Text = "Musteri telefon:";
                    label4.Text = "Musteri id:";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    label5.Text = "";
                    label6.Text = "";
                    label7.Text = "";
                    label8.Text = "";
                    label9.Text = "";
                    break;

            }
        }

        private void button3_Click(object sender, EventArgs e)//gncelleme
        {
            switch (comboBox2.SelectedIndex)
            { 
                case 0:
                   
                    int value = Convert.ToInt32(textBox1.Text);
                    var güncelle = hayvan.Bilets.Where(w => w.Bid == value).FirstOrDefault();
                    if (textBox2.Text != "")
                    
                        güncelle.Btarih = Convert.ToInt32(textBox2.Text);

                    if (textBox3.Text != "")
                        güncelle.Bucret= Convert.ToInt32(textBox3.Text);
                    if (textBox4.Text != "")
                        güncelle.Mid= Convert.ToInt32(textBox4.Text);
                    break;
                case 1://çalısan

                    value = Convert.ToInt32(textBox1.Text);
                    var güncelle1 = hayvan.Calisans.Where(w => w.Cid == value).FirstOrDefault();
                    if (textBox2.Text != "")
                        güncelle1.Cad = textBox2.Text;
                    if (textBox3.Text != "")
                        güncelle1.Csoyad = textBox3.Text;
                    if (textBox4.Text != "")
                        güncelle1.Cmaas = Convert.ToInt32(textBox4.Text);
                    if (textBox5.Text != "")
                        güncelle1.Ckidem = textBox5.Text;
                    if (textBox6.Text != "")
                        güncelle1.HBid = Convert.ToInt32(textBox6.Text);
                    break;
                case 2: //hayvan

                    value = Convert.ToInt32(textBox1.Text);
                    var güncelle2 = hayvan.Hayvans.Where(w => w.Hid== value).FirstOrDefault();
                    if (textBox2.Text != "")
                        güncelle2.Hcins = textBox2.Text;
                    if (textBox3.Text != "")
                        güncelle2.Hkafesno = Convert.ToInt32(textBox3.Text);
                    if (textBox4.Text != "")
                        güncelle2.HdogumT = Convert.ToInt32(textBox4.Text);
                    if (textBox5.Text != "")
                        güncelle2.Hhabitat = textBox5.Text;
                    if (textBox6.Text != "")
                        güncelle2.Cid = Convert.ToInt32(textBox6.Text);
                    if (textBox7.Text != "")
                        güncelle2.HBid = Convert.ToInt32(textBox7.Text);
                    break;
                case 3: //hbahcesi

                    value = Convert.ToInt32(textBox1.Text);
                    var güncelle3 = hayvan.HayvanatBahcesis.Where(w => w.HBid == value).FirstOrDefault();
                    if (textBox2.Text != "")
                        güncelle3.HBad = textBox2.Text;
                    if (textBox3.Text != "")
                        güncelle3.HBtelefon = Convert.ToInt32(textBox3.Text);
                    if (textBox4.Text != "")
                        güncelle3.HBtelefon = Convert.ToInt32(textBox4.Text);
                    if (textBox5.Text != "")
                        güncelle3.HBadres = textBox5.Text;
                    if (textBox6.Text != "")
                        güncelle3.HBacilis = Convert.ToInt32(textBox6.Text);
                    if (textBox7.Text != "")
                        güncelle3.HBkapanis = Convert.ToInt32(textBox7.Text);
                    break;
                case 4://hdetay

                    value = Convert.ToInt32(textBox1.Text);
                    var güncelle4 = hayvan.HayvanDetays.Where(w => w.HDid == value).FirstOrDefault();
                    if (textBox2.Text != "")
                        güncelle4.Hid = Convert.ToInt32(textBox2.Text);
                    if (textBox3.Text != "")
                        güncelle4.HDboy = Convert.ToInt32(textBox3.Text);
                    if (textBox4.Text != "")
                        güncelle4.HDgenislik = Convert.ToInt32(textBox4.Text);
                    if (textBox5.Text != "")
                        güncelle4.HDdiyet = textBox5.Text;
                    if (textBox6.Text != "")
                        güncelle4.HDbeslenme = textBox6.Text;
                    break;
                case 5://müsteri

                    value = Convert.ToInt32(textBox1.Text);
                    var güncelle5 = hayvan.Musteris.Where(w => w.Mid == value).FirstOrDefault();
                    if (textBox2.Text != "")
                        güncelle5.Mad = textBox2.Text;
                    if (textBox3.Text != "")
                        güncelle5.Msoyad = textBox3.Text;
                    if (textBox4.Text != "")
                        güncelle5.Madres = textBox4.Text;
                    if (textBox5.Text != "")
                        güncelle5.HBid = Convert.ToInt32(textBox5.Text);
                    break;
                case 6: //çalısan tel

                     value = Convert.ToInt32(textBox1.Text);
                     var güncelle6 = hayvan.Ctelefons.Where(w => w.Cid == value).FirstOrDefault();
                    if (textBox2.Text != "")
                        güncelle6.Ctelefon1 = Convert.ToInt32(textBox2.Text);
                    break;
                case 7: //müsteri tel

                    value = Convert.ToInt32(textBox1.Text);
                    var güncelle7 = hayvan.Mtelefons.Where(w => w.Mid == value).FirstOrDefault();
                    if (textBox2.Text != "")
                        güncelle7.Mtelefon1 = Convert.ToInt32(textBox2.Text);
                    break;
            }
            button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)//ekleme
        {
            if (textBox1.Text == "")
                MessageBox.Show("ID boş bırakılamaz.Kaydetmiyorum.","HATA!");
           
            else
            {
                switch (comboBox2.SelectedIndex)
                {
                   
                    case 0:
                     
                        Bilet ekle = new Bilet();
                        ekle.Bid = Convert.ToInt32(textBox1.Text);
                        if (textBox2.Text != "") {
                            ekle.Btarih = Convert.ToInt32(textBox2.Text);
                        }
                        else
                        {
                            ekle.Btarih = -1;
                        }
                        if (textBox3.Text != "") {
                            ekle.Bucret = Convert.ToInt32(textBox3.Text);
                        }
                        else
                        {
                            ekle.Bucret = -1; 
                        }
                        if (textBox4.Text != "") {
                            ekle.Mid = Convert.ToInt32(textBox4.Text);
                        }
                        else
                        {
                            ekle.Mid = -1;
                        }
                        
                        hayvan.Bilets.Add(ekle);
                        hayvan.SaveChanges();
                        break;
                    case 1://çalısan

                        Calisan ekle1 = new Calisan();
                        ekle1.Cid = Convert.ToInt32(textBox1.Text);
                        if (textBox2.Text != "")
                        {
                            ekle1.Cad= textBox2.Text;
                        }
                        else
                        {
                            ekle1.Cad ="-1";
                        }
                        if (textBox3.Text != "")
                        {
                            ekle1.Csoyad = textBox3.Text;
                        }
                        else
                        {
                            ekle1.Csoyad = "-1";
                        }
                        if (textBox4.Text != "")
                        {
                            ekle1.Cmaas = Convert.ToInt32(textBox4.Text);
                        }
                        else
                        {
                            ekle1.Cmaas = -1;
                        }
                        if (textBox5.Text != "")
                        {
                            ekle1.Ckidem= textBox5.Text;
                        }
                        else
                        {
                            ekle1.Ckidem = "-1";
                        }
                        if (textBox6.Text != "")
                        {
                            ekle1.HBid = Convert.ToInt32(textBox6.Text);
                        }
                        else
                        {
                            ekle1.HBid = -1;
                        }

                        hayvan.Calisans.Add(ekle1);
                        hayvan.SaveChanges();
                        break;

                    case 2: //hayvan

                        Hayvan ekle2 = new Hayvan();
                        ekle2.Hid = Convert.ToInt32(textBox1.Text);
                        if (textBox2.Text != "")
                        {
                            ekle2.Hcins = textBox2.Text;
                        }
                        else
                        {
                            ekle2.Hcins = "-1";
                        }
                        if (textBox3.Text != "")
                        {
                            ekle2.Hkafesno = Convert.ToInt32(textBox3.Text);
                        }
                        else
                        {
                            ekle2.Hkafesno = -1;
                        }
                        if (textBox4.Text != "")
                        {
                            ekle2.HdogumT= Convert.ToInt32(textBox4.Text);
                        }
                        else
                        {
                            ekle2.HdogumT = -1;
                        }
                        if (textBox5.Text != "")
                        {
                            ekle2.Hhabitat = textBox5.Text;
                        }
                        else
                        {
                            ekle2.Hhabitat = "-1";
                        }
                        if (textBox6.Text != "")
                        {
                            ekle2.Cid = Convert.ToInt32(textBox6.Text);
                        }
                        else
                        {
                            ekle2.Cid = -1;
                        }
                        if (textBox7.Text != "")
                        {
                            ekle2.HBid= Convert.ToInt32(textBox7.Text);
                        }
                        else
                        {
                            ekle2.HBid= -1;
                        }
                        hayvan.Hayvans.Add(ekle2);
                        hayvan.SaveChanges();
                        break;
                    case 3: //hbahcesi
                        HayvanatBahcesi ekle3 = new HayvanatBahcesi();
                        ekle3.HBad = textBox1.Text;
                        if (textBox2.Text != "")
                        {
                            ekle3.HBad = textBox2.Text;
                        }
                        else
                        {
                            ekle3.HBad = "-1";
                        }
                        if (textBox3.Text != "")
                        {
                            ekle3.HBtelefon = Convert.ToInt32(textBox3.Text);
                        }
                        else
                        {
                            ekle3.HBtelefon = -1;
                        }
                        if (textBox4.Text != "")
                        {
                            ekle3.HBadres = textBox4.Text;
                        }
                        else
                        {
                            ekle3.HBadres = "-1";
                        }
                        if (textBox5.Text != "")
                        {
                            ekle3.HBacilis = Convert.ToInt32(textBox5.Text);
                        }
                        else
                        {
                            ekle3.HBacilis = -1;
                        }
                        if (textBox6.Text != "")
                        {
                            ekle3.HBkapanis = Convert.ToInt32(textBox6.Text);
                        }
                        else
                        {
                            ekle3.HBkapanis = -1;
                        }
                        
                        hayvan.HayvanatBahcesis.Add(ekle3);
                        hayvan.SaveChanges();
                        break;

                    case 4://hdetay
                        HayvanDetay ekle4 = new HayvanDetay();
                        ekle4.HDid = Convert.ToInt32(textBox1.Text);
                        if (textBox2.Text != "")
                        {
                            ekle4.Hid = Convert.ToInt32(textBox2.Text);
                        }
                        else
                        {
                            ekle4.Hid = -1;
                        }
                        if (textBox3.Text != "")
                        {
                            ekle4.HDboy = Convert.ToInt32(textBox3.Text);
                        }
                        else
                        {
                            ekle4.HDboy = -1;
                        }
                        if (textBox4.Text != "")
                        {
                            ekle4.HDgenislik = Convert.ToInt32(textBox4.Text);
                        }
                        else
                        {
                            ekle4.HDgenislik = -1;
                        }
                        if (textBox5.Text != "")
                        {
                            ekle4.HDdiyet = textBox5.Text;
                        }
                        else
                        {
                            ekle4.HDdiyet= "-1";
                        }
                        if (textBox6.Text != "")
                        {
                            ekle4.HDcinsiyet = textBox6.Text;
                        }
                        else
                        {
                            ekle4.HDcinsiyet = "-1";
                        }
                        if (textBox7.Text != "")
                        {
                            ekle4.HDbeslenme= textBox7.Text;
                        }
                        else
                        {
                            ekle4.HDbeslenme = "-1";
                        }
                        hayvan.HayvanDetays.Add(ekle4);
                        hayvan.SaveChanges();
                        break;

                    case 5://müsteri
                        Musteri ekle5 = new Musteri();
                        ekle5.Mid = Convert.ToInt32(textBox1.Text);
                        if (textBox2.Text != "")
                        {
                            ekle5.Mid = Convert.ToInt32(textBox2.Text);
                        }
                        else
                        {
                            ekle5.Mid = -1;
                        }
                        if (textBox3.Text != "")
                        {
                            ekle5.Mad = textBox3.Text;
                        }
                        else
                        {
                            ekle5.Mad = "-1";
                        }
                        if (textBox4.Text != "")
                        {
                            ekle5.Msoyad= textBox4.Text;
                        }
                        else
                        {
                            ekle5.Msoyad = "-1";
                        }
                        if (textBox5.Text != "")
                        {
                            ekle5.Madres= textBox5.Text;
                        }
                        else
                        {
                            ekle5.Madres = "-1";
                        }
                        hayvan.Musteris.Add(ekle5);
                        hayvan.SaveChanges();
                        
                        break;
                    case 6: //çalısan tel
                        Ctelefon ekle6 = new Ctelefon();
                        ekle6.Cid = Convert.ToInt32(textBox1.Text);
                        if (textBox2.Text != "")
                        {
                            ekle6.Ctelefon1 = Convert.ToInt32(textBox2.Text);
                        }
                        else
                        {
                            ekle6.Ctelefon1 = -1;
                        }
                        hayvan.Ctelefons.Add(ekle6);
                        hayvan.SaveChanges();
                        break;
                    case 7: //müsteri tel

                        Mtelefon ekle7 = new Mtelefon();
                        ekle7.Mid = Convert.ToInt32(textBox1.Text);
                        if (textBox2.Text != "")
                        {
                            ekle7.Mtelefon1 = Convert.ToInt32(textBox2.Text);
                        }
                        else
                        {
                            ekle7.Mtelefon1 = -1;
                        }
                        hayvan.Mtelefons.Add(ekle7);
                        hayvan.SaveChanges();
                        break;
                }
                button1_Click(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)//silme
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    int bid = Convert.ToInt32(textBox1.Text);
                    var sil = hayvan.Bilets.Where(w => w.Bid == bid).FirstOrDefault();
                    hayvan.Bilets.Remove(sil);
                    hayvan.SaveChanges();
                    break;

                case 1:
                    int cid = Convert.ToInt32(textBox1.Text);
                    var sil1 = hayvan.Calisans.Where(w => w.Cid == cid).FirstOrDefault();
                    hayvan.Calisans.Remove(sil1);
                    hayvan.SaveChanges();
                    break;
                case 2:
                    int hid = Convert.ToInt32(textBox1.Text);
                    var sil2 = hayvan.Hayvans.Where(w => w.Hid == hid).FirstOrDefault();
                    hayvan.Hayvans.Remove(sil2);
                    hayvan.SaveChanges();
                    break;
                case 3:
                    int HBid= Convert.ToInt32(textBox1.Text);
                    var sil3 = hayvan.HayvanatBahcesis.Where(w => w.HBid == HBid).FirstOrDefault();
                    hayvan.HayvanatBahcesis.Remove(sil3);
                    hayvan.SaveChanges();
                    break;
                case 4:
                    int HDid = Convert.ToInt32(textBox1.Text);
                    var sil4 = hayvan.HayvanDetays.Where(w => w.HDid == HDid).FirstOrDefault();
                    hayvan.HayvanDetays.Remove(sil4);
                    hayvan.SaveChanges();
                    break;
                case 5:
                    int mid = Convert.ToInt32(textBox1.Text);
                    var sil5 = hayvan.Musteris.Where(w => w.Mid == mid).FirstOrDefault();
                    hayvan.Musteris.Remove(sil5);
                    hayvan.SaveChanges();
                    break;
                case 6:
                    int caid = Convert.ToInt32(textBox1.Text);
                    var sil6 = hayvan.Ctelefons.Where(w => w.Cid == caid).FirstOrDefault();
                    hayvan.Ctelefons.Remove(sil6);
                    hayvan.SaveChanges();
                    break;
                case 7:
                    int muid = Convert.ToInt32(textBox1.Text);
                    var sil7 = hayvan.Mtelefons.Where(w => w.Mid == muid).FirstOrDefault();
                    hayvan.Mtelefons.Remove(sil7);
                    hayvan.SaveChanges();
                    break;
            }
            button1_Click(sender, e);
        }
    }
}
