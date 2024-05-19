namespace HMSApp2
{
    partial class Form6
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            yExp_txt = new TextBox();
            nDep_txt = new TextBox();
            nName_txt = new TextBox();
            nID_txt = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            rID_txt = new TextBox();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 60);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Nurse ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 93);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 130);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 1;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 167);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 1;
            label4.Text = "Years of Experience";
            // 
            // yExp_txt
            // 
            yExp_txt.Location = new Point(239, 164);
            yExp_txt.Name = "yExp_txt";
            yExp_txt.Size = new Size(153, 27);
            yExp_txt.TabIndex = 2;
            // 
            // nDep_txt
            // 
            nDep_txt.Location = new Point(239, 127);
            nDep_txt.Name = "nDep_txt";
            nDep_txt.Size = new Size(153, 27);
            nDep_txt.TabIndex = 2;
            // 
            // nName_txt
            // 
            nName_txt.Location = new Point(239, 90);
            nName_txt.Name = "nName_txt";
            nName_txt.Size = new Size(153, 27);
            nName_txt.TabIndex = 2;
            // 
            // nID_txt
            // 
            nID_txt.Location = new Point(239, 57);
            nID_txt.Name = "nID_txt";
            nID_txt.Size = new Size(153, 27);
            nID_txt.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 236);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(428, 238);
            dataGridView1.TabIndex = 3;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // button2
            // 
            button2.Location = new Point(458, 236);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(458, 296);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(458, 364);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 200);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 1;
            label5.Text = "Room ID";
            // 
            // rID_txt
            // 
            rID_txt.Location = new Point(239, 197);
            rID_txt.Name = "rID_txt";
            rID_txt.Size = new Size(153, 27);
            rID_txt.TabIndex = 7;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 483);
            Controls.Add(rID_txt);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(nID_txt);
            Controls.Add(nName_txt);
            Controls.Add(nDep_txt);
            Controls.Add(yExp_txt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form6";
            Text = "Nurse Page";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox yExp_txt;
        private TextBox nDep_txt;
        private TextBox nName_txt;
        private TextBox nID_txt;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label5;
        private TextBox rID_txt;
    }
}