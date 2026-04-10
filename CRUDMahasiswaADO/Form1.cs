using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    public partial class Form1 : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=LAPTOP-GO2648H1\\DEVITADWI;Initial Catalog =DBAkademikADO;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }
        private void ConnectDatabase()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                MessageBox.Show("Koneksi berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal: " + ex.Message);
            }
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            ConnectDatabase();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtpTanggalLahir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
