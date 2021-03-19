using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomographyTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Draw(graphics);
        }

        private void Draw(Graphics graphics)
        {
            Parallel parallel = new Parallel();
            parallel.StartPoint = new Point(100, 100);
            parallel.M = 5;
            parallel.N = 5;
            parallel.h = 10;
            parallel.R = 90;

 
            parallel.GetDots(graphics);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            Draw(graphics);
            pictureBox1.Refresh();
        }
    }
}
