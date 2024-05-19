namespace HMSApp2
{
    partial class Form5
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            apID_txt = new TextBox();
            pID_txt = new TextBox();
            dID_txt = new TextBox();
            label4 = new Label();
            apDate_txt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            search_txt = new TextBox();
            reason_txt = new TextBox();
            add_btn = new Button();
            update_btn = new Button();
            delete_btn = new Button();
            search_btn = new Button();
            label7 = new Label();
            label8 = new Label();
            searchP_txt = new TextBox();
            searchDate_txt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(758, 276);
            dataGridView1.TabIndex = 23;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 54);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 24;
            label1.Text = "Appointment ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 87);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 24;
            label2.Text = "Patient ID";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 119);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 24;
            label3.Text = "Doctor ID";
            label3.Click += label1_Click;
            // 
            // apID_txt
            // 
            apID_txt.Location = new Point(153, 51);
            apID_txt.Name = "apID_txt";
            apID_txt.Size = new Size(177, 27);
            apID_txt.TabIndex = 25;
            // 
            // pID_txt
            // 
            pID_txt.Location = new Point(153, 84);
            pID_txt.Name = "pID_txt";
            pID_txt.Size = new Size(177, 27);
            pID_txt.TabIndex = 25;
            // 
            // dID_txt
            // 
            dID_txt.Location = new Point(153, 116);
            dID_txt.Name = "dID_txt";
            dID_txt.Size = new Size(177, 27);
            dID_txt.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(336, 54);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 24;
            label4.Text = "Appointment Date";
            label4.Click += label1_Click;
            // 
            // apDate_txt
            // 
            apDate_txt.Location = new Point(484, 51);
            apDate_txt.Name = "apDate_txt";
            apDate_txt.Size = new Size(125, 27);
            apDate_txt.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 87);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 28;
            label5.Text = "Reason To Visit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(615, 54);
            label6.Name = "label6";
            label6.Size = new Size(142, 20);
            label6.TabIndex = 24;
            label6.Text = "Search By Doctor ID";
            label6.Click += label1_Click;
            // 
            // search_txt
            // 
            search_txt.Location = new Point(763, 51);
            search_txt.Name = "search_txt";
            search_txt.Size = new Size(125, 27);
            search_txt.TabIndex = 29;
            // 
            // reason_txt
            // 
            reason_txt.Location = new Point(484, 84);
            reason_txt.Name = "reason_txt";
            reason_txt.Size = new Size(125, 27);
            reason_txt.TabIndex = 30;
            // 
            // add_btn
            // 
            add_btn.Location = new Point(795, 208);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(94, 29);
            add_btn.TabIndex = 31;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // update_btn
            // 
            update_btn.Location = new Point(795, 258);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(94, 29);
            update_btn.TabIndex = 32;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(795, 309);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(94, 29);
            delete_btn.TabIndex = 33;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // search_btn
            // 
            search_btn.Location = new Point(795, 162);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(94, 27);
            search_btn.TabIndex = 34;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(615, 87);
            label7.Name = "label7";
            label7.Size = new Size(141, 20);
            label7.TabIndex = 24;
            label7.Text = "Search By Patient ID";
            label7.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(615, 119);
            label8.Name = "label8";
            label8.Size = new Size(109, 20);
            label8.TabIndex = 24;
            label8.Text = "Search By Date";
            label8.Click += label1_Click;
            // 
            // searchP_txt
            // 
            searchP_txt.Location = new Point(764, 84);
            searchP_txt.Name = "searchP_txt";
            searchP_txt.Size = new Size(125, 27);
            searchP_txt.TabIndex = 29;
            // 
            // searchDate_txt
            // 
            searchDate_txt.Location = new Point(763, 116);
            searchDate_txt.Name = "searchDate_txt";
            searchDate_txt.Size = new Size(125, 27);
            searchDate_txt.TabIndex = 29;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 450);
            Controls.Add(search_btn);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(add_btn);
            Controls.Add(reason_txt);
            Controls.Add(searchDate_txt);
            Controls.Add(searchP_txt);
            Controls.Add(search_txt);
            Controls.Add(label5);
            Controls.Add(apDate_txt);
            Controls.Add(dID_txt);
            Controls.Add(pID_txt);
            Controls.Add(apID_txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form5";
            Text = "Appointment Page";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox apID_txt;
        private TextBox pID_txt;
        private TextBox dID_txt;
        private Label label4;
        private TextBox apDate_txt;
        private Label label5;
        private Label label6;
        private TextBox search_txt;
        private TextBox reason_txt;
        private Button add_btn;
        private Button update_btn;
        private Button delete_btn;
        private Button search_btn;
        private Label label7;
        private Label label8;
        private TextBox searchP_txt;
        private TextBox searchDate_txt;
    }
}