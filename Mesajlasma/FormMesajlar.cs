using System.Data;
using System.Data.SqlClient;

namespace Mesajlasma
{
    public partial class FormMesajlar : Form
    {
        public FormMesajlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=krsDbMesajlasma;Integrated Security=True");
        public string numara, adSoyad;

        void GelenKutusu()
        {
            SqlDataAdapter da = new SqlDataAdapter("select (K.Ad + ' ' + K.Soyad) as'Gönderen', M.Baslik as 'Başlık', M.Icerik as 'İçerik' from tbl_Mesajlar M inner join tbl_Kisiler K on M.Gonderen = K.Numara where M.Alici =" + numara, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void GidenKutusu()
        {
            SqlDataAdapter da = new SqlDataAdapter("select (K.Ad + ' ' + K.Soyad)  as 'Alıcı', M.Baslik as 'Başlık', M.Icerik as 'İçerik' from tbl_Mesajlar M inner join tbl_Kisiler K on M.Alici = K.Numara where M.Gonderen =" + numara, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        void Temizle()
        {
            mskAlici.Clear();
            txtBaslik.Clear();
            rchMesaj.Clear();
        }

        private void FormMesajlar_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;
            lblAdSoyad.Text = adSoyad;

            GelenKutusu();
            GidenKutusu();
        }

        private void FormMesajlar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_Mesajlar (Gonderen,Alici,Baslik,Icerik) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            komut.Parameters.AddWithValue("@p2", mskAlici.Text);
            komut.Parameters.AddWithValue("@p3", txtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", rchMesaj.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Mesaj Gönderildi");
            Temizle();
            GidenKutusu();
        }
    }
}
