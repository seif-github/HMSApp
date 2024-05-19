namespace HMSApp2
{
    partial class Form7
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
            rDesc_txt = new TextBox();
            rName_txt = new TextBox();
            rID_txt = new TextBox();
            Add = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
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
            label1.Location = new Point(107, 79);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 1;
            label1.Text = "Room ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 117);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 157);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 1;
            label3.Text = "Description";
            // 
            // rDesc_txt
            // 
            rDesc_txt.Location = new Point(198, 154);
            rDesc_txt.Name = "rDesc_txt";
            rDesc_txt.Size = new Size(250, 27);
            rDesc_txt.TabIndex = 2;
            // 
            // rName_txt
            // 
            rName_txt.Location = new Point(198, 114);
            rName_txt.Name = "rName_txt";
            rName_txt.Size = new Size(250, 27);
            rName_txt.TabIndex = 2;
            // 
            // rID_txt
            // 
            rID_txt.Location = new Point(198, 76);
            rID_txt.Name = "rID_txt";
            rID_txt.Size = new Size(250, 27);
            rID_txt.TabIndex = 2;
            // 
            // Add
            // 
            Add.Location = new Point(471, 75);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 3;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // button3
            // 
            button3.Location = new Point(471, 113);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(471, 153);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(107, 217);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(458, 221);
            dataGridView1.TabIndex = 6;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Add);
            Controls.Add(rID_txt);
            Controls.Add(rName_txt);
            Controls.Add(rDesc_txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form7";
            Text = "Room Page";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox rDesc_txt;
        private TextBox rName_txt;
        private TextBox rID_txt;
        private Button Add;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
    }
}