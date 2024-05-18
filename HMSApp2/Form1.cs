namespace HMSApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password_txt.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(username_txt.Text == "" || password_txt.Text == "")
            {
                MessageBox.Show("Please enter data", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                var register = new Form2();
                register.Show();
                this.Hide();
            }
            
        }
    }
}
