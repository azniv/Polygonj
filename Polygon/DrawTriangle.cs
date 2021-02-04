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
    public class DrawTriangle : Form
    {
        Graphics g;
        Pen pen;
        public DrawTriangle()
        {
            g = CreateGraphics();
            
        }

        public DrawTriangle(PointF center)
        {
            pen = new Pen(Color.Black, 2);
            var point1 = PointF.Add(center, new SizeF()) ;
          //  g.DrawPolygon();
        }
        //Pen pen;
        //Graphics g;
        //public DrawTriangle()
        //{

        //}
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    pen = new Pen(Color.Black, 2);

        //}
        //public void Delete()
        //{

        //}
    }
}
