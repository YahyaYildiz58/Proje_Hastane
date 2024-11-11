using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCnumara;
        SQLbaglantisi bgl=new SQLbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTCNO.Text = TCnumara;
            //ad soyad
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreterler where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",LblTCNO.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read()) 
            { 
                LblAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları datagride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //doktorları listeye aktarma
            DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar' ,DoktorBrans From Tbl_Doktorlar",bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //branşı komboboxa aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CboxBrans.Items.Add(dr2[0]);
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("Insert Into Tbl_Randevular (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor) Values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", MboxTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", MboxSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", CboxBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", CboxDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu oluşturuldu.");


        }

        private void CboxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CboxDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",CboxBrans.Text);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read()) 
            {
                CboxDoktor.Items.Add(dr[0] + " " + dr[1]);

            }
            bgl.baglanti().Close();
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",RTboxDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu");
        }

        private void BtnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();
        }

        private void BtnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBransPaneli frmBrans = new FrmBransPaneli();
            frmBrans.Show();
        }

        private void BtnRandevuPaneli_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr1 = new FrmRandevuListesi();
            fr1.Show();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }
    }
}
