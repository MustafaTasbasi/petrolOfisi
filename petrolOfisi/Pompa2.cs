using petrolOfisi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petrolOfisi
{
    public partial class Pompa2 : Form
    {
        Satis satis = new Satis();
        SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA\\SQLEXPRESS;Initial Catalog=PO;Integrated Security=True");

        List<Pompaci> Pompacilar;
        List<Arac> Araclar;
        void Doldur()
        {
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT * from Arac", baglanti);
            SqlDataReader rd = sorgu.ExecuteReader();
            while (rd.Read())
            {
                Arac arac = new Arac();
                arac.id = Convert.ToInt32(rd[0]);
                arac.marka = rd[1].ToString();
                arac.plaka = rd[2].ToString();
                arac.yakit = Convert.ToInt32(rd[3]);
                Araclar.Add(arac);
            }
            rd.Close();
            SqlCommand sorgu2 = new SqlCommand("SELECT * from Pompaci", baglanti);
            SqlDataReader rd2 = sorgu2.ExecuteReader();
            while (rd2.Read())
            {
                Pompaci pompaci = new Pompaci();
                pompaci.id = Convert.ToInt32(rd2[0]);
                pompaci.Ad = rd2[1].ToString();
                pompaci.Soyad = rd2[2].ToString();
                pompaci.telefon = rd2[3].ToString();
                Pompacilar.Add(pompaci);
            }
            baglanti.Close();
        }
        public Pompa2()
        {
            InitializeComponent();
        }

        private void Pompa2_Load(object sender, EventArgs e)
        {
            Araclar = new List<Arac>();
            Pompacilar = new List<Pompaci>();
            Doldur();
            foreach (var y in Araclar)
            {
                cbArac.Items.Add(y.plaka);
            }
            foreach (var y in Pompacilar)
            {
                cbPompaci.Items.Add(y.Ad);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cbPompaci.Text == "" || cbArac.Text == "" || txtLitre.Text == "")
            {

                MessageBox.Show("Boş kalan yerleri doldurunuz.");

            }

            else
            {

                baglanti.Open(); //öncelikle bağlantının açılması gerekir.
                                 //SqlCommand komutlar = new SqlCommand("insert into hasta(tc,isim,soyisim,dtarihi,adres,tel,mail,sifre) values ('11111111111','ali','veli','1.1.2000','sakarya','5070812565','n@n.com','123456')", baglanti); //Sqlcommand sınıfından komut isminde nesne türetilir. çift tırnak içine sql sorgusu yazılır.

                satis.pompaci = (Pompacilar[cbPompaci.SelectedIndex]).id;
                satis.arac = (Araclar[cbArac.SelectedIndex]).id;
                satis.miktar = Convert.ToInt32(txtLitre.Text);
                satis.tarih = DateTime.Now;
                satis.pompa = 2;
                String sorgu = "insert into satis(miktar,arac,pompa,pompaci,tarih) values (@p1,@p2,@p3,@p4,@p5)";
                SqlCommand komutlar = new SqlCommand(sorgu, baglanti); //Sqlcommand sınıfından komut isminde nesne türetilir. çift tırnak içine sql sorgusu yazılır.
                komutlar.Parameters.AddWithValue("@p1", satis.miktar); //komut nesnesinden gelen parametreleri değer olarak ekle.
                komutlar.Parameters.AddWithValue("@p2", satis.arac);
                komutlar.Parameters.AddWithValue("@p3", satis.pompa);
                komutlar.Parameters.AddWithValue("@p4", satis.pompaci);
                komutlar.Parameters.AddWithValue("@p5", satis.tarih);

                komutlar.ExecuteNonQuery();
                baglanti.Close();
                cbPompaci.Text = "";
                cbArac.Text = "";
                txtLitre.Text = "";
                MessageBox.Show("kayıt gerçekleşti");
            }
        }
    }
}
