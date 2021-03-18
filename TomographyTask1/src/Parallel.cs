using System;
using System.Drawing;

namespace TomographyTask1.src
{
    class Parallel
    {
        private ScanLine scanline = new ScanLine(); 
        double I { get; set; } //Интенсивность 
        double I0{ get; set; } //Начальная интенсивность 
        double N { get; set; } //Количество датчиков 
        int n { get; set; } //Расстояние между соседними датчиками   
        int k { get; set; } // Номер дачика 
        int R { get; set; } // Радиус зоны сканирования 
        int M { get; set; } // Количество ракурсов 

        public void DrawLines(Graphics graphics, Point point1, Point point2)
        {
            double x1 = point1.X;
            double y1 = point1.X;
            double x2 = point2.Y;
            double y2 = point2.Y;
            for (int i = 0; i < N; i+=n)
            {
                scanline.DrawScanLine(graphics, point1, point2, 20);
                point1.X *= Math.Cos(Math.PI/2 + GetFm(i)) 
            }
           
        }

        private double GetFm(int m)
        {
            return n * m / M; //Угол alpha
        }
    }
}
