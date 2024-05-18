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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void doctor_btn_Click(object sender, EventArgs e)
        {
            var doctor = new Form3();
            doctor.Show();
            this.Hide();
        }

        private void patient_btn_Click(object sender, EventArgs e)
        {
            var patient = new Form4();
            patient.Show();
            this.Hide();
        }

        private void app_btn_Click(object sender, EventArgs e)
        {
            var app = new Form5();
            app.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var signup = new Form1();
            signup.Show();
            this.Hide();
        }
    }
}
