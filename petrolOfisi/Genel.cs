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
    public partial class Genel : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA\\SQLEXPRESS;Initial Catalog=PO;Integrated Security=True");
        void Listele()
        {
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT  pompa.isim, pompaci.Ad, pompaci.Soyad, arac.plaka, (yakit.fiyat * satis.miktar) as miktar, yakit.tur\r\nFROM     pompaci RIGHT OUTER JOIN\r\n                  satis ON pompaci.id = satis.pompaci LEFT OUTER JOIN\r\n                  pompa ON satis.pompa = pompa.id LEFT OUTER JOIN\r\n                  yakit RIGHT OUTER JOIN\r\n                  arac ON yakit.id = arac.yakit ON satis.arac = arac.id", baglanti);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sorgu;
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwGenel.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        public Genel()
        {
            InitializeComponent();
        }

        private void Genel_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
