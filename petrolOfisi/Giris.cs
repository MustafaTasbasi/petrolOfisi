using petrolOfisi.Model;
using System.Data.SqlClient;

namespace petrolOfisi
{
    public partial class Giris : Form
    {

        public Giris()
        {
            InitializeComponent();
        }



        private void btnYakitIslemleri_Click_1(object sender, EventArgs e)
        {
            YakitKayit yakit = new YakitKayit();
            yakit.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PompaciKayit pompaciKayit = new PompaciKayit();
            pompaciKayit.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AracKayit aracKayit = new AracKayit();
            aracKayit.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Genel genel = new Genel();
            genel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pompa1 pompa1 = new Pompa1();
            pompa1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pompa2 pompa2 = new Pompa2();
            pompa2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
