using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ritbooook
{
    public partial class Form1 : Form
    {

        private NumericUpDown sizeSelector;
        private NumericUpDown sizeSelector2;

        public Form1()
        {
            InitializeComponent();
            this.Width = 950;
            this.Height = 700;
            bm = new Bitmap(bild.Width, bild.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            bild.Image = bm;



            p = new Pen(Color.Black, 1);
            erase = new Pen(Color.White, 10);


            sizeSelector = new NumericUpDown();
            sizeSelector.Minimum = 1;
            sizeSelector.Maximum = 10;
            sizeSelector.Value = 5;
            sizeSelector.Location = new Point(10, 10);
            Controls.Add(sizeSelector);

            sizeSelector2 = new NumericUpDown();
            sizeSelector2.Minimum = 1;
            sizeSelector2.Maximum = 10;
            sizeSelector2.Value = 1;
            sizeSelector2.Location = new Point(10, 10);
            Controls.Add(sizeSelector2);
        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, Cy;

        ColorDialog cd = new ColorDialog();
        Color new_color;

        private void btn_cirkel_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_rekt_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btn_linje_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void bild_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, Cy, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, Cy, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, Cy, x, y);
                }
            }
        }

        private void btn_rensa_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            bild.Image = bm;
            index = 0;
        }

        private void btn_färg_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            val_färg.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void färg_väjare_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(färg_väjare, e.Location);
            val_färg.BackColor = ((Bitmap)färg_väjare.Image).GetPixel(point.X, point.Y);
            new_color = val_färg.BackColor;
            p.Color = val_färg.BackColor;

        }

        private void bild_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            Cy = e.Y;

        }

        private void bild_MouseMove(object sender, MouseEventArgs e)
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
            bild.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - Cy;

        }

        private void bild_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point point = set_point(bild, e.Location);
                Fill(bm, point.X, point.Y, new_color);

            }
        }

        private void btn_fylla_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void size_Click(object sender, EventArgs e)
        {
            // Set the pen's width based on the selected value
            p.Width = (int)sizeSelector.Value;
            MessageBox.Show($"Pen size changed to {p.Width}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Set the pen's width based on the selected value
            p.Width = (int)sizeSelector2.Value;
            MessageBox.Show($"Pen size changed to {p.Width}");
        }

        private void bild_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - Cy;

            if (index == 3)
            {
                g.DrawEllipse(p, cX, Cy, sX, sY);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, cX, Cy, sX, sY);
            }
            if (index == 5)
            {
                g.DrawLine(p, cX, Cy, x, y);
            }

        }

        private void btn_penna_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btn_Sudd_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void bild_Click(object sender, EventArgs e)
        {

        }

        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);

            }
        }

        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_color == new_clr) return;

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_clr);
                    validate(bm, pixel, pt.X + 1, pt.Y - 1, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_clr);

                }

            }

        }
    }
}
