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
    public partial class Form7 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=SEIF;Initial Catalog=HMSDB6;Integrated Security=True;TrustServerCertificate=True");

        public DataTable LoadROOM()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM ROOM";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
        public Form7()
        {
            InitializeComponent();
            dataGridView1.DataSource = LoadROOM();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var home = new Form2();
            home.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        // add room button
        private void Add_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insertQuery = "INSERT INTO ROOM(ROOM_ID, NAME, DESCRIPTION) VALUES(@id, @name, @desc)";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@id", rID_txt.Text);
            cmd.Parameters.AddWithValue("@name", rName_txt.Text);
            cmd.Parameters.AddWithValue("@desc", rDesc_txt.Text);
            cmd.ExecuteNonQuery();
            rID_txt.Text = "";
            rName_txt.Text = "";
            rDesc_txt.Text = "";
            conn.Close();
            dataGridView1.DataSource = LoadROOM();
        }
        //update room button
        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insertQuery = "UPDATE ROOM SET ROOM_ID=@id, NAME=@name, DESCRIPTION=@desc";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@id", rID_txt.Text);
            cmd.Parameters.AddWithValue("@name", rName_txt.Text);
            cmd.Parameters.AddWithValue("@desc", rDesc_txt.Text);
            cmd.ExecuteNonQuery();
            rID_txt.Text = "";
            rName_txt.Text = "";
            rDesc_txt.Text = "";
            conn.Close();
            dataGridView1.DataSource = LoadROOM();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            rID_txt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            rName_txt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            rDesc_txt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        // delete room button
        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insertQuery = "DELETE FROM ROOM WHERE ROOM_ID=@id";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@id", rID_txt.Text);
            cmd.ExecuteNonQuery();
            rID_txt.Text = "";
            rName_txt.Text = "";
            rDesc_txt.Text = "";
            conn.Close();
            dataGridView1.DataSource = LoadROOM();
        }
    }
}
