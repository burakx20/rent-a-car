using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Rentacar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=database.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        string oresim;

        void listele()
        {
            baglan.Open();
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from kiralama", baglan);
            adaptor.Fill(ds, "kiralama");
            dataGridView1.DataSource = ds.Tables["kiralama"];
            adaptor.Dispose();
            baglan.Close();






        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog2.FileName;

                txt_mResim.Text = openFileDialog2.FileName;

                // "\" karakterinin ascii kodunu alma bölümü
                int s = 92;
                string harf = ((char)s).ToString();
                // Resmin adresinin tersten yazdırama bölümü
                string yazi = txt_mResim.Text; string metin = "";
                int yaziuzunlugu = yazi.Length;
                for (int i = yaziuzunlugu; i > 0; i--)
                {
                    if (yazi.Substring(i - 1, 1) == harf)
                    {
                        break;
                    }
                    metin = metin + (yazi.Substring(i - 1, 1));
                }
                // Bulunan resim adını düzden yazdırma bölümü
                int uzunluk = metin.Length; string kelime = "";
                for (int a = uzunluk; a > 0; a--)
                {
                    kelime = kelime + (metin.Substring(a - 1, 1));
                }
                //resim adını oresim kutusuna yazdırma bölümü
                txt_mResim.Text = "Resim/" + kelime;
                oresim = txt_mResim.Text;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_mResim.Text = pictureBox1.ImageLocation;
            if (txt_mAd.Text != "" && txt_mSoyad.Text != "" && txt_mTc.Text != "" && txt_mTel.Text != "" && txt_mAdres.Text != "" && txt_mMail.Text != "" && txt_mResim.Text != "" && txt_aMarka.Text != "" && txt_aModel.Text != "" && txt_aFiyat.Text != "" && txt_aSure.Text != "" && txt_aTarihi.Text != "")
            {
                komut.Connection = baglan;
                komut.CommandText = "Insert Into kiralama(k_adi, k_soyadi, k_tc, k_tel, k_adres, k_mail, k_resim, a_marka, a_model, a_fiyat, a_sure, a_tarihi) Values ('" + txt_mAd.Text + "','" + txt_mSoyad.Text + "','" + txt_mTc.Text + "','" + txt_mTel.Text + "','" + txt_mAdres.Text + "','" + txt_mMail.Text + "','" + txt_mResim.Text + "','" + txt_aMarka.Text + "','" + txt_aModel.Text + "','" + txt_aFiyat.Text + "','" + txt_aSure.Text + "','" + txt_aTarihi.Text + "')";
                baglan.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglan.Close();
                MessageBox.Show("Kayıt Tamamlandı!");
                ds.Clear();
                listele();
            }
            else
            {
                MessageBox.Show("Boş alan geçmeyiniz!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_mAd.Text = "";
            txt_mSoyad.Text = "";
            txt_mTc.Text = "";
            txt_mTel.Text = "";
            txt_mAdres.Text = "";
            txt_mMail.Text = "";
            txt_mResim.Text = "";
            txt_aMarka.Text = "";
            txt_aModel.Text = "";
            txt_aFiyat.Text = "";
            txt_aSure.Text = "";
            txt_aTarihi.Text = "";
            pictureBox1.ImageLocation = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (c == DialogResult.Yes)

                baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "Delete from kiralama where k_id =" + txt_kayitsil.Text + "";
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglan.Close();
            ds.Clear();
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_mAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_mSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_mTc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_mTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_mAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_mMail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_mResim.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_aMarka.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txt_aModel.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txt_aFiyat.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txt_aSure.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txt_aTarihi.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[7].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)//burası
        {
            baglan = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kiralama.mdb");
            da = new OleDbDataAdapter("SElect * from kiralama where k_id like '%" + txt_kayitara.Text + "%'", baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "kiralama");
            dataGridView1.DataSource = ds.Tables["kiralama"];
            baglan.Close();

            //Bulunan kayıt textboxlara atanarak gösteriliyor.
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_mAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_mSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_mTc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_mTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_mAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_mMail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_mResim.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_aMarka.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txt_aModel.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txt_aFiyat.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txt_aSure.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txt_aTarihi.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "update kiralama set k_adi='" + txt_mAd.Text + "', k_soyadi='" + txt_mSoyad.Text + "', k_tc='" + txt_mTc.Text + "', k_tel='" + txt_mTel.Text + "',k_adres='" + txt_mAdres.Text + "',k_mail='" + txt_mMail.Text + "',k_resim='" + txt_mResim.Text + "',a_marka='" + txt_aMarka.Text + "',a_model='" + txt_aModel.Text + "',a_fiyat='" + txt_aFiyat.Text + "',a_sure='" + txt_aSure.Text + "',a_tarihi='" + txt_aTarihi.Text + "' where k_id=" + txt_id.Text + "";
            komut.ExecuteNonQuery();
            baglan.Close();
            ds.Clear();
            listele();
        }
   
        private void button1_Click(object sender, EventArgs e)//burası
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kiralama.accdb"); con.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from kiralama where k_id=" + k_id.Text + "", con);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                k_marka.Text = dr["k_marka"].ToString();
                k_fiyat.Text = dr["k_fiyat"].ToString();
                k_musteri_adi.Text = dr["k_musteri_adi"].ToString();
                k_musteri_soyadi.Text = dr["k_musteri_soyadi"].ToString();
                k_musteri_tc.Text = dr["k_musteri_tc"].ToString();
                k_musteri_tel.Text = dr["k_musteri_tel"].ToString();
                k_musteri_adres.Text = dr["k_musteri_adres"].ToString();
                k_suresi.Text = dr["k_suresi"].ToString();
                k_tarihi.Text = dr["k_tarihi"].ToString();
                k_musteri_mail.Text = dr["k_musteri_mail"].ToString();
                pictureBox1.ImageLocation = dr["k_musteri_resmi"].ToString();
                k_musteri_resim.Text = dr["k_musteri_resmi"].ToString();
            }
            con.Close();
        }


    }
}