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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ARDA\SQLEXPRESS;Initial Catalog=DbCustomer;Integrated Security=True;TrustServerCertificate=True");

        private void btnList_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select CustomerID,CustomerName,CustomerSurname,CityName,CustomerBalance,CustomerStatus from TBLCUSTOMER \r\ninner join TBLCİTY ON TBLCİTY.CityID=TBLCUSTOMER.CustomerCity", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();


        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("execute CustomerListWİthCity", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
 private void FrmCustomer_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLCİTY", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbCity.DisplayMember = "CityName";
            cmbCity.ValueMember = "CityID";
            cmbCity.DataSource = dt;
            baglanti.Close();

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLCUSTOMER (CustomerName,CustomerSurname,CustomerCity,CustomerBalance,CustomerStatus) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtCustomerName.Text);
            komut.Parameters.AddWithValue("@p2", txtCustomerSurname.Text);
            komut.Parameters.AddWithValue("@p3", cmbCity.SelectedValue);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtCustomerBalance.Text));
           if (radioButton1.Checked)
            {
                komut.Parameters.AddWithValue("@p5", true);
            }
            if (radioButton2.Checked)
            {
                komut.Parameters.AddWithValue("@p5", false);
            }
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From TBLCUSTOMER where CustomerID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtCustomerID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Silindi");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLCUSTOMER set CustomerName=@p1,CustomerSurname=@p2,CustomerCity=@p3,CustomerBalance=@p4,CustomerStatus=@p5 where CustomerID=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", txtCustomerName.Text);
            komut.Parameters.AddWithValue("@p2", txtCustomerSurname.Text);
            komut.Parameters.AddWithValue("@p3", cmbCity.SelectedValue);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtCustomerBalance.Text));
            if (radioButton1.Checked)
            {
                komut.Parameters.AddWithValue("@p5", true);
            }
            if (radioButton2.Checked)
            {
                komut.Parameters.AddWithValue("@p5", false);
            }
            komut.Parameters.AddWithValue("@p6", txtCustomerID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Güncellendi");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            baglanti.Open();
         SqlCommand komut = new SqlCommand("Select * From TBLCUSTOMER where CustomerName=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtCustomerName.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();



        }
    }
}
