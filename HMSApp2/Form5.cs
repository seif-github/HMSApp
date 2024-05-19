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

        private void Form5_Load(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }
        // appointment add button
        private void add_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insertQuery = "INSERT INTO APPOINTMENT(APPOINTMENT_ID, PATIENT_ID, DOCTOR_ID, APPOINTMENTDATE , REASONFORVISIT) VALUES(@id, @pid, @did, @apDate , @reason)";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@id", apID_txt.Text);
            cmd.Parameters.AddWithValue("@pid", pID_txt.Text);
            cmd.Parameters.AddWithValue("@did", dID_txt.Text);
            cmd.Parameters.AddWithValue("@apDate", apDate_txt.Text);
            cmd.Parameters.AddWithValue("@reason", reason_txt.Text);
            cmd.ExecuteNonQuery();
            apID_txt.Text = "";
            pID_txt.Text = "";
            dID_txt.Text = "";
            apDate_txt.Text = "";
            reason_txt.Text = "";
            conn.Close();
            dataGridView1.DataSource = LoadAPPOINTMENT();
        }
        // appointment update button
        private void update_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insertQuery = "UPDATE APPOINTMENT SET APPOINTMENT_ID=@id, PATIENT_ID=@pid, DOCTOR_ID=@did, APPOINTMENTDATE=@apDate, REASONFORVISIT=@reason WHERE APPOINTMENT_ID=@id";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@id", apID_txt.Text);
            cmd.Parameters.AddWithValue("@pid", pID_txt.Text);
            cmd.Parameters.AddWithValue("@did", dID_txt.Text);
            cmd.Parameters.AddWithValue("@apDate", apDate_txt.Text);
            cmd.Parameters.AddWithValue("@reason", reason_txt.Text);
            cmd.ExecuteNonQuery();
            apID_txt.Text = "";
            pID_txt.Text = "";
            dID_txt.Text = "";
            apDate_txt.Text = "";
            reason_txt.Text = "";
            conn.Close();
            dataGridView1.DataSource = LoadAPPOINTMENT();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            apID_txt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            pID_txt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dID_txt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            apDate_txt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            reason_txt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }
        // appointment delete button
        private void delete_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insertQuery = "DELETE FROM APPOINTMENT WHERE APPOINTMENT_ID=@id";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@id", apID_txt.Text);
            cmd.ExecuteNonQuery();
            apID_txt.Text = "";
            pID_txt.Text = "";
            dID_txt.Text = "";
            apDate_txt.Text = "";
            reason_txt.Text = "";
            conn.Close();
            dataGridView1.DataSource = LoadAPPOINTMENT();
        }
        // Appointment search by doctor id button
        private void search_btn_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //string query = "SELECT * FROM APPOINTMENT WHERE DOCTOR_ID="+search_txt.Text+"";
            //conn.Open();
            //SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //sda.Fill(dt);
            //conn.Close();
            //search_txt.Text = "";
            //dataGridView1.DataSource = dt;
            DataTable dt = new DataTable();
            string query = "SELECT * FROM APPOINTMENT";


            if (!string.IsNullOrEmpty(search_txt.Text))
            {
                query += " WHERE DOCTOR_ID = " + search_txt.Text;
            }


            if (!string.IsNullOrEmpty(searchDate_txt.Text))
            {
                query += " AND APPOINTMENTDATE = '" + searchDate_txt.Text + "'";
            }


            if (!string.IsNullOrEmpty(searchP_txt.Text))
            {
                query += " AND PATIENT_ID = " + searchP_txt.Text;
            }

            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            conn.Close();            

            dataGridView1.DataSource = dt;
        }
    }
}
