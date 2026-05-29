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

namespace Project1_AdonetProject
{
    public partial class FrmCity : Form
    {
        public FrmCity()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=ARDA\SQLEXPRESS;Initial Catalog=DbCustomer;Integrated Security=True;TrustServerCertificate=True");
            
           baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLCİTY", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Close();   






        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=ARDA\SQLEXPRESS;Initial Catalog=DbCustomer;Integrated Security=True;TrustServerCertificate=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLCİTY (CityName,CityCountry) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtCityName.Text);
            komut.Parameters.AddWithValue("@p2", txtCityCountry.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Şehir Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(@"Data Source=ARDA\SQLEXPRESS;Initial Catalog=DbCustomer;Integrated Security=True;TrustServerCertificate=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From TBLCİTY where CityID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtCityID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Şehir Silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=ARDA\SQLEXPRESS;Initial Catalog=DbCustomer;Integrated Security=True;TrustServerCertificate=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TBLCİTY set CityName=@p1,CityCountry=@p2 where CityID=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", txtCityName.Text);
            komut.Parameters.AddWithValue("@p2", txtCityCountry.Text);
            komut.Parameters.AddWithValue("@p3", txtCityID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Şehir Güncellendi");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=ARDA\SQLEXPRESS;Initial Catalog=DbCustomer;Integrated Security=True;TrustServerCertificate=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLCİTY where CityName=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtCityName.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();


        }
    }
}
