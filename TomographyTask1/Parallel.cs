using System;
using System.Collections.Generic;
using System.Drawing;

namespace TomographyTask1
{
    class Parallel
    {
        private ScanLine scanline = new ScanLine();
        public int N { get; set; } //Количество датчиков 
        public int h { get; set; } //Расстояние между соседними датчиками   
        public int R { get; set; } // Радиус зоны сканирования 
        public int M { get; set; } // Количество ракурсов 
        
        public Point StartPoint { get; set; } //точка для отрисовки центра круга 


        public void DrawLines(Graphics graphics)
        {
            int n = (N - 1) / 2;
            for (int m = 0; m < M; m++)
            {
                double alpha = GetFm(m);
                for (int k = -n; k <= n; k++)
                {
                    double Discr = Math.Pow(2 * k * h * Math.Sin(alpha), 2) - 4 * (Math.Pow(k * h, 2) - R * R * Math.Cos(alpha) * Math.Cos(alpha));
                    double x1 = (-(2 * Math.Sin(alpha) * k * h) + Math.Sqrt(Discr)) / 2;
                    double x2 = (-(2 * Math.Sin(alpha) * k * h) - Math.Sqrt(Discr)) / 2;
                    double y1 = (k * h + x1 * Math.Sin(alpha)) / Math.Cos(alpha);
                    double y2 = (k * h + x2 * Math.Sin(alpha)) / Math.Cos(alpha);
                    if (M % 2 == 0)
                    {
                        scanline.DrawScanLine(graphics, new PointF((float)x1 + StartPoint.X, (float)y1 + StartPoint.Y), new PointF((float)x2 + StartPoint.X, (float)y2 + StartPoint.Y), 10);
                        scanline.DrawScanLine(graphics, new PointF((float)y1 + StartPoint.Y, (float)x1 + StartPoint.X), new PointF((float)y2 + StartPoint.Y, (float)x2 + StartPoint.X), 10);
                    }
                    else
                        scanline.DrawScanLine(graphics, new PointF((float)x1 + StartPoint.X, (float)y1 + StartPoint.Y), new PointF((float)x2 + StartPoint.X, (float)y2 + StartPoint.Y), 10);
                }
            }
        }

        private double GetFm(int m)
        {
            return Math.PI * m / M; //Угол alpha
        }
    }
}
