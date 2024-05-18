using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMSApp2
{
    public partial class Form3 : Form
    {


        SqlConnection conn = new SqlConnection("Data Source=SEIF;Initial Catalog=HMSDB5;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public DataTable LoadDOCTOR()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM DOCTOR";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable LoadMEDICATION()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM MEDICATION as M INNER JOIN TAKES as T On M.MEDICATION_ID=T.MEDICATION_ID INNER JOIN PATIENT as P On T.PATIENT_ID=P.PATIENT_ID";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
        public Form3()
        {
            InitializeComponent();
            dataGridView1.DataSource = LoadDOCTOR();
            dataGridView2.DataSource = LoadMEDICATION();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var home = new Form2();
            home.Show();
            this.Hide();
        }
        //doctor Add button
        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insertQuery = "INSERT INTO DOCTOR(NAME, SPECIALTY, DEPARTMENT, YEARSOFEXPERIENCE) VALUES(@name, @special, @dep, @yexp)";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@name", dName_txt.Text);
            cmd.Parameters.AddWithValue("@special", special_txt.Text);
            cmd.Parameters.AddWithValue("@dep", textBox1.Text);
            cmd.Parameters.AddWithValue("@yexp", yExp_txt.Text);
            cmd.ExecuteNonQuery();
            dName_txt.Text = "";
            special_txt.Text = "";
            textBox1.Text = "";
            yExp_txt.Text = "";
            conn.Close();
            dataGridView1.DataSource = LoadDOCTOR();

        }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        //doctor Update Button
        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            string updateQuery = "UPDATE DOCTOR SET NAME=@name, SPECIALTY=@special, DEPARTMENT=@dep, YEARSOFEXPERIENCE=@yexp WHERE DOCTOR_ID=@id";
            SqlCommand cmd = new SqlCommand(updateQuery, conn);
            cmd.Parameters.AddWithValue("@name", dName_txt.Text);
            cmd.Parameters.AddWithValue("@special", special_txt.Text);
            cmd.Parameters.AddWithValue("@dep", textBox1.Text);
            cmd.Parameters.AddWithValue("@yexp", yExp_txt.Text);
            cmd.Parameters.AddWithValue("@id", dID_txt.Text);
            cmd.ExecuteNonQuery();
            dID_txt.Text = "";
            dName_txt.Text = "";
            special_txt.Text = "";
            textBox1.Text = "";
            yExp_txt.Text = "";
            conn.Close();
            dataGridView1.DataSource = LoadDOCTOR();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            dID_txt.Text = row.Cells[0].Value.ToString();
            dName_txt.Text = row.Cells[1].Value.ToString();
            special_txt.Text = row.Cells[2].Value.ToString();
            textBox1.Text = row.Cells[3].Value.ToString();
            yExp_txt.Text = row.Cells[4].Value.ToString();
        }
        //doctor Delete Button
        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            string updateQuery = "DELETE FROM DOCTOR WHERE DOCTOR_ID=@id";
            SqlCommand cmd = new SqlCommand(updateQuery, conn);
            cmd.Parameters.AddWithValue("@id", dID_txt.Text);
            cmd.ExecuteNonQuery();
            dID_txt.Text = "";
            dName_txt.Text = "";
            special_txt.Text = "";
            textBox1.Text = "";
            yExp_txt.Text = "";
            conn.Close();
            dataGridView1.DataSource = LoadDOCTOR();
        }

        private void textBox4_TextChanged(object sender, EventArgs e) { }
        // Medication add button
        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insertQuery = "INSERT INTO MEDICATION(MEDICATION_ID, NAME, DOSAGE, DESCRIPTION) VALUES(@id, @name, @dosage, @desc) INSERT INTO TAKES(MEDICATION_ID, PATIENT_ID) VALUES(@id, @pid)";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@name", medName_txt.Text);
            cmd.Parameters.AddWithValue("@dosage", dosage_txt.Text);
            cmd.Parameters.AddWithValue("@desc", desc_txt.Text);
            cmd.Parameters.AddWithValue("@id", medID_txt.Text);
            cmd.Parameters.AddWithValue("@pid", pID_txt.Text);
            cmd.ExecuteNonQuery();
            pID_txt.Text = "";
            medID_txt.Text = "";
            medName_txt.Text = "";
            dosage_txt.Text = "";
            desc_txt.Text = "";
            conn.Close();
            dataGridView2.DataSource = LoadMEDICATION();
        }
        //medication Update button
        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insertQuery = "UPDATE MEDICATION SET NAME=@name, DOSAGE=@dosage, DESCRIPTION=@desc WHERE MEDICATION_ID=@id";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@name", medName_txt.Text);
            cmd.Parameters.AddWithValue("@dosage", dosage_txt.Text);
            cmd.Parameters.AddWithValue("@desc", desc_txt.Text);
            cmd.Parameters.AddWithValue("@id", medID_txt.Text);
            cmd.ExecuteNonQuery();
            medID_txt.Text = "";
            medName_txt.Text = "";
            dosage_txt.Text = "";
            desc_txt.Text = "";
            conn.Close();
            dataGridView2.DataSource = LoadMEDICATION();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            medID_txt.Text = row.Cells[0].Value.ToString();
            medName_txt.Text = row.Cells[1].Value.ToString();
            dosage_txt.Text = row.Cells[2].Value.ToString();
            desc_txt.Text = row.Cells[3].Value.ToString();
        }

        private void label10_Click(object sender, EventArgs e) { }
        //medicaion delete button
        private void button7_Click(object sender, EventArgs e)
        {
            conn.Open();
            string updateQuery = "DELETE FROM MEDICATION WHERE MEDICATION_ID=@id";
            SqlCommand cmd = new SqlCommand(updateQuery, conn);
            cmd.Parameters.AddWithValue("@id", medID_txt.Text);
            cmd.ExecuteNonQuery();
            medID_txt.Text = "";
            medName_txt.Text = "";
            dosage_txt.Text = "";
            desc_txt.Text = "";
            conn.Close();
            dataGridView2.DataSource = LoadMEDICATION();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
