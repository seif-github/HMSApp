namespace HMSApp2
{
    partial class Form2
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
            doctor_btn = new Button();
            patient_btn = new Button();
            app_btn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // doctor_btn
            // 
            doctor_btn.Location = new Point(300, 22);
            doctor_btn.Name = "doctor_btn";
            doctor_btn.Size = new Size(123, 86);
            doctor_btn.TabIndex = 0;
            doctor_btn.Text = "Doctor";
            doctor_btn.UseVisualStyleBackColor = true;
            doctor_btn.Click += doctor_btn_Click;
            // 
            // patient_btn
            // 
            patient_btn.Location = new Point(300, 130);
            patient_btn.Name = "patient_btn";
            patient_btn.Size = new Size(123, 86);
            patient_btn.TabIndex = 0;
            patient_btn.Text = "Patient";
            patient_btn.UseVisualStyleBackColor = true;
            patient_btn.Click += patient_btn_Click;
            // 
            // app_btn
            // 
            app_btn.Location = new Point(300, 242);
            app_btn.Name = "app_btn";
            app_btn.Size = new Size(123, 86);
            app_btn.TabIndex = 0;
            app_btn.Text = "Appointment";
            app_btn.UseVisualStyleBackColor = true;
            app_btn.Click += app_btn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(300, 390);
            button1.Name = "button1";
            button1.Size = new Size(123, 29);
            button1.TabIndex = 1;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(app_btn);
            Controls.Add(patient_btn);
            Controls.Add(doctor_btn);
            Name = "Form2";
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private Button doctor_btn;
        private Button patient_btn;
        private Button app_btn;
        private Button button1;
    }
}