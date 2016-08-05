using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallisticsEngine
{
    public partial class BallisticsWindow : Form
    {
        public BallisticsWindow()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            timer1.Start();
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(KeyPressHandler);
        }


        //Handler User Input
        #region KeyPress Handler
        public void KeyPressHandler(object sender, KeyEventArgs e)
        {
            //Normal Bullet
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                Ballistic b = new Ballistic(3.0f, 3.0f, BulletLazerSource.Left, 
                                            BulletLazerSource.Top, 
                                            17.0f, 0.0f, Color.Black, 0);

                Ballistic.activeBallistics.Add(b);
            }

            //Lazer
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                Ballistic b = new Ballistic(15.0f, 0.50f, BulletLazerSource.Left,
                                            BulletLazerSource.Top,
                                            5.0f, 0.0f, Color.Red, 1);

                Ballistic.activeBallistics.Add(b);
            }

            //Arrow
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                Ballistic b = new Ballistic(10, 0.3f, BulletLazerSource.Left,
                                            BulletLazerSource.Top,
                                            4.0f, 1.0f, Color.Chocolate, 2);

                Ballistic.activeBallistics.Add(b);
            }

            //Mortar
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                Ballistic b = new Ballistic(5, 5, MortarSource.Left,
                                            MortarSource.Top,
                                            3.0f, 13.0f, Color.Black, 3);

                Ballistic.activeBallistics.Add(b);
            }


        }
        #endregion

        //Update anything in game pre-render
        public void UpdateGame()
        {
            for(int i = 0; i < Ballistic.activeBallistics.Count; i++)
            {
                Ballistic temp = Ballistic.activeBallistics[i];
                temp.MoveBallistic();
                temp.CheckIfPassedScreen(BallisticsWindow.ActiveForm);
            }
        }

        public void Render(Graphics g)
        {
            for(int i = 0; i < Ballistic.activeBallistics.Count; i++)
            {
                Ballistic temp = Ballistic.activeBallistics[i];
                g.DrawRectangle(temp.Color, temp.x, temp.y,
                                temp.w, temp.h);
            }
        }

        //Render
        protected override void OnPaint(PaintEventArgs e)
        {
            //Reduce the render quality as it isn't important here.
            e.Graphics.SmoothingMode = SmoothingMode.None;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            e.Graphics.InterpolationMode = InterpolationMode.Low;

            Render(e.Graphics);
        }

        //Manage per-tick logic
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Update FPS Counter
            Interlocked.Increment(ref _frameCount);
            FpsLbl.Text = "FPS: " + GetFps().ToString();

            //Game Loop
            UpdateGame();
            this.Invalidate();
        }







        //Stuff for handling the FPS
        DateTime _lastCheckTime = DateTime.Now;
        long _frameCount = 0;

        //Called periodically to display the current FPS
        public double GetFps()
        {
            double secondsElapsed = (DateTime.Now - _lastCheckTime).TotalSeconds;
            long count = Interlocked.Exchange(ref _frameCount, 0);
            double fps = count / secondsElapsed;
            _lastCheckTime = DateTime.Now;
            return Math.Round(fps);
        }
    }
}
