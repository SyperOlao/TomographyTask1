using System;
using System.Collections.Generic;
using System.Drawing;

namespace TomographyTask1
{
    class Parallel
    {
        private ScanLine scanline = new ScanLine();
        private List<PointF> dots;

        public double I { get; set; } //Интенсивность 
        public double I0 { get; set; } //Начальная интенсивность 
        public double N { get; set; } //Количество датчиков 
        public int h { get; set; } //Расстояние между соседними датчиками   
        public int k { get; set; } // Номер дачика 
        public int R { get; set; } // Радиус зоны сканирования 
        public int M { get; set; } // Количество ракурсов 
        
        public Point StartPoint { get; set; } //точка для отрисовки центра круга 
        
      
        
        public void DrawLines(Graphics graphics)
        {
            dots = GetDots(R, R);
            graphics.DrawEllipse(new Pen(Color.Gray), StartPoint.X, StartPoint.Y, R, R);
            for (int i = 0; i < dots.Count-1; i++)
            {
                scanline.DrawScanLine(graphics, dots[i], dots[i + 1], 10);
            }
        }
       

        private List<PointF> GetDots(int height, int width)
        {
            List<PointF> dots = new List<PointF>();
            int Width = width;
            int Height = height;
            int n = (int)(N - 1) / 2;
            for (int m = 0; m < M; m++)
            {
                for (int k = -n; k <= n; k++)
                {
                    double Discr = Math.Pow(2 * k * h * Math.Sin(GetFm(m)), 2) - 4 * (Math.Pow(k * h, 2) - R * R * Math.Cos(GetFm(m) * Math.Cos(GetFm(m))));
                    double x1 = (-(2 * Math.Sin(GetFm(m)) * k * h) + Math.Sqrt(Discr)) / 2;
                    double x2 = (-(2 * Math.Sin(GetFm(m)) * k * h) - Math.Sqrt(Discr)) / 2;
                    double y1 = (k * h + x1 * Math.Sin(GetFm(m))) / Math.Cos(GetFm(m));
                    double y2 = (k * h + x2 * Math.Sin(GetFm(m))) / Math.Cos(GetFm(m));
                    dots.Add(new PointF((float)x1 + Width / 2, Height / 2 - (float)y1));
                    dots.Add(new PointF((float)x2 + Width / 2, Height / 2 - (float)y2));
                }
            }

            return dots; 
        }
        private double GetFm(int m)
        {
            return Math.PI * m / M; //Угол alpha
        }
    }
}
