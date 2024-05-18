namespace HMSApp2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label1 = new Label();
            dName_txt = new TextBox();
            label2 = new Label();
            special_txt = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            yExp_txt = new TextBox();
            button3 = new Button();
            label5 = new Label();
            dID_txt = new TextBox();
            button4 = new Button();
            panel1 = new Panel();
            dataGridView2 = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            medName_txt = new TextBox();
            dosage_txt = new TextBox();
            label8 = new Label();
            desc_txt = new RichTextBox();
            label9 = new Label();
            pID_txt = new TextBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label10 = new Label();
            medID_txt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(492, 269);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(510, 169);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 4;
            label1.Text = "Doctor Name";
            // 
            // dName_txt
            // 
            dName_txt.Location = new Point(117, 51);
            dName_txt.Name = "dName_txt";
            dName_txt.Size = new Size(162, 27);
            dName_txt.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Speciality";
            // 
            // special_txt
            // 
            special_txt.Location = new Point(117, 87);
            special_txt.Name = "special_txt";
            special_txt.Size = new Size(162, 27);
            special_txt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 54);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 4;
            label3.Text = "Department";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(442, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 90);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 4;
            label4.Text = "Years of Experience";
            // 
            // yExp_txt
            // 
            yExp_txt.Location = new Point(445, 87);
            yExp_txt.Name = "yExp_txt";
            yExp_txt.Size = new Size(162, 27);
            yExp_txt.TabIndex = 5;
            yExp_txt.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(510, 227);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 6;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 21);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 4;
            label5.Text = "Doctor ID";
            // 
            // dID_txt
            // 
            dID_txt.Location = new Point(197, 18);
            dID_txt.Name = "dID_txt";
            dID_txt.Size = new Size(82, 27);
            dID_txt.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(510, 286);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 8;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Location = new Point(613, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 465);
            panel1.TabIndex = 9;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(629, 169);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(484, 269);
            dataGridView2.TabIndex = 10;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(629, 54);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 4;
            label6.Text = "Medication Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(629, 87);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 4;
            label7.Text = "Dosage";
            // 
            // medName_txt
            // 
            medName_txt.Location = new Point(763, 51);
            medName_txt.Name = "medName_txt";
            medName_txt.Size = new Size(125, 27);
            medName_txt.TabIndex = 11;
            // 
            // dosage_txt
            // 
            dosage_txt.Location = new Point(763, 84);
            dosage_txt.Name = "dosage_txt";
            dosage_txt.Size = new Size(125, 27);
            dosage_txt.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(894, 54);
            label8.Name = "label8";
            label8.Size = new Size(164, 20);
            label8.TabIndex = 4;
            label8.Text = "Medication Description";
            // 
            // desc_txt
            // 
            desc_txt.Location = new Point(1064, 51);
            desc_txt.Name = "desc_txt";
            desc_txt.Size = new Size(160, 93);
            desc_txt.TabIndex = 13;
            desc_txt.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(629, 120);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 4;
            label9.Text = "Patient ID";
            // 
            // pID_txt
            // 
            pID_txt.Location = new Point(763, 117);
            pID_txt.Name = "pID_txt";
            pID_txt.Size = new Size(125, 27);
            pID_txt.TabIndex = 14;
            // 
            // button5
            // 
            button5.Location = new Point(1130, 169);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 15;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1130, 227);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 16;
            button6.Text = "Update";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(1130, 286);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 17;
            button7.Text = "Delete";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(629, 21);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 4;
            label10.Text = "Medication ID";
            label10.Click += label10_Click;
            // 
            // medID_txt
            // 
            medID_txt.Location = new Point(763, 21);
            medID_txt.Name = "medID_txt";
            medID_txt.Size = new Size(125, 27);
            medID_txt.TabIndex = 18;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 466);
            Controls.Add(medID_txt);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(pID_txt);
            Controls.Add(desc_txt);
            Controls.Add(dosage_txt);
            Controls.Add(medName_txt);
            Controls.Add(dataGridView2);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(dID_txt);
            Controls.Add(button3);
            Controls.Add(special_txt);
            Controls.Add(yExp_txt);
            Controls.Add(textBox1);
            Controls.Add(dName_txt);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Doctor Page";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label1;
        private TextBox dName_txt;
        private Label label2;
        private TextBox special_txt;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox yExp_txt;
        private Button button3;
        private Label label5;
        private TextBox dID_txt;
        private Button button4;
        private Panel panel1;
        private DataGridView dataGridView2;
        private Label label6;
        private Label label7;
        private TextBox medName_txt;
        private TextBox dosage_txt;
        private Label label8;
        private RichTextBox desc_txt;
        private Label label9;
        private TextBox pID_txt;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label10;
        private TextBox medID_txt;
    }
}