using System.Drawing;

namespace TomographyTask1.src
{
    class ScanLine
    {
        public void DrawScanLine(Graphics graphics, Point point1, Point point2, int heighs)
        {
            graphics.DrawRectangle(new Pen(Color.Black), point1.X, point1.Y, heighs, heighs);
            graphics.DrawLine(new Pen(Color.Black), point1, point2); 
        }

        public void DrawScanLine(Graphics graphics, double x1, double y1, double x2, double y2,int heighs)
        {
            graphics.DrawRectangle(new Pen(Color.Black), (float)x1, (float)y1, heighs, heighs);
            graphics.DrawLine(new Pen(Color.Black), (float)x1, (float)y1, (float)x2, (float)y2);
        }
    }
}
