namespace PaintByAxit
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(panel1.Width, panel1.Height);
            g = Graphics.FromImage(bm);
            panel1.Image = bm; 
        }
        
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 2);
        Pen erase = new Pen(Color.White, 10);
        int index;

        ColorDialog cd = new ColorDialog();
        Color newColor;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                } 
            }
            panel1.Refresh();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = 1;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            p.Color = Color.Purple;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ColorBlack_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void ColorGray_Click(object sender, EventArgs e)
        {
            p.Color = Color.Gray;
        }

        private void ColorSilver_Click(object sender, EventArgs e)
        {
            p.Color = Color.Silver;
        }

        private void ColorRed_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            cd.ShowDialog();
            newColor = cd.Color;
    //        panel1_color.BlackColor = cd.Color;
            p.Color = cd.Color;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            panel1.Image = bm;
            index = 0;
        }

        private void ColorOrange_Click(object sender, EventArgs e)
        {
            p.Color = Color.Orange;
        }

        private void ColorYellow_Click(object sender, EventArgs e)
        {
            p.Color = Color.Yellow;
        }

        private void ColorViolet_Click(object sender, EventArgs e)
        {
            p.Color = Color.Pink;
        }

        private void ColorBlue_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void ColorBrown_Click(object sender, EventArgs e)
        {
            p.Color = Color.Brown;
        }

        private void ColorGreen_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void ColorWhite_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }

    }
}