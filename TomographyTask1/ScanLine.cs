using System.Drawing;

namespace TomographyTask1
{
    class ScanLine
    {
        public void DrawScanLine(Graphics graphics, PointF point1, PointF point2, int heighs)
        {
            graphics.DrawRectangle(new Pen(Color.Black), point1.X, point1.Y, heighs, heighs);
            graphics.DrawLine(new Pen(Color.Black), point1, point2); 
        }

        public void DrawScanLine(Graphics graphics, float x1, float y1, float x2, float y2, int heighs)
        {
            graphics.DrawRectangle(new Pen(Color.Black), x1, y1, heighs, heighs);
            graphics.DrawLine(new Pen(Color.Black), x1, y1, x2, y2);
        }
        
     
    }
}
