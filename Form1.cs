namespace modul3_1302210098
{
    public partial class Form1 : Form
    {
        int angka, hasil;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            angka = int.Parse(label1.Text);
            hasil += angka;
            label1.Text = "+";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void no1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text +  "1";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void no2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
        }

        private void no3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
        }

        private void no5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
        }

        private void no6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
        }

        private void no7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
        }

        private void no8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
        }

        private void no9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
        }

        private void samadengan_Click(object sender, EventArgs e)
        {
            angka = int.Parse(label1.Text);
            hasil += angka;
            label1.Text = hasil.ToString();
        }
    }
}