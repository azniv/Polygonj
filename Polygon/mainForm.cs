using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polygon
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        PointF center;
        Graphics g;
        Pen pen;
        int count = 2;
        private void mainForm_MouseClick(object sender, MouseEventArgs e)
        {
        
            g = CreateGraphics();
            pen = new Pen(Color.Black, 2);
            count++;
            if(count == 3)
            {
                center = e.Location;
            }
        
            DrawRegularPolygon(center, count, 300, g);


        }
        private static void DrawRegularPolygon(PointF center, // Координаты центра окружности
               int vertices, // Количество вершин
               float r, // Радиус
               Graphics graphics)
        {
            var angle = Math.PI * 2 / vertices;

            var points = Enumerable.Range(0, vertices)
                  .Select(i => PointF.Add(center, new SizeF((float)Math.Sin(i * angle) * r, (float)Math.Cos(i * angle) * r)));
            graphics.Clear(Color.White);
            graphics.DrawPolygon(Pens.Black, points.ToArray());
         //   graphics.DrawEllipse(Pens.Aqua, new RectangleF(PointF.Subtract(center, new SizeF(r, r)), new SizeF(r * 2, r * 2)));
        }
    }
}
