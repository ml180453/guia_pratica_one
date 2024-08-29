namespace guia_pratica_one
{
    public partial class Form1 : Form
    {
        int x, y;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);

            var selectedIndex = listBox.SelectedIndex;

            if (selectedIndex == 0) {
                SolidBrush brush = new SolidBrush(Color.Red);
                g.DrawEllipse(lapiz, x - 50, y - 50, 100, 100);
                g.FillEllipse(brush, x -50, y -50, 100, 100);
            } else if(selectedIndex == 1) {
                SolidBrush brush = new SolidBrush(Color.Green);
                g.DrawRectangle(lapiz, x - 50, y - 50, 100, 100);
                g.FillRectangle(brush, x - 50, y - 50, 100, 100);
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
