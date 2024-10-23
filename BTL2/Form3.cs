namespace BTL2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            cus();
            hide();
        }

        private void cus()
        {
            panelTT.Visible = false;
            panelSP.Visible = false;
            panelNU.Visible = false;
        }

        private void hide()
        {
            panelTT.Visible = false;
            panelSP.Visible = false;
            panelNU.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hide();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void showPanel(Panel panel)
        {
            hide();
            panel.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hide();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {

            showSubMenu(panelTT);

        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSP);
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            showSubMenu(panelNU);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Optional logic for button13
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Optional logic for button14
        }
    }
}
