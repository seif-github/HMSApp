﻿using System;
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
        public static Form2 instance;
        public Label lab1;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            lab1 = test_label;
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        // Add Nurse
        private void button2_Click(object sender, EventArgs e)
        {
            var nurse = new Form6();
            nurse.Show();
            this.Hide();
        }
        // Add Room
        private void button3_Click(object sender, EventArgs e)
        {
            var room = new Form7();
            room.Show();
            this.Hide();
        }
    }
}
