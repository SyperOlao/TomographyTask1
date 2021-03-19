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
            DrawParallel(graphics);
            DrawFan(graphics);
            graphics.Clear(Color.White); 
        }

        private void DrawParallel(Graphics graphics)
        {

            Parallel parallel = new Parallel();
            parallel.StartPoint = new Point(200, 200);
            parallel.M = int.Parse(textBoxM.Text);
            parallel.N = int.Parse(textBoxN.Text);
            parallel.h = int.Parse(textBoxh.Text);
            parallel.R = int.Parse(textBoxR.Text);

            
            parallel.DrawLines(graphics);
        }

        private void DrawFan(Graphics graphics)
        {
            Fan fan = new Fan();

            fan.StartPoint = new Point(200, 200);
            fan.M = int.Parse(textBoxM.Text);
            fan.N = int.Parse(textBoxN.Text);
            fan.h = int.Parse(textBoxh.Text);
            fan.R = int.Parse(textBoxR.Text);
            fan.Delta = double.Parse(textBoxDelta.Text);

            fan.DrawLines(graphics);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            DrawParallel(graphics);
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            DrawFan(graphics);
            pictureBox1.Refresh();
        }
    }
}
