using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleEngine
{
    public static class GraphicsExtensions
    {

            public static void RotateTransformAt(this Graphics g, float angle, PointF point)
            {
                g.TranslateTransform(point.X, point.Y);
                g.RotateTransform(angle);
                g.TranslateTransform(-point.X, -point.Y);
            }

            public static void RotateTransformsAt(this Graphics g, float angle, PointF[] point)
            {
                g.TransformPoints(System.Drawing.Drawing2D.CoordinateSpace.World, System.Drawing.Drawing2D.CoordinateSpace.Device,
                                    point);
            }
    }
}
