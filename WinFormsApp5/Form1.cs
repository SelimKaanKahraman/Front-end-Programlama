namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        int r = 50;
        int k = 1;
        int x, y;
        public Form1()



        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void daireCiz(int r, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Green, k);
            e.Graphics.DrawEllipse(p, -r, -r, 2 * r, 2 * r);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.DrawLine(Pens.Blue, 0, 0, 100, 0);
            e.Graphics.DrawLine(Pens.Blue, 0, 0, 0, 200);
            Pen p = new Pen(Color.Green, k);
            e.Graphics.DrawLine(Pens.Black, 0, 0, x, y);
            daireCiz(r, e);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void hScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            label1.Text = hScrollBar1.Value.ToString();
            r = hScrollBar1.Value;
            Invalidate();
        }

        private void hScrollBar2_Scroll_1(object sender, ScrollEventArgs e)
        {
            label2.Text = hScrollBar2.Value.ToString();
            k = hScrollBar2.Value;
            Invalidate();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            r += 1;
            k += 1;
            if (r >= 200) r = 0;
            if (k >= 20) k = 0;
            Invalidate();
        }

        private void label2_Move(object sender, EventArgs e)
        {

        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            this.Text = String.Format("x={0} y={1}", x, y);
            Invalidate();
        }
    }
}