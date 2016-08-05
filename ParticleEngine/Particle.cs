using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleEngine
{
    class Particle
    {

        public float x, y;
        public float xVel, yVel;
        public float w, h;
        public float Gravity = -.1f;
        public static int MAX_PARTICLES = 1;
        public Pen particleColor = new Pen(Color.White, 5);
        public Pen particleShadowColor = new Pen(Color.Black, 5);
        public float angleOfRotation = 1.0f;
        public float shadowX, shadowY, shadowW, shadowH;
        public float rotationSpeed = 4.1f;
        public float rotationAcceleration = 1.0f;
        public bool pulled = false;
        public static List<Particle> activeParticles = new List<Particle>();

        public Particle(float X, float Y, float initialVelX, float initialVelY, float width, float height, float RotationSpeed)
        {
            x = X;
            y = Y;
            xVel = initialVelX;
            yVel = initialVelY;
            w = width;
            h = height;
            activeParticles.Add(this);
            calculateShadowDimensions();
            particleColor.Width = width;
            particleShadowColor.Width = width;
            rotationSpeed = RotationSpeed;
            //Check to see if we have too many particles, 
            //if so, kill the oldest one.
            KillParticles();
        }

        //Moves the particles
        public void MoveParticle()
        {
            y -= CalculateUpwardVelocity();
            x += xVel;
            calculateShadowDimensions();
        }

        //NOTE: This will essentially set yVel twice, 
        //I'm keeping this here for readability but may revisit later.
        public float CalculateUpwardVelocity()
        {
            //Determine the new velocity after the effects of gravity have been applied
            yVel = yVel + Gravity;

            return yVel;
        }

        public void KillParticles()
        {
            //If we have more than the max allowed particles, kill the oldest one.
            if(activeParticles.Count > MAX_PARTICLES)
            {
                //Remove the exact amount that we exceeded.
                activeParticles.RemoveRange(MAX_PARTICLES, activeParticles.Count - MAX_PARTICLES);
            }
        }

        //Makes a shadow relative to the size of the particle
        private void calculateShadowDimensions()
        {
            shadowW = w;
            shadowH = h;
            shadowX = (x + w / 2.0f + 1.0f);
            shadowY = (y - h / 2.0f + 1.0f);
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
                    activeParticles.Remove(this);
                }
                else if (y > window.Height)
                {
                    activeParticles.Remove(this);
                }
            }
        }

        //We cannot exceed the max angle of rotation, this validates that before 
        //we send off the current angle
        //TODO: See if we can get variable rotational speeds
        public float getCurrentRotatedAngle()
        {
            if (angleOfRotation >= 360.0f)
            {
                angleOfRotation = 0.01f;
            }
            else
            {
                if(rotationAcceleration >= 25.0f)
                {
                    rotationAcceleration = 25.0f;
                }
                else
                {
                    rotationAcceleration += 0.01f;
                    angleOfRotation += rotationSpeed * rotationAcceleration;
                }
            }
            return angleOfRotation;
        }
    }
    
}
