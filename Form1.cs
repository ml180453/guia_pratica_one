namespace guia_pratica_one
{
    public partial class Form1 : Form
    {
        int x, y;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);

            var selectedIndex = listBox.SelectedIndex;

            // Generate a random un color
            Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            int size  = random.Next(60, 200);

            if (selectedIndex == 0) {
                SolidBrush brush = new SolidBrush(color);
                g.DrawEllipse(lapiz, x - 50, y - 50, size, size);
                g.FillEllipse(brush, x -50, y -50, size, size);
            } else if(selectedIndex == 1) {
                SolidBrush brush = new SolidBrush(color);
                g.DrawRectangle(lapiz, x - 50, y - 50, size, size);
                g.FillRectangle(brush, x - 50, y - 50, size, size);
            }
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            Point punto = new Point(e.X, e.Y);
            x = (int)punto.X;
            y = (int)punto.Y;

            panel.Invalidate();
        }
    }
}
