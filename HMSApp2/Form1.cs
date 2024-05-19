namespace HMSApp2
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password_txt.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (username_txt.Text == "" || password_txt.Text == "")
            {
                MessageBox.Show("Please enter data", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var register = new Form2();
                Form2.instance.lab1.Text = username_txt.Text;
                register.Show();
                this.Hide();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
