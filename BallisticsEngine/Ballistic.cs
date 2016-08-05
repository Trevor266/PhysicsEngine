using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallisticsEngine
{
    class Ballistic
    {

        public float w, h, x, y;
        public float xVel, yVel;
        public float initialXVel;
        public Pen Color;
        public static List<Ballistic> activeBallistics = new List<Ballistic>();
        public enum BallisticsType {BULLET = 0, LAZER = 1, ARROW = 2, MORTAR = 3};
        public int BallisticType;

        /// <summary>
        /// Creates a generic ballistic
        /// </summary>
        /// <param name="BalType">0 for a bullet, 1 for a lazer, 2 for an arrow, and 3 for a mortar</param>
        public Ballistic(float Width, float Height, float X, float Y,
                         float xVelocity, float yVelocity,
                          Color drawColor, int BalType)
        {
            w = Width;
            h = Height;
            x = X;
            y = Y;
            xVel = xVelocity;
            yVel = yVelocity;
            initialXVel = xVel;
            Color = new Pen(drawColor, w);
            BallisticType = BalType;

            activeBallistics.Add(this);
        }


        public void MoveBallistic()
        {
            //Each ballistic will move in a particular way, 
            //this will allow us to determine how to move the ballistic.
            if(BallisticType == (int)BallisticsType.BULLET)
            {
                //Move x, slows the bullet down each frame
                xVel -= 0.05f;

                if(xVel < 5.0f)
                {
                    xVel = 5.0f;
                }
                x += xVel;

                //Move y, slightly drops the bullet each frame
                y += 0.2f;
            }

            else if(BallisticType == (int)BallisticsType.LAZER)
            {
                //Lazers don't get affected by gravity, simply move to the right 
                //at an increasing speed because lazers accelerate to the speed of light
                xVel += 0.35f;
                x += xVel;
            }
            else if (BallisticType == (int)BallisticsType.ARROW)
            {
                //Arrows fly in a small parabola and increase in speed to a point 
                //and then slow down, so we need to show that.
                //X Velocity will reach a point of two times it's initial value and slow back down to 
                //it's initial value.

                //We have to track when the arrow actually reaches it's max speed, or else we won't be able 
                //to run these if's properly
                bool HasPeaked = false;

                //If the arrow has reached it's max speed and it has peaked
                if(HasPeaked)
                {
                    xVel -= 0.002f;
                    if (xVel <= 0)
                    {
                        xVel = 0;
                    }
                }

                else if(xVel < initialXVel * 2 && !HasPeaked)
                {
                    xVel += 0.2f;

                    if(xVel >= initialXVel * 2)
                    {
                        HasPeaked = true;
                    }
                }

                //Simulates gravity slowly pulling on the arrow
                yVel -= 0.01f;

                x += xVel;
                y -= yVel;
            }
            else if (BallisticType == (int)BallisticsType.MORTAR)
            {
                //Mortars are just like arrows only more extreme, 
                //meaning a higher parabola and greater affects of gravity 
                //due to larger mass, so we just do the same as before
                bool HasPeaked = false;

                //If the mortar has reached it's max speed
                if (HasPeaked)
                {
                    xVel -= 0.2f;
                    if(xVel <= 0)
                    {
                        xVel = 0;
                    }
                }

                else if (xVel < initialXVel * 1.5f && !HasPeaked)
                {
                    xVel += 0.02f;

                    if (xVel >= initialXVel * 2)
                    {
                        HasPeaked = true;
                    }
                }

                yVel -= 0.1f;

                x += xVel;
                y -= yVel;
            }
        }

        public void CheckIfPassedScreen(System.Windows.Forms.Form window)
        {
            //If the window isn't in focus and we don't do this check, it will 
            //check a null value and crash.
            if (window != null)
            {
                if (x > window.Width)
                {
                    //Kill the particle if it goes past the width of the window
                    activeBallistics.Remove(this);
                }
                else if (y > window.Height)
                {
                    activeBallistics.Remove(this);
                }
            }
        }
    }
}
