using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSApp2
{
    public partial class Form5 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=SEIF;Initial Catalog=HMSDB5;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public DataTable LoadAPPOINTMENT()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM APPOINTMENT";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
        public Form5()
        {
            InitializeComponent();
            dataGridView1.DataSource = LoadAPPOINTMENT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var home = new Form2();
            home.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
