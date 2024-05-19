namespace HMSApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            username_txt = new TextBox();
            password_txt = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(93, 40);
            label2.Name = "label2";
            label2.Size = new Size(589, 32);
            label2.TabIndex = 1;
            label2.Text = "Welcome to Hospital Management System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 130);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 2;
            label1.Text = "Admin Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 174);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // username_txt
            // 
            username_txt.Location = new Point(268, 127);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(295, 27);
            username_txt.TabIndex = 3;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(268, 171);
            password_txt.Name = "password_txt";
            password_txt.PasswordChar = '*';
            password_txt.Size = new Size(295, 27);
            password_txt.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(268, 222);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(333, 302);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(password_txt);
            Controls.Add(username_txt);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Sign Up";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox username_txt;
        private TextBox password_txt;
        private CheckBox checkBox1;
        private Button button1;
    }
}
