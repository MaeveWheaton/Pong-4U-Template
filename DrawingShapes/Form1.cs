using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingShapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Point point1 = new Point(50, 40);
            Point point2 = new Point(140, 100);
            Point point3 = new Point(90, 250);

            Point[] triangle = { point1, point2, point3 };

            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black);
            Brush fillBrush = new SolidBrush(Color.Red);

            formGraphics.DrawPolygon(drawPen, triangle);
            formGraphics.FillPolygon(fillBrush, triangle);
            //formGraphics.DrawLine(drawPen, point1, point2);
            //formGraphics.DrawLine(drawPen, point2, point3);
            //formGraphics.DrawLine(drawPen, point3, point1);
        }
    }
}
