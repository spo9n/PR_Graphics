using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_Graphics_Surgai
{
    public partial class MainForm : Form
    {
        private Timer TimerRed;
        private Timer TimerYellow;
        private Timer TimerGreen;
        private Timer TimerRedPedestrian;
        private Timer TimerGreenPedestrian;

        private Rectangle EllipseRed;
        private Rectangle EllipseYellow;
        private Rectangle EllipseGreen;
        private Rectangle PedestrianRed;
        private Rectangle PedestrianGreen;

        private readonly Image pedestrianIMG = Image.FromFile("img.png");

        Graphics graphics;

        public MainForm()
        {
            InitializeComponent();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            var graphics = e.Graphics;
            var pen = new Pen(Color.Black, 2);

            var mainTrafficRectangle = new Rectangle(20, 20, 100, 220);
            graphics.FillRectangle(Brushes.DarkGray, mainTrafficRectangle);
            graphics.DrawRectangle(pen, mainTrafficRectangle);

            EllipseRed = new Rectangle(40, 30, 60, 60);
            graphics.FillEllipse(Brushes.Red, EllipseRed);
            graphics.DrawEllipse(pen, EllipseRed);

            EllipseYellow = new Rectangle(40, 100, 60, 60);
            graphics.FillEllipse(Brushes.Black, EllipseYellow);
            graphics.DrawEllipse(pen, EllipseYellow);

            EllipseGreen = new Rectangle(40, 170, 60, 60);
            graphics.FillEllipse(Brushes.Black, EllipseGreen);
            graphics.DrawEllipse(pen, EllipseGreen);

            var pedestrianRectangle = new Rectangle(150, 20, 100, 160);
            graphics.FillRectangle(Brushes.DarkGray, pedestrianRectangle);
            graphics.DrawRectangle(pen, pedestrianRectangle);

            PedestrianRed = new Rectangle(180, 40, 40, 50);
            graphics.FillRectangle(Brushes.Red, PedestrianRed);
            graphics.DrawImage(pedestrianIMG, PedestrianRed);

            PedestrianGreen = new Rectangle(180, 100, 40, 50);
            graphics.FillRectangle(Brushes.Gray, PedestrianGreen);
            graphics.DrawImage(pedestrianIMG, PedestrianGreen);
        }

        private void TimerRedTick(object sender, EventArgs e)
        {
            var graphics = CreateGraphics();
            graphics.FillEllipse(Brushes.Red, EllipseRed);
            graphics.FillEllipse(Brushes.Black, EllipseYellow);
            graphics.FillEllipse(Brushes.Black, EllipseGreen);
        }

        private void TimerYellowTick(object sender, EventArgs e)
        {
            var graphics = CreateGraphics();
            graphics.FillEllipse(Brushes.Black, EllipseRed);
            graphics.FillEllipse(Brushes.Yellow, EllipseYellow);
            graphics.FillEllipse(Brushes.Black, EllipseGreen);
        }

        private void TimerGreenTick(object sender, EventArgs e)
        {
            var graphics = CreateGraphics();
            graphics.FillEllipse(Brushes.Black, EllipseRed);
            graphics.FillEllipse(Brushes.Black, EllipseYellow);
            graphics.FillEllipse(Brushes.Green, EllipseGreen);
        }

        private void TimerRedPedestrianTick(object sender, EventArgs e)
        {
            var graphics = CreateGraphics();
            graphics.FillRectangle(Brushes.Red, PedestrianRed);
            graphics.DrawImage(pedestrianIMG, PedestrianRed);
            graphics.FillRectangle(Brushes.Gray, PedestrianGreen);
            graphics.DrawImage(pedestrianIMG, PedestrianGreen);
        }

        private void TimerGreenPedestrianTick(object sender, EventArgs e)
        {
            var graphics = CreateGraphics();
            graphics.FillRectangle(Brushes.Gray, PedestrianRed);
            graphics.DrawImage(pedestrianIMG, PedestrianRed);
            graphics.FillRectangle(Brushes.Green, PedestrianGreen);
            graphics.DrawImage(pedestrianIMG, PedestrianGreen);
        }

        private void waitButton_Click(object sender, EventArgs e)
        {
            TimerYellow = new Timer();
            TimerYellow.Tick += TimerYellowTick;
            TimerYellow.Interval = 3000;
            TimerYellow.Start();

            TimerGreen = new Timer();
            TimerGreen.Tick += TimerGreenTick;
            TimerGreen.Interval = 4200;
            TimerGreen.Start();

            TimerRed = new Timer();
            TimerRed.Tick += TimerRedTick;
            TimerRed.Interval = 6400;
            TimerRed.Start();

            TimerGreenPedestrian = new Timer();
            TimerYellow.Tick += TimerGreenPedestrianTick;
            TimerGreenPedestrian.Interval = 2000;
            TimerGreenPedestrian.Start();

            TimerRedPedestrian = new Timer();
            TimerRed.Tick += TimerRedPedestrianTick;
            TimerRedPedestrian.Interval = 3000;
            TimerRedPedestrian.Start();
        }

        private void stopButton_Click_1(object sender, EventArgs e)
        {
            TimerYellow.Dispose();
            TimerGreen.Dispose();
            TimerGreen.Dispose();
            TimerGreenPedestrian.Dispose();
            TimerRedPedestrian.Dispose();

            var graphics = CreateGraphics();

            graphics.FillEllipse(Brushes.Red, EllipseRed);
            graphics.FillEllipse(Brushes.Black, EllipseYellow);
            graphics.FillEllipse(Brushes.Black, EllipseGreen);

            graphics.FillRectangle(Brushes.Red, PedestrianRed);
            graphics.DrawImage(pedestrianIMG, PedestrianRed);
            graphics.FillRectangle(Brushes.Gray, PedestrianGreen);
            graphics.DrawImage(pedestrianIMG, PedestrianGreen);
        }
    }
}
