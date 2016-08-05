using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace ParticleEngine
{
    public partial class ParticleWindow : Form
    {
        //Setup events, double buffered window, 
        //start timer.
        public ParticleWindow()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            timer1.Start();
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(KeyPressHandler);
            this.Icon = ParticleEngine.Properties.Resources.Icon;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(ParticleWindow_Click);
            this.MouseDown += ParticleWindow_MouseDown;
            this.DoubleClick += ParticleWindow_DoubleClick;
        }


        //Global brush for drawing particles
        Brush brush = new SolidBrush(Color.Blue);

        //Globals used by form controls and form state
        bool auto = false;
        bool paused = false;
        bool mouseDown = false;
        bool emitter = false;
        int particleMultiplier = 1;
        int ParticleSize = 5;
        int RotationSpeed;

        /*
         * WinForms is too stupid to get the updated mouse state on a 
         * mouse down, so we have to use to to be able to maintain a 
         * mouse down state, in actuallity, this does nothing.
         */
        MouseEventArgs PrevMouse_e;

        //Global random num generator for anything that needs to be random
        //(Colors, x/Y Vel, positions, etc.
        static Random rnd = new Random();

        //Possible Particle Colors
        List<Color> Colors = new List<Color>() {Color.Red, Color.Pink, Color.Orange, 
                                                Color.Green, Color.Blue, Color.Teal, 
                                                Color.Coral, Color.Aqua, Color.Yellow,
                                                Color.Magenta, Color.Purple, Color.YellowGreen};
        int currentColor = 0;

        private void EmitterBtn_Click(object sender, EventArgs e)
        {
            //Randomize the first emitter
            float rX = (float)rnd.Next(-10, 10);
            float rY = (float)rnd.Next(0, 15);

            Particle particle = new Particle(EmitterOne.Left, EmitterOne.Top, rX, rY, ParticleSize, ParticleSize, RotationSpeed);
            particle.particleColor.Color = Colors[currentColor];

            //Randomize the second emitter
            rX = (float)rnd.Next(-10, 10);
            rY = (float)rnd.Next(0, 15);

            Particle particle2 = new Particle(EmitterTwo.Left, EmitterTwo.Top, rX, rY, ParticleSize, ParticleSize, RotationSpeed);
            particle2.particleColor.Color = Colors[currentColor];

            //Randomize the third emitter
            rX = (float)rnd.Next(-10, 10);
            rY = (float)rnd.Next(0, 15);

            Particle particle3 = new Particle(EmitterThree.Left, EmitterThree.Top, rX, rY, ParticleSize, ParticleSize, RotationSpeed);
            particle3.particleColor.Color = Colors[currentColor];

            currentColor++;
            if(currentColor >= Colors.Count)
            {
                currentColor = 0;
            }
        }

        /*
         * This will allow the user to use different emitters independently, each meitter
         * will emit particles in a different way so the program is a little 
         * bit more interactive
         */
        #region KeyPress Handler
        public void KeyPressHandler(object sender, KeyEventArgs e)
        {
            //First emitter emits 5 particles at standard size
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                float rX = (float)rnd.Next(-10, 10);
                float rY = (float)rnd.Next(0, 15);
                int rColor = rnd.Next(Colors.Count);

                Particle particle1 = new Particle(EmitterOne.Left, EmitterOne.Top, rX, rY, 5, 5, RotationSpeed);
                particle1.particleColor.Color = Colors[rColor];

                rX = (float)rnd.Next(-10, 10);
                rY = (float)rnd.Next(0, 15);
                rColor = rnd.Next(Colors.Count);
                
                Particle particle2 = new Particle(EmitterOne.Left, EmitterOne.Top, rX, rY, 5, 5, RotationSpeed);
                particle2.particleColor.Color = Colors[rColor];

                rX = (float)rnd.Next(-10, 10);
                rY = (float)rnd.Next(0, 15);
                rColor = rnd.Next(Colors.Count);
                
                Particle particle3 = new Particle(EmitterOne.Left, EmitterOne.Top, rX, rY, 5, 5, RotationSpeed);
                particle3.particleColor.Color = Colors[rColor];

                rX = (float)rnd.Next(-10, 10);
                rY = (float)rnd.Next(0, 15);
                rColor = rnd.Next(Colors.Count);
                
                Particle particle4 = new Particle(EmitterOne.Left, EmitterOne.Top, rX, rY, 5, 5, RotationSpeed);
                particle4.particleColor.Color = Colors[rColor];

                rX = (float)rnd.Next(-10, 10);
                rY = (float)rnd.Next(0, 15);
                rColor = rnd.Next(Colors.Count);
                
                Particle particle5 = new Particle(EmitterOne.Left, EmitterOne.Top, rX, rY, 5, 5, RotationSpeed);
                particle5.particleColor.Color = Colors[rColor];
            }

        
            //Second emitter emits 1 particle shaped like a rectangle
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                float rX = (float)rnd.Next(-10, 10);
                float rY = (float)rnd.Next(0, 15);
                int   rColor = rnd.Next(Colors.Count);

                Particle particle = new Particle(EmitterTwo.Left, EmitterTwo.Top, rX, rY, 15, 3, RotationSpeed);
                particle.particleColor.Color = Colors[rColor];
            }

            //Third emitter emits 3 particles at three different sizes
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                float rX = (float)rnd.Next(-10, 10);
                float rY = (float)rnd.Next(0, 15);
                int   rColor = rnd.Next(Colors.Count);
                

                Particle particle = new Particle(EmitterThree.Left, EmitterThree.Top, rX, rY, 2, 2, RotationSpeed);
                particle.particleColor.Color = Colors[rColor];

                rX = (float)rnd.Next(-10, 10);
                rY = (float)rnd.Next(0, 15); 
                rColor = rnd.Next(Colors.Count);
                                
                Particle particle2 = new Particle(EmitterThree.Left, EmitterThree.Top, rX, rY, 5, 5, RotationSpeed);
                particle2.particleColor.Color = Colors[rColor];

                rX = (float)rnd.Next(-10, 10);
                rY = (float)rnd.Next(0, 15);
                rColor = rnd.Next(Colors.Count);
                 

                Particle particle3 = new Particle(EmitterThree.Left, EmitterThree.Top, rX, rY, 10, 5, RotationSpeed);
                particle3.particleColor.Color = Colors[rColor];
            }
        }
        #endregion

        public void RenderParticles(Graphics renderer)
        {

            //Iterate through the static list of particles
            for (int i = 0; i < Particle.activeParticles.Count; i++)
            {

                Particle tempParticle = Particle.activeParticles[i];

                RectangleF rect = new RectangleF();
                rect.X = tempParticle.x;
                rect.Y = tempParticle.y;
                rect.Width = tempParticle.w;
                rect.Height = tempParticle.h;

                //Rectangle that represents the shadow of the particle
                RectangleF shadowRect = new RectangleF();
                shadowRect.X = tempParticle.shadowX;
                shadowRect.Y = tempParticle.shadowY;
                shadowRect.Width = tempParticle.shadowW;
                shadowRect.Height = tempParticle.shadowH;

                //Rotates the angle about a point
                RotateParticle(renderer, rect, shadowRect,
                                tempParticle.getCurrentRotatedAngle(),
                                tempParticle.particleColor,
                                tempParticle.particleShadowColor);
            }

        }

        //Stuff that needs to happen before we render the particles.
        public void UpdateParticles()
        {
            for(int i = 0; i < Particle.activeParticles.Count; i++)
            {
                //TODO:This could potentially be divided into multiple tasks for performance boosts....
                //Look into it
                Particle.activeParticles[i].MoveParticle();
                Particle.activeParticles[i].CheckIfPassedScreen(ParticleWindow.ActiveForm);
                ParticleCntLbl.Text = "Particle Count: " + Particle.activeParticles.Count.ToString();
            }
            
        }

        //Set the quality of the rendering ad then render particles
        protected override void OnPaint(PaintEventArgs e)
        {
            //Reduce the render quality as it isn't important here.
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            e.Graphics.InterpolationMode = InterpolationMode.High;

            RenderParticles(e.Graphics);
        }

        //Stuff that needs to happen per tick.
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateParticles();
            this.Invalidate();
            Interlocked.Increment(ref _frameCount);
            FpsLbl.Text = "FPS: " + GetFps().ToString();

            if(mouseDown == true)
            {
                ParticleWindow_MouseDown(this, PrevMouse_e);
            }

            //If auto-generate particles is on
            if(auto == true)
            {
                //Specifies the number of times we will auto-emit particles
                for (int i = 0; i < particleMultiplier; i++ )
                {
                    EmitterBtn_Click(null, null);
                }
                    
            }
            else
            {
                //Do nothing, wait for manual input
            }
            
        }

        //Auto-generate particles button
        private void button1_Click(object sender, EventArgs e)
        {
            if(auto == true)
            {
                auto = false;
                AutoGenerateBtn.Text = "Auto-Generate Particles: OFF";
            }
            else if (auto == false)
            {
                auto = true;
                AutoGenerateBtn.Text = "Auto-Generate Particles: ON";
            }
        }

        //TODO: Using the transform property of the graphics object is 
        //MASSIVELY slow, the two combined account for 70% of the cpu power 
        //we are using...definitely need to optimize this...

        //NOTE: GDI calls out internally to a GdiFlush() method, which 
        //is probably where most of the performance is getting lost, 
        //GDI prefers to draw in batches. 

        //For rotating the Particles
        public void RotateParticle(Graphics g, RectangleF r, 
                                    RectangleF rShadow, float angle, 
                                    Pen particleColor, Pen particleShadow)
        {
            PointF shadowPoint = new PointF(rShadow.Left + (rShadow.Width / 1),
                                            rShadow.Top + (rShadow.Height / 1));
            PointF particlePoint = new PointF(r.Left + (r.Width / 1),
                                              r.Top + (r.Height / 2));
            //Angle of the shadow gets set to the angle of the particle, 
            //that way we can rotate them at the same rate
            float shadowAngle = angle;

            //rotate and draw the shadow of the Particle
            g.RotateTransformAt(shadowAngle, shadowPoint);
            g.DrawRectangle(particleShadow, rShadow.X, rShadow.Y, rShadow.Width, rShadow.Height);
            g.ResetTransform();
            
            //Set the current draw location to the rotated matrix point
            //and draw the Particle
            g.RotateTransformAt(angle, particlePoint);
            g.DrawRectangle(particleColor, r.X, r.Y, r.Width, r.Height);
            g.ResetTransform();
        }


        #region FormControls
        //Pause the timer.
        private void PauseButton_Click(object sender, EventArgs e)
        {
            if(paused == true)
            {
                timer1.Start();
                PauseButton.Text = "Pause";
                paused = false;
            }
            else if (paused == false)
            {
                timer1.Stop();
                PauseButton.Text = "Un-Pause";
                paused = true;
            }
        }

        //Form control to increase or decrease the max particles
        private void ParticleMax_Scroll(object sender, EventArgs e)
        {
            Particle.MAX_PARTICLES = ParticleMax.Value;
            MaxParticlesLbl.Text = "Max Particles: " + ParticleMax.Value;
        }

        //Changes the size of the next created particles (that get generated from the button/auto)
        private void ParticleSizeTrack_Scroll(object sender, EventArgs e)
        {
            ParticleSize = ParticleSizeTrack.Value;
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

        //Simply set the multiplier to the value of the combo box (ex: 2 wil run the emitter
        //button click twice)
        private void ParticleMultiplierCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            particleMultiplier = ParticleMultiplierCB.SelectedIndex;
        }

        //Clears all particles (useful for if you are lagging hard)
        private void ParticleReset_Click(object sender, EventArgs e)
        {
            Particle.activeParticles.Clear();
        }

        //Changes the angle of rotation dynamically
        private void RotationSlider_Scroll(object sender, EventArgs e)
        {
            RotationSpeed = RotationSlider.Value;
            for (int i = 0; i < Particle.activeParticles.Count; i++)
            {
                Particle.activeParticles[i].rotationSpeed = RotationSpeed;
            }
        }
        #endregion

        #region MouseInput
        //On click we will generate a force that will push particles around
        private void ParticleWindow_Click(object sender, MouseEventArgs e)
        {
            //TO do that we first create a force emitter, this will be a 
            //rectangular area around the mouse.
            ForceEmitter _emitter = new ForceEmitter(e.X, e.Y, 400, 400);

            //Center the rectangle around the emitter
            RectangleF rect = new RectangleF();
            rect.X = _emitter.OuterX;
            rect.Y = _emitter.OuterY;
            rect.Width = _emitter.W;
            rect.Height = _emitter.H;
            

            /*
            To generate forces properly for each particle, we are going to 
            need to run different equations depending on where in the recangle 
            the particle landed, because essentially we don't have to do a lot 
            right now in terms of generating higher velocities and such, for now 
            we care about changing the direction of the particle, which is simply 
            swapping the sign of the particle's x and y velocities depending on 
            what quadrant of the rectangle they fell into. Here we are creating 
            4 quadrants that we will test against.
            */

            //Top-Left Qudrant
            RectangleF Q1 = new RectangleF();
            Q1.X = rect.X;
            Q1.Y = rect.Y;
            Q1.Width = rect.Width / 2;
            Q1.Height = rect.Height / 2;

            //Bottom-Left Quadrant
            RectangleF Q2 = new RectangleF();
            Q2.X = rect.X;
            Q2.Y = rect.Y + (rect.Width / 2);
            Q2.Width = rect.Width / 2;
            Q2.Height = rect.Height / 2;

            //Top-Right
            RectangleF Q3 = new RectangleF();
            Q3.X = rect.X + (rect.Height / 2);
            Q3.Y = rect.Y;
            Q3.Width = rect.Width / 2;
            Q3.Height = rect.Height / 2;

            //Bottom-Right
            RectangleF Q4 = new RectangleF();
            Q4.X = rect.X + (rect.Height / 2);
            Q4.Y = rect.Y + (rect.Width / 2);
            Q4.Width = rect.Width / 2;
            Q4.Height = rect.Height / 2;

            /*
             * We will need to test each of the particles x and y 
             * positions to see which quadrant they fall into, 
             * while it would be nice to do this based on how much of
             * the particle is inside of a quadrant then applying 
             * the force based on that, for the moment it feels too 
             * expensive to do so we will look at it later.
            */


            for (int i = 0; i < Particle.activeParticles.Count; i++)
            {
                PointF point = new PointF();
                point.X = Particle.activeParticles[i].x;
                point.Y = Particle.activeParticles[i].y;

                Particle _temp = Particle.activeParticles[i];
                _temp.Gravity = -0.1f;

                float rX = (float)rnd.Next(-5, 5);
                float rY = (float)rnd.Next(-5, 5);

                /*
                 * Below is the math we need to perform to increase 
                 * velocity on click to apply force and to make 
                 * sure that depending on what side/quadrant 
                 * of the cursor the particle was in that we 
                 * re-position the particles trajectory accordingly
                 */

                if (_temp.pulled == true)
                {
                    //Reassign random x and y velocities:
                    rX = (float)rnd.Next(-5, 5);
                    rY = (float)rnd.Next(-5, 5);

                    rX = (float)rnd.Next(-5, 5);
                    rY = (float)rnd.Next(-5, 5);

                    rX = (float)rnd.Next(-5, 5);
                    rY = (float)rnd.Next(-5, 5);

                    _temp.pulled = false;
                }

                    //Check Q1, xVel negative if greater than 0, 
                    //yVel positive if less than 0
                    if (Q1.Contains(point))
                    {
                        _temp.xVel *= 5;
                        _temp.yVel *= 5;

                        if (_temp.xVel > 0)
                        {
                            _temp.xVel = _temp.xVel * -1;
                        }
                        if (_temp.yVel < 0)
                        {
                            _temp.yVel = _temp.yVel * 1;
                        }
                    }
                    //Check Q2, xVel negative if greater than 0, 
                    //yVel negative if greater than 0
                    if (Q2.Contains(point))
                    {
                        _temp.xVel *= 5;
                        _temp.yVel *= 5;

                        if (_temp.xVel > 0)
                        {
                            _temp.xVel = _temp.xVel * -1;
                        }
                        if (_temp.yVel > 0)
                        {
                            _temp.yVel = _temp.yVel * -1;
                        }
                    }
                    //Check Q3, xVel positive is less than 0, 
                    //yVel positive if less than 0
                    if (Q3.Contains(point))
                    {
                        _temp.xVel *= 5;
                        _temp.yVel *= 5;

                        if (_temp.xVel < 0)
                        {
                            _temp.xVel = _temp.xVel * 1;
                        }
                        if (_temp.yVel < 0)
                        {
                            _temp.yVel = _temp.yVel * 1;
                        }
                    }

                    //Check Q4, xVel negative if less than zero and yVel negative
                    //if greater than 0
                    if (Q4.Contains(point))
                    {
                        _temp.xVel *= 5;
                        _temp.yVel *= 5;

                        if (_temp.xVel < 0)
                        {
                            _temp.xVel = _temp.xVel * -1;
                        }
                        if (_temp.yVel > 0)
                        {
                            _temp.yVel = _temp.yVel * -1;
                        }
                    }
                }

            mouseDown = false;
        }

        private void ParticleWindow_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            PrevMouse_e = e;

            ForceEmitter _emitter = new ForceEmitter(e.X, e.Y, 200, 200);

            //Forces
            RectangleF rect = new RectangleF();
            rect.X = _emitter.OuterX;
            rect.Y = _emitter.OuterY;
            rect.Width = _emitter.W;
            rect.Height = _emitter.H;

            //Top-Left Qudrant
            RectangleF Q1 = new RectangleF();
            Q1.X = rect.X;
            Q1.Y = rect.Y;
            Q1.Width = rect.Width / 2;
            Q1.Height = rect.Height / 2;

            //Bottom-Left Quadrant
            RectangleF Q2 = new RectangleF();
            Q2.X = rect.X;
            Q2.Y = rect.Y + (rect.Width / 2);
            Q2.Width = rect.Width / 2;
            Q2.Height = rect.Height / 2;

            //Top-Right
            RectangleF Q3 = new RectangleF();
            Q3.X = rect.X + (rect.Height / 2);
            Q3.Y = rect.Y;
            Q3.Width = rect.Width / 2;
            Q3.Height = rect.Height / 2;

            //Bottom-Right
            RectangleF Q4 = new RectangleF();
            Q4.X = rect.X + (rect.Height / 2);
            Q4.Y = rect.Y + (rect.Width / 2);
            Q4.Width = rect.Width / 2;
            Q4.Height = rect.Height / 2;


            for (int i = 0; i < Particle.activeParticles.Count; i++)
            {

                PointF point = new PointF();
                point.X = Particle.activeParticles[i].x;
                point.Y = Particle.activeParticles[i].y;

                Particle _temp = Particle.activeParticles[i];

                //If the particle is in the rectangle and it is not being pulled yet
                if (rect.Contains(point) && _temp.pulled == false)
                {
                    float rise;
                    float run;
                    float slope;

                    rise = _emitter.Y - _temp.y;
                    run = _emitter.X - _temp.x;
                    slope = rise / run;

                    //If the slope is negative trajectories get calculated differently
                    //Top-Left
                    if (slope > 0 && rise > 0 && run > 0)
                    {
                        _temp.yVel = (rise * -1) / 60;
                        _temp.xVel = (run * 1) / 60;
                    }
                    //Top-Right
                    else if (slope < 0 && rise > 0 && run < 0)
                    {
                        _temp.yVel = (rise * -1) / 60;
                        _temp.xVel = (run * 1) / 60;
                    }
                    //Bottom-Right
                    else if (slope > 0 && rise < 0 && run < 0)
                    {
                        _temp.yVel = (rise * -1) / 60;
                        _temp.xVel = (run * 1) / 60;
                    }
                    //Bottom-Left
                    else if (slope < 0 && rise < 0 && run > 0)
                    {
                        _temp.yVel = (rise * -1) / 60;
                        _temp.xVel = (run * 1) / 60;
                    }


                    _temp.Gravity = 0.0f;
                }

                //Re-Enable gravity if the particle exits the vortex
                if (!rect.Contains(point))
                {
                    _temp.pulled = false;
                    _temp.Gravity = -0.1f;
                }
                else
                {
                    _temp.pulled = true;
                }


                //Hold the particle in place if it hits the emitter
                if ((point.X <= (_emitter.X + _temp.w * 3) && point.X >= (_emitter.X - _temp.w * 3)) &&
                    point.Y <= (_emitter.Y + _temp.h * 3) && point.Y >= (_emitter.Y - _temp.h * 3))
                {
                    _temp.x = _emitter.X;
                    _temp.y = _emitter.Y;
                    
                }
            }
            
        }

        private void ParticleWindow_DoubleClick(object sender, EventArgs e)
        {
            //If the user double clicks without this code in place, it let's them 
            //create a vortex without holding the mouse down, this ensures that 
            //that cannot happen
            mouseDown = true;

            for (int i = 0; i < Particle.activeParticles.Count; i++)
            {
                Particle _temp = Particle.activeParticles[i];
                float rX = (float)rnd.Next(-5, 5);
                float rY = (float)rnd.Next(-5, 5);
                _temp.Gravity = -0.1f;

                //Basically we want to reasign velocities whenever a vortex gets 
                //created on a double click and we cancel it from happening, 
                //that way we don't mess up the movement of each particle.
                if (_temp.pulled == true)
                {
                    //Reassign random x and y velocities:
                    rX = (float)rnd.Next(-5, 5);
                    rY = (float)rnd.Next(-5, 5);

                    rX = (float)rnd.Next(-5, 5);
                    rY = (float)rnd.Next(-5, 5);

                    rX = (float)rnd.Next(-5, 5);
                    rY = (float)rnd.Next(-5, 5);

                    _temp.pulled = false;
                    
                }
            }
        }
        #endregion
    }

}


//////////////////BUGS////////////////////////////////
/*
*/

//////////////////FEATURES TO BE ADDED//////////////////////////
/*
    -Allow mouse movement with vortex.          
    -Add more dynamic random velocity algorithm //DONE
*/