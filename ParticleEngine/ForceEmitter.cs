using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleEngine
{
    class ForceEmitter
    {

        public float X;
        public float Y;
        public float OuterX;
        public float OuterY;
        public int W;
        public int H;

        public ForceEmitter(float x, float y, int w, int h)
        {
            OuterX = x - (w / 2);
            OuterY = y - (h / 2);
            Y = y;
            X = x;
            W = w;
            H = h;
        }

    }
}
