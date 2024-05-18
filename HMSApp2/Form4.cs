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
    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"HMS - Project\";Integrated Security=True");

        public DataTable LoadPatient()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM PATIENT";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            conn.Close();
            return dt;
        }


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



        public Form4()
        {
            InitializeComponent();
            InitializeComponent();
            dataGridView1.DataSource = LoadPatient();
            //dataGridView2.DataSource = LoadAPPOINTMENT();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var home = new Form2();
            home.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        //Patient Add button

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insertQuery = "INSERT INTO PATIENT( NAME, ADDRESS , PHONENUMBER , EMERGENCYCONTACTNAME , EMERGENCYCONTACTPHONE , INSURANCEINFORMATION ) VALUES( @name, @address , @phonenumber , @emergencycontactname , @emergencycontactphone  , @insuranceinformation  )";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);

            //cmd.Parameters.AddWithValue("@id", pID_txt.Text);
            cmd.Parameters.AddWithValue("@name", name_txt.Text);
           // cmd.Parameters.AddWithValue("@dateofbirth", birth_txt.Text);
            cmd.Parameters.AddWithValue("@address", add_txt.Text);
            cmd.Parameters.AddWithValue("@phonenumber", phone_txt.Text);
            cmd.Parameters.AddWithValue("@emergencycontactname", cname_txt.Text);
            cmd.Parameters.AddWithValue("@emergencycontactphone", cphone_txt.Text);
            cmd.Parameters.AddWithValue("@insuranceinformation", info_txt.Text);

            cmd.ExecuteNonQuery();
            //pID_txt.Text = "";
            name_txt.Text = "";
           // birth_txt.Text = "";
            add_txt.Text = "";
            phone_txt.Text = "";
            cname_txt.Text = "";
            cphone_txt.Text = "";
            info_txt.Text = "";
            conn.Close();
            dataGridView1.DataSource = LoadPatient();
        }


        //Patient Update Button

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            string updateQuery = "UPDATE PATIENT SET PATIENT_ID=@id , NAME=@name,  DATEOFBIRTH=@birthdate, ADDRESS=@address , PHONENUMBER=@phonenumber ,EMERGENCYCONTACTNAME=@emergencycontactname ,EMERGENCYCONTACTPHONE=@emergencycontactphone , INSURANCEINFORMATION=@insuranceinformation ,    WHERE PATIENT_ID=@id";
            SqlCommand cmd = new SqlCommand(updateQuery, conn);
            cmd.Parameters.AddWithValue("@id", pID_txt.Text);
            cmd.Parameters.AddWithValue("@name", name_txt.Text);
            cmd.Parameters.AddWithValue("@dateofbirth", birth_txt.Text);
            cmd.Parameters.AddWithValue("@address", add_txt.Text);
            cmd.Parameters.AddWithValue("@phonenumber", phone_txt.Text);
            cmd.Parameters.AddWithValue("@emergencycontactname", cname_txt.Text);
            cmd.Parameters.AddWithValue("@emergencycontactphone", cphone_txt.Text);
            cmd.Parameters.AddWithValue("@insuranceinformation", info_txt.Text);
            cmd.ExecuteNonQuery();
            pID_txt.Text = "";
            name_txt.Text = "";
            birth_txt.Text = "";
            add_txt.Text = "";
            phone_txt.Text = "";
            cname_txt.Text = "";
            cphone_txt.Text = "";
            info_txt.Text = "";
            conn.Close();
            dataGridView1.DataSource = LoadPatient();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            pID_txt.Text = row.Cells[0].Value.ToString();
            name_txt.Text = row.Cells[1].Value.ToString();
            birth_txt.Text = row.Cells[2].Value.ToString();
            add_txt.Text = row.Cells[3].Value.ToString();
            phone_txt.Text = row.Cells[4].Value.ToString();
            cname_txt.Text = row.Cells[5].Value.ToString();
            cphone_txt.Text = row.Cells[6].Value.ToString();
            info_txt.Text = row.Cells[7].Value.ToString();
        }

        //Patient Delete Button

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            string updateQuery = "DELETE FROM PATIENT WHERE PATIENT_ID=@id";
            SqlCommand cmd = new SqlCommand(updateQuery, conn);
            cmd.Parameters.AddWithValue("@id", pID_txt.Text);
            cmd.ExecuteNonQuery();
            pID_txt.Text = "";
            name_txt.Text = "";
            birth_txt.Text = "";
            add_txt.Text = "";
            phone_txt.Text = "";
            cname_txt.Text = "";
            cphone_txt.Text = "";
            info_txt.Text = "";
            conn.Close();
            dataGridView1.DataSource = LoadPatient();
        }

        



    }
}
