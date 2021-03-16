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
    }
}
