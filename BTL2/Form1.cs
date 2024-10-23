namespace BTL2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 fo2 = new Form2();
            fo2.Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fm3= new Form3(); 
            fm3.Show(); 

        }
    }
}
