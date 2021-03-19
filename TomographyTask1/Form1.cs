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
            parallel.StartPoint = new Point(200, 200);
            parallel.M = int.Parse(textBoxM.Text);
            parallel.N = int.Parse(textBoxN.Text);
            parallel.h = int.Parse(textBoxh.Text);
            parallel.R = int.Parse(textBoxR.Text);

            
            parallel.DrawLines(graphics);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            Draw(graphics);
            pictureBox1.Refresh();
        }
    }
}
