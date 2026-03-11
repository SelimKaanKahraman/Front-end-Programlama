namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double a, b, alan;
        private double dikdörtgenAlani(double kenar1, double kenar2)

        {
            return kenar1 * kenar2;
        }

        private double daireninAlani(double yaricap)
        {
            return Math.PI * yaricap * yaricap;
        }

        private void mb(String s)
        {
            MessageBox.Show(s);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            alan = dikdörtgenAlani(a, b);
            this.Text = alan.ToString();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            a = Convert.ToDouble(textBox3.Text);
            alan = daireninAlani(a);
            this.Text = alan.ToString();


        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            mb("Merhaba");

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
