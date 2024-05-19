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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMSApp2
{
    public partial class Form6 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=SEIF;Initial Catalog=HMSDB6;Integrated Security=True;TrustServerCertificate=True");
        public DataTable LoadNURSE()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM NURSE";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
        public Form6()
        {
            InitializeComponent();
            dataGridView1.DataSource = LoadNURSE();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var home = new Form2();
            home.Show();
            this.Hide();
        }
        //add nurse button
        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insertQuery = "INSERT INTO NURSE(NURSE_ID, NAME, DEPARTMENT, YEARSOFEXPERIENCE, ROOM_ID) VALUES(@id, @name, @dep, @yexp, @rid)";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@id", nID_txt.Text);
            cmd.Parameters.AddWithValue("@name", nName_txt.Text);
            cmd.Parameters.AddWithValue("@dep", nDep_txt.Text);
            cmd.Parameters.AddWithValue("@yexp", yExp_txt.Text);
            cmd.Parameters.AddWithValue("@rid", rID_txt.Text);
            cmd.ExecuteNonQuery();
            nID_txt.Text = "";
            nName_txt.Text = "";
            nDep_txt.Text = "";
            yExp_txt.Text = "";
            rID_txt.Text = "";
            conn.Close();
            dataGridView1.DataSource = LoadNURSE();
        }
        //update nurse button
        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insertQuery = "UPDATE NURSE SET NAME=@name, DEPARTMENT=@dep, YEARSOFEXPERIENCE=@yexp, ROOM_ID=@rid WHERE NURSE_ID=@id";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@id", nID_txt.Text);
            cmd.Parameters.AddWithValue("@name", nName_txt.Text);
            cmd.Parameters.AddWithValue("@dep", nDep_txt.Text);
            cmd.Parameters.AddWithValue("@yexp", yExp_txt.Text);
            cmd.Parameters.AddWithValue("@rid", rID_txt.Text);
            cmd.ExecuteNonQuery();
            nID_txt.Text = "";
            nName_txt.Text = "";
            nDep_txt.Text = "";
            yExp_txt.Text = "";
            rID_txt.Text = "";
            conn.Close();
            dataGridView1.DataSource = LoadNURSE();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            nID_txt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nName_txt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            nDep_txt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            yExp_txt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            rID_txt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }
        //Delete nurse button
        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insertQuery = "DELETE FROM NURSE WHERE NURSE_ID=@id";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@id", nID_txt.Text);
            cmd.ExecuteNonQuery();
            nID_txt.Text = "";
            nName_txt.Text = "";
            nDep_txt.Text = "";
            yExp_txt.Text = "";
            conn.Close();
            dataGridView1.DataSource = LoadNURSE();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
