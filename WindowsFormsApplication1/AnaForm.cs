using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class AnaForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = MERT\\SQLEXPRESS; Initial Catalog = sifre; Integrated Security = True; ");
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox text_SiteAdi;
        private TextBox text_Sifre;
        private TextBox text_Mail;
        private TextBox text_Adres;
        private DataGridView dataGridView1;
        private Button Btn_Sil;
        private Button Btn_Guncelle;
        private Button Btn_Ekle;
        private Label label1;

        public AnaForm()

        {
            InitializeComponent();
            DatagridYenile();
        }
        protected void DatagridYenile()
        {
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("Select Id, adres, mail, sifre , siteadi from tbtkullanicilar ", conn);
            adptr.Fill(tbl);
            conn.Close();
            dataGridView1.DataSource = tbl; 
        }
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.Btn_Ekle = new System.Windows.Forms.Button();
            this.text_SiteAdi = new System.Windows.Forms.TextBox();
            this.text_Sifre = new System.Windows.Forms.TextBox();
            this.text_Mail = new System.Windows.Forms.TextBox();
            this.text_Adres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Btn_Sil);
            this.panel1.Controls.Add(this.Btn_Guncelle);
            this.panel1.Controls.Add(this.Btn_Ekle);
            this.panel1.Controls.Add(this.text_SiteAdi);
            this.panel1.Controls.Add(this.text_Sifre);
            this.panel1.Controls.Add(this.text_Mail);
            this.panel1.Controls.Add(this.text_Adres);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 345);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(217, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(512, 302);
            this.dataGridView1.TabIndex = 13;
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Sil.Location = new System.Drawing.Point(89, 306);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(100, 23);
            this.Btn_Sil.TabIndex = 12;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.UseVisualStyleBackColor = true;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Guncelle.Location = new System.Drawing.Point(89, 267);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(100, 23);
            this.Btn_Guncelle.TabIndex = 11;
            this.Btn_Guncelle.Text = "Güncelle";
            this.Btn_Guncelle.UseVisualStyleBackColor = true;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // Btn_Ekle
            // 
            this.Btn_Ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Ekle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Ekle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Btn_Ekle.Location = new System.Drawing.Point(89, 227);
            this.Btn_Ekle.Name = "Btn_Ekle";
            this.Btn_Ekle.Size = new System.Drawing.Size(100, 21);
            this.Btn_Ekle.TabIndex = 10;
            this.Btn_Ekle.Text = "Ekle";
            this.Btn_Ekle.UseVisualStyleBackColor = true;
            this.Btn_Ekle.Click += new System.EventHandler(this.Btn_Ekle_Click_1);
            // 
            // text_SiteAdi
            // 
            this.text_SiteAdi.Location = new System.Drawing.Point(89, 151);
            this.text_SiteAdi.Name = "text_SiteAdi";
            this.text_SiteAdi.Size = new System.Drawing.Size(100, 20);
            this.text_SiteAdi.TabIndex = 9;
            this.text_SiteAdi.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // text_Sifre
            // 
            this.text_Sifre.Location = new System.Drawing.Point(89, 106);
            this.text_Sifre.Name = "text_Sifre";
            this.text_Sifre.Size = new System.Drawing.Size(100, 20);
            this.text_Sifre.TabIndex = 7;
            // 
            // text_Mail
            // 
            this.text_Mail.Location = new System.Drawing.Point(89, 74);
            this.text_Mail.Name = "text_Mail";
            this.text_Mail.Size = new System.Drawing.Size(100, 20);
            this.text_Mail.TabIndex = 6;
            // 
            // text_Adres
            // 
            this.text_Adres.Location = new System.Drawing.Point(89, 36);
            this.text_Adres.Name = "text_Adres";
            this.text_Adres.Size = new System.Drawing.Size(100, 20);
            this.text_Adres.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label5.Location = new System.Drawing.Point(13, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Site Adı:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label3.Location = new System.Drawing.Point(26, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label2.Location = new System.Drawing.Point(26, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adres:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AnaForm
            // 
            this.ClientSize = new System.Drawing.Size(731, 339);
            this.Controls.Add(this.panel1);
            this.Name = "AnaForm";
            this.Text = "Şifre Oluşturucu";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void Btn_Ekle_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand kmt = new SqlCommand("Insert into  tbtkullanicilar VALUES  ('" + text_Adres.Text + "','" + text_Mail.Text + "','" + text_Sifre.Text + "', '" + text_SiteAdi.Text + "' )", conn);
            kmt.ExecuteNonQuery();
            conn.Close();
            DatagridYenile();
        }
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand kmt = new SqlCommand("UPDATE tbtkullanicilar set  adres='" + text_Adres.Text
                + "' ,mail='" + text_Mail.Text + "' ,sifre='" + text_Sifre.Text + "' ,siteadi='"  + text_SiteAdi.Text + "'    where Id =" +
                dataGridView1.CurrentRow.Cells["Id"].Value.ToString(), conn);

            kmt.ExecuteNonQuery();
            conn.Close();
            DatagridYenile();
        }
         private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {

                text_Adres.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["adres"].Value.ToString();
                text_Mail.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["mail"].Value.ToString();
                text_Sifre.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["sifre"].Value.ToString();
                text_SiteAdi.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["siteadi"].Value.ToString();
            }

            catch
            {

            }
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand kmt = new SqlCommand("DELETE  tbtkullanicilar where Id =" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString(), conn);
            kmt.ExecuteNonQuery();
            conn.Close();
            DatagridYenile();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            
        }
    }


}
