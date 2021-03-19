using System;
using System.Drawing;

namespace TomographyTask1
{
    class Fan
    {
        private ScanLine scanline = new ScanLine();
        public int N { get; set; } //Количество датчиков 
        public int h { get; set; } //Расстояние между соседними датчиками   
        public int R { get; set; } // Радиус зоны сканирования 
        public int M { get; set; } // Количество ракурсов 

        public double Delta { get; set; } //Угол наколна между прямыми 

        public Point StartPoint { get; set; } //точка для отрисовки центра круга 


        public void DrawLines(Graphics graphics)
        {
            Delta = GetAngel(Delta);

            int n = (N - 1) / 2;

            for (int m = 0; m < M; m++)
            {
                double fi = GetFm(m);
                for (int k = -n; k <= n; k++)
                {
                    double beta = Delta;
                    if (Delta * k <= Math.PI / 4)
                        beta = Delta * k;
                    double Discriminant = 4 * R * R * Math.Pow(Math.Sin(beta), 2) * Math.Pow(Math.Sin(beta + fi), 2) - 4 * R * R * (Math.Pow(Math.Sin(beta), 2) - Math.Pow(Math.Cos(beta + fi), 2));
                    double x1 = (-2 * R * Math.Sin(beta) * Math.Sin(beta + fi) + Math.Sqrt(Discriminant)) / 2;
                    double x2 = (-2 * R * Math.Sin(beta) * Math.Sin(beta + fi) - Math.Sqrt(Discriminant)) / 2;
                    double y1 = (x1 * Math.Sin(beta + fi) + R * Math.Sin(beta)) / Math.Cos(beta + fi);
                    double y2 = (x2 * Math.Sin(beta + fi) + R * Math.Sin(beta)) / Math.Cos(beta + fi);

                    scanline.DrawScanLine(graphics, new PointF((float)x1 + StartPoint.X, (float)y1 + StartPoint.Y), new PointF((float)x2 + StartPoint.X, (float)y2 + StartPoint.Y), 10);
                }
            }
        }

        private double GetFm(int m)
        {
            return 2 * Math.PI * m / M; //Угол alpha
        }
        
        private static double GetAngel(double angel)
        {
            return angel * Math.PI / 180;
        }
    }
}

