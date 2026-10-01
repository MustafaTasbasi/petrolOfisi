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
    public partial class PompaciKayit : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA\\SQLEXPRESS;Initial Catalog=PO;Integrated Security=True");
        petrolOfisi.Model.Pompaci pompaciKayit = new Model.Pompaci();
        public PompaciKayit()
        {
            InitializeComponent();
        }
        void Listele()
        {
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT * from Pompaci", baglanti);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sorgu;
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwPompaciKayit.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTel.Text == "")
            {

                MessageBox.Show("Boş kalan yerleri doldurunuz.");

            }

            else
            {

                baglanti.Open(); //öncelikle bağlantının açılması gerekir.
                                 //SqlCommand komutlar = new SqlCommand("insert into hasta(tc,isim,soyisim,dtarihi,adres,tel,mail,sifre) values ('11111111111','ali','veli','1.1.2000','sakarya','5070812565','n@n.com','123456')", baglanti); //Sqlcommand sınıfından komut isminde nesne türetilir. çift tırnak içine sql sorgusu yazılır.

                pompaciKayit.Ad = txtAd.Text;
                pompaciKayit.Soyad = txtSoyad.Text;
                pompaciKayit.telefon = txtTel.Text;
                SqlCommand komutlar = new SqlCommand("insert into Pompaci(Ad,Soyad,telefon) values (@p1,@p2,@p3)", baglanti); //Sqlcommand sınıfından komut isminde nesne türetilir. çift tırnak içine sql sorgusu yazılır.
                komutlar.Parameters.AddWithValue("@p1", pompaciKayit.Ad); //komut nesnesinden gelen parametreleri değer olarak ekle.
                komutlar.Parameters.AddWithValue("@p2", pompaciKayit.Soyad);
                komutlar.Parameters.AddWithValue("@p3", pompaciKayit.telefon);


                komutlar.ExecuteNonQuery();
                baglanti.Close();
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtTel.Text = "";
                MessageBox.Show("kayıt gerçekleşti");
                Listele();
            }
        }


        private void PompaciKayit_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dgwPompaciKayit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dgwPompaciKayit.SelectedCells[0].RowIndex;
            pompaciKayit.id = Convert.ToInt32(dgwPompaciKayit.Rows[x].Cells[0].Value.ToString());
            lblId.Text = pompaciKayit.id.ToString();
            txtAd.Text = dgwPompaciKayit.Rows[x].Cells[1].Value.ToString();
            pompaciKayit.Ad = txtAd.Text;
            txtSoyad.Text = dgwPompaciKayit.Rows[x].Cells[2].Value.ToString();
            pompaciKayit.Soyad = txtSoyad.Text;
            txtTel.Text = dgwPompaciKayit.Rows[x].Cells[3].Value.ToString();
            pompaciKayit.telefon = txtTel.Text;

        }





        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (pompaciKayit.Ad == "Halil" && pompaciKayit.Soyad == "Kral")
                MessageBox.Show("Yönetici Silinemez!");
            else
            {
                baglanti.Open();
                String komut = "delete from Pompaci where id= '" + pompaciKayit.id.ToString() + "'";
                SqlCommand komutlar = new SqlCommand(komut, baglanti);

                komutlar.ExecuteNonQuery();
                baglanti.Close();
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtTel.Text = "";

                MessageBox.Show("Silme işlemi gerçekleşti!");
                Listele();
            }     
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTel.Text == "")
            {

                MessageBox.Show("Boş kalan yerleri doldurunuz.");

            }
            else
            {
                baglanti.Open();

                pompaciKayit.Ad = txtAd.Text;
                pompaciKayit.Soyad = txtSoyad.Text;
                pompaciKayit.telefon = txtTel.Text;
                String komut = "update Pompaci set Ad ='" + pompaciKayit.Ad + "', Soyad = '" + pompaciKayit.Soyad + "', telefon = '" + pompaciKayit.telefon + "' where id= '" + pompaciKayit.id.ToString() + "'";
                SqlCommand komutlar = new SqlCommand(komut, baglanti);
               
                komutlar.ExecuteNonQuery();
                baglanti.Close();
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtTel.Text = "";
                MessageBox.Show("güncelleme gerçekleşti");
                Listele();
            }
        }
    }
}
