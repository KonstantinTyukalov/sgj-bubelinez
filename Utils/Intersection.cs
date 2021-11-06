using SFML.Graphics;
using SFML.System;

namespace Bubelinez.Utils
{
    public static class Intersection
    {
        public static bool CheckPointRectIntersec(Vector2f point, FloatRect rect)
        {
            var result = point - new Vector2f(rect.Top, rect.Left);
            if (result.X > 0 && result.Y > 0) return true;
            return false;
        }
    }
}