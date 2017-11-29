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
using System.Data.SqlClient;
using System.Data.Sql;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = MERT\\SQLEXPRESS; Initial Catalog = sifre; Integrated Security = True; ");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
       
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        
        private void txtKullaniciAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                string sql = "Select * From sifreler where kullanıcıAdı=@adi And sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("adi", txtKullaniciAd.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", txtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, conn);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                
                if (dt.Rows.Count > 0)
                {
                    AnaForm ac = new AnaForm();
                    ac.Show();

                }


                }
            catch(Exception)
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
