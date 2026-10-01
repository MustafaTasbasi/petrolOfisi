using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace petrolOfisi
{
    public partial class YakitKayit : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA\\SQLEXPRESS;Initial Catalog=PO;Integrated Security=True");
        petrolOfisi.Model.Yakit yakit = new Model.Yakit();
        public YakitKayit()
        {
            InitializeComponent();
        }
        void Listele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from Yakit", baglanti);
            DataSet ds = new DataSet();

            da.Fill(ds, "A");
            dgwYakit.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtYakitTuru.Text == "" || cbFiyat.Text == "")
            {

                MessageBox.Show("Boş kalan yerleri doldurunuz.");

            }

            else
            {

                baglanti.Open(); //öncelikle bağlantının açılması gerekir.
                                 //SqlCommand komutlar = new SqlCommand("insert into hasta(tc,isim,soyisim,dtarihi,adres,tel,mail,sifre) values ('11111111111','ali','veli','1.1.2000','sakarya','5070812565','n@n.com','123456')", baglanti); //Sqlcommand sınıfından komut isminde nesne türetilir. çift tırnak içine sql sorgusu yazılır.

                yakit.tur = txtYakitTuru.Text;
                yakit.fiyat = Convert.ToInt32(cbFiyat.Text);
                SqlCommand komutlar = new SqlCommand("insert into yakit(tur,fiyat) values (@p1,@p2)", baglanti); //Sqlcommand sınıfından komut isminde nesne türetilir. çift tırnak içine sql sorgusu yazılır.
                komutlar.Parameters.AddWithValue("@p1", yakit.tur); //komut nesnesinden gelen parametreleri değer olarak ekle.
                komutlar.Parameters.AddWithValue("@p2", yakit.fiyat);


                komutlar.ExecuteNonQuery();
                baglanti.Close();
                txtYakitTuru.Text = "";
                cbFiyat.Text = "";
                MessageBox.Show("Kayıt işlemi gerçekleşti!");
                Listele();
            }
        }

        private void Yakit_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dgwYakit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dgwYakit.SelectedCells[0].RowIndex;
            yakit.id = Convert.ToInt32(dgwYakit.Rows[x].Cells[0].Value.ToString());
            lblId.Text = yakit.id.ToString();
            txtYakitTuru.Text = dgwYakit.Rows[x].Cells[1].Value.ToString();
            yakit.tur = txtYakitTuru.Text;
            cbFiyat.Text = dgwYakit.Rows[x].Cells[2].Value.ToString();
            yakit.fiyat = Convert.ToInt32(cbFiyat.Text);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtYakitTuru.Text == "" || cbFiyat.Text == "" || lblId.Text == "")
            {

                MessageBox.Show("Boş kalan yerleri doldurunuz.");

            }
            else
            {
                baglanti.Open();

                yakit.tur = txtYakitTuru.Text;
                yakit.fiyat = Convert.ToInt32(cbFiyat.Text);

                SqlCommand komutlar = new SqlCommand("update yakit set tur ='" + yakit.tur + "', fiyat = '" + yakit.fiyat + "' where id= '" + yakit.id.ToString() + "'", baglanti);

                komutlar.ExecuteNonQuery();
                baglanti.Close();
                txtYakitTuru.Text = "";
                cbFiyat.Text = "";
                MessageBox.Show("Güncelleme işlemi gerçekleşti!");
                Listele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutlar = new SqlCommand("delete from yakit where id= '" + yakit.id.ToString() + "'", baglanti);

            komutlar.ExecuteNonQuery();
            baglanti.Close();
            txtYakitTuru.Text = "";
            cbFiyat.Text = "";
            MessageBox.Show("Silme işlemi gerçekleşti!");
            Listele();
        }
    }
}

