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
    public partial class AracKayit : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA\\SQLEXPRESS;Initial Catalog=PO;Integrated Security=True");
        petrolOfisi.Model.Arac aracKayit = new Model.Arac();
        List<Yakit> yakitlar;
        public AracKayit()
        {
            InitializeComponent();
        }
        void Listele()
        {
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT * from Arac", baglanti);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sorgu;
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwAracKayit.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        void Doldur()
        {
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT * from Yakit", baglanti);
            SqlDataReader rd = sorgu.ExecuteReader();
            while (rd.Read())
            {
                Yakit yakit = new Yakit();
                yakit.id = Convert.ToInt32(rd[0]);
                yakit.tur = rd[1].ToString();
                yakit.fiyat = Convert.ToInt32(rd[2]);
                yakitlar.Add(yakit);
            }
            baglanti.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cbMarka.Text == "" || txtPlaka.Text == "" || cbYakit.Text == "")
            {

                MessageBox.Show("Boş kalan yerleri doldurunuz.");

            }

            else
            {

                baglanti.Open(); //öncelikle bağlantının açılması gerekir.
                                 //SqlCommand komutlar = new SqlCommand("insert into hasta(tc,isim,soyisim,dtarihi,adres,tel,mail,sifre) values ('11111111111','ali','veli','1.1.2000','sakarya','5070812565','n@n.com','123456')", baglanti); //Sqlcommand sınıfından komut isminde nesne türetilir. çift tırnak içine sql sorgusu yazılır.

                aracKayit.marka = cbMarka.Text;
                aracKayit.plaka = txtPlaka.Text;
                aracKayit.yakit = (yakitlar[cbYakit.SelectedIndex]).id;
                SqlCommand komutlar = new SqlCommand("insert into Arac(marka,plaka,yakit) values (@p1,@p2,@p3)", baglanti); //Sqlcommand sınıfından komut isminde nesne türetilir. çift tırnak içine sql sorgusu yazılır.
                komutlar.Parameters.AddWithValue("@p1", aracKayit.marka); //komut nesnesinden gelen parametreleri değer olarak ekle.
                komutlar.Parameters.AddWithValue("@p2", aracKayit.plaka);
                komutlar.Parameters.AddWithValue("@p3", aracKayit.yakit);


                komutlar.ExecuteNonQuery();
                baglanti.Close();
                cbMarka.Text = "";
                txtPlaka.Text = "";
                cbYakit.Text = "";
                MessageBox.Show("Kayıt işlemi gerçekleşti!");
                Listele();
            }
        }


        private void AracKayit_Load(object sender, EventArgs e)
        {
            Listele();
            yakitlar = new List<Yakit>();
            Doldur();
            foreach (var y in yakitlar)
            {
                cbYakit.Items.Add(y.tur);
            }
        }

        private void dgwAracKayit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dgwAracKayit.SelectedCells[0].RowIndex;
            aracKayit.id = Convert.ToInt32(dgwAracKayit.Rows[x].Cells[0].Value.ToString());
            lblId.Text = aracKayit.id.ToString();
            cbMarka.Text = dgwAracKayit.Rows[x].Cells[1].Value.ToString();
            aracKayit.marka = cbMarka.Text;
            txtPlaka.Text = dgwAracKayit.Rows[x].Cells[2].Value.ToString();
            aracKayit.plaka = txtPlaka.Text;
            int veri = Convert.ToInt32(dgwAracKayit.Rows[x].Cells[3].Value.ToString());
            var eleman = yakitlar.Where(x => x.id == veri);
            cbYakit.Text = eleman.FirstOrDefault().tur.ToString();
            aracKayit.yakit = veri;

        }





        private void btnSil_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            String komut = "delete from Arac where id= '" + aracKayit.id.ToString() + "'";
            SqlCommand komutlar = new SqlCommand(komut, baglanti);

            komutlar.ExecuteNonQuery();
            baglanti.Close();
            cbMarka.Text = "";
            txtPlaka.Text = "";
            cbYakit.Text = "";

            MessageBox.Show("Silme işlemi gerçekleşti!");
            Listele();
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            if (cbMarka.Text == "" || txtPlaka.Text == "" || cbYakit.Text == "")
            {

                MessageBox.Show("Boş kalan yerleri doldurunuz.");

            }
            else
            {
                baglanti.Open();

                aracKayit.marka = cbMarka.Text;
                aracKayit.plaka = txtPlaka.Text;
                aracKayit.yakit = (yakitlar[cbYakit.SelectedIndex]).id;
                String komut = "update Arac set marka ='" + aracKayit.marka + "', plaka = '" + aracKayit.plaka + "', yakit = '" + aracKayit.yakit + "' where id= '" + aracKayit.id.ToString() + "'";
                SqlCommand komutlar = new SqlCommand(komut, baglanti);

                komutlar.ExecuteNonQuery();
                baglanti.Close();
                cbMarka.Text = "";
                txtPlaka.Text = "";
                cbYakit.Text = "";
                MessageBox.Show("Güncelleme işlemi gerçekleşti!");
                Listele();
            }

        }

        private void lblMarka_Click(object sender, EventArgs e)
        {

        }
    }
}
