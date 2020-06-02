namespace Rentacar
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_aMarka = new System.Windows.Forms.TextBox();
            this.txt_aModel = new System.Windows.Forms.TextBox();
            this.txt_aFiyat = new System.Windows.Forms.TextBox();
            this.txt_aSure = new System.Windows.Forms.TextBox();
            this.txt_aTarihi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_mAd = new System.Windows.Forms.TextBox();
            this.txt_mSoyad = new System.Windows.Forms.TextBox();
            this.txt_mTc = new System.Windows.Forms.TextBox();
            this.txt_mTel = new System.Windows.Forms.TextBox();
            this.txt_mAdres = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_mMail = new System.Windows.Forms.TextBox();
            this.txt_mResim = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_kayitsil = new System.Windows.Forms.TextBox();
            this.txt_kayitara = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(645, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARAÇ KİRALAMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "MUSTERI BILGILERI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1160, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "ARAC BILGILERI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1161, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Araç Markası: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1161, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Araç Modeli:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1161, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Araç Fiyatı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1161, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Kiralama Süresi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1161, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Kiralama Tarihi:";
            // 
            // txt_aMarka
            // 
            this.txt_aMarka.Location = new System.Drawing.Point(1268, 117);
            this.txt_aMarka.Name = "txt_aMarka";
            this.txt_aMarka.Size = new System.Drawing.Size(100, 20);
            this.txt_aMarka.TabIndex = 7;
            // 
            // txt_aModel
            // 
            this.txt_aModel.Location = new System.Drawing.Point(1268, 147);
            this.txt_aModel.Name = "txt_aModel";
            this.txt_aModel.Size = new System.Drawing.Size(100, 20);
            this.txt_aModel.TabIndex = 7;
            // 
            // txt_aFiyat
            // 
            this.txt_aFiyat.Location = new System.Drawing.Point(1268, 180);
            this.txt_aFiyat.Name = "txt_aFiyat";
            this.txt_aFiyat.Size = new System.Drawing.Size(100, 20);
            this.txt_aFiyat.TabIndex = 7;
            // 
            // txt_aSure
            // 
            this.txt_aSure.Location = new System.Drawing.Point(1268, 212);
            this.txt_aSure.Name = "txt_aSure";
            this.txt_aSure.Size = new System.Drawing.Size(100, 20);
            this.txt_aSure.TabIndex = 7;
            // 
            // txt_aTarihi
            // 
            this.txt_aTarihi.Location = new System.Drawing.Point(1268, 243);
            this.txt_aTarihi.Name = "txt_aTarihi";
            this.txt_aTarihi.Size = new System.Drawing.Size(100, 20);
            this.txt_aTarihi.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Müşteri Adı: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Müşteri Soyadı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Müşteri Tc:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Müşteri Tel:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(81, 249);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Müşteri Adres:";
            // 
            // txt_mAd
            // 
            this.txt_mAd.Location = new System.Drawing.Point(188, 120);
            this.txt_mAd.Name = "txt_mAd";
            this.txt_mAd.Size = new System.Drawing.Size(100, 20);
            this.txt_mAd.TabIndex = 7;
            // 
            // txt_mSoyad
            // 
            this.txt_mSoyad.Location = new System.Drawing.Point(188, 150);
            this.txt_mSoyad.Name = "txt_mSoyad";
            this.txt_mSoyad.Size = new System.Drawing.Size(100, 20);
            this.txt_mSoyad.TabIndex = 7;
            // 
            // txt_mTc
            // 
            this.txt_mTc.Location = new System.Drawing.Point(188, 183);
            this.txt_mTc.Name = "txt_mTc";
            this.txt_mTc.Size = new System.Drawing.Size(100, 20);
            this.txt_mTc.TabIndex = 7;
            // 
            // txt_mTel
            // 
            this.txt_mTel.Location = new System.Drawing.Point(188, 215);
            this.txt_mTel.Name = "txt_mTel";
            this.txt_mTel.Size = new System.Drawing.Size(100, 20);
            this.txt_mTel.TabIndex = 7;
            // 
            // txt_mAdres
            // 
            this.txt_mAdres.Location = new System.Drawing.Point(188, 246);
            this.txt_mAdres.Multiline = true;
            this.txt_mAdres.Name = "txt_mAdres";
            this.txt_mAdres.Size = new System.Drawing.Size(149, 68);
            this.txt_mAdres.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(81, 335);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Müşteri Mail:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(81, 366);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Müşteri Resim:";
            // 
            // txt_mMail
            // 
            this.txt_mMail.Location = new System.Drawing.Point(188, 332);
            this.txt_mMail.Name = "txt_mMail";
            this.txt_mMail.Size = new System.Drawing.Size(100, 20);
            this.txt_mMail.TabIndex = 7;
            // 
            // txt_mResim
            // 
            this.txt_mResim.Location = new System.Drawing.Point(188, 363);
            this.txt_mResim.Name = "txt_mResim";
            this.txt_mResim.Size = new System.Drawing.Size(100, 20);
            this.txt_mResim.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(375, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 261);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(84, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 195);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1164, 407);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 195);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(702, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "KAYIT SİL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(702, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "KAYIT ARA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(967, 435);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "YENİ KAYIT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(945, 490);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "KAYIT EKLE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(967, 552);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "RESİM EKLE";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(945, 607);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(131, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "KAYIT GÜNCELLE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(430, 409);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 17;
            // 
            // txt_kayitsil
            // 
            this.txt_kayitsil.Location = new System.Drawing.Point(562, 458);
            this.txt_kayitsil.Name = "txt_kayitsil";
            this.txt_kayitsil.Size = new System.Drawing.Size(100, 20);
            this.txt_kayitsil.TabIndex = 17;
            // 
            // txt_kayitara
            // 
            this.txt_kayitara.Location = new System.Drawing.Point(562, 497);
            this.txt_kayitara.Name = "txt_kayitara";
            this.txt_kayitara.Size = new System.Drawing.Size(100, 20);
            this.txt_kayitara.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(372, 461);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Silmek istediğiniz id yi yazın:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(372, 500);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(149, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Aranacak kiralık araç markası:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(372, 412);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "ID:";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 649);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_kayitara);
            this.Controls.Add(this.txt_kayitsil);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_mResim);
            this.Controls.Add(this.txt_mAdres);
            this.Controls.Add(this.txt_aTarihi);
            this.Controls.Add(this.txt_mMail);
            this.Controls.Add(this.txt_mTel);
            this.Controls.Add(this.txt_aSure);
            this.Controls.Add(this.txt_mTc);
            this.Controls.Add(this.txt_aFiyat);
            this.Controls.Add(this.txt_mSoyad);
            this.Controls.Add(this.txt_mAd);
            this.Controls.Add(this.txt_aModel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_aMarka);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Araç Kiralama";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_aMarka;
        private System.Windows.Forms.TextBox txt_aModel;
        private System.Windows.Forms.TextBox txt_aFiyat;
        private System.Windows.Forms.TextBox txt_aSure;
        private System.Windows.Forms.TextBox txt_aTarihi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_mAd;
        private System.Windows.Forms.TextBox txt_mSoyad;
        private System.Windows.Forms.TextBox txt_mTc;
        private System.Windows.Forms.TextBox txt_mTel;
        private System.Windows.Forms.TextBox txt_mAdres;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_mMail;
        private System.Windows.Forms.TextBox txt_mResim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_kayitsil;
        private System.Windows.Forms.TextBox txt_kayitara;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

