using System.Data.SqlClient;

namespace Mesajlasma
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=krsDbMesajlasma;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Kisiler where Numara=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", mskNumara.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FormMesajlar mesajlar = new FormMesajlar();
                mesajlar.numara = mskNumara.Text;
                mesajlar.adSoyad = dr[1] + " " + dr[2];
                mesajlar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalý Bilgi");
            }
            baglanti.Close();
        }

        private void FormGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}