using System;
using System.Drawing;

namespace TomographyTask1
{
    class Parallel
    {
        private ScanLine scanline = new ScanLine();
        
        public double I { get; set; } //Интенсивность 
        public double I0 { get; set; } //Начальная интенсивность 
        public double N { get; set; } //Количество датчиков 
        public int n { get; set; } //Расстояние между соседними датчиками   
        public int k { get; set; } // Номер дачика 
        public int R { get; set; } // Радиус зоны сканирования 
        public int M { get; set; } // Количество ракурсов 
        
        public Point StartPoint { get; set; } //точка для отрисовки центра круга 

      
        
        public void DrawLines(Graphics graphics, float x1, float y1, float x2, float y2)
        {

            graphics.DrawEllipse(new Pen(Color.Gray), StartPoint.X, StartPoint.Y, R, R);
            for (int i = 0, k = 0; i < N; k += n, i++)
            {
                //  scanline.DrawScanLine(graphics, x1 + k, y1, x2 + k, y2, 20);
                scanline.DrawScanLine(graphics, -R+n, );
            }
        }/lkj vbn'

        (-R+n)*
       gx nbvc
      /*  x1* (float) Math.Cos(Math.PI / 2 + GetFm(k))*/

        private double GetFm(int m)
        {
            return n * m / M; //Угол alpha
        }
    }
}
