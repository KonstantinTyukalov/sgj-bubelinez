using SFML.Graphics;
using SFML.System;

namespace Bubelinez.Utils
{
    public static class Intersection
    {
        public static bool CheckPointRectIntersect(Vector2f point, FloatRect rect)
        {
            if (point.X < rect.Left) return false;
            if (point.Y < rect.Top) return false;
            if (point.X > rect.Left + rect.Width) return false;
            if (point.Y > rect.Top + rect.Height) return false;
            return true;
        }
    }
}
