using SFML.Graphics;
using SFML.System;

namespace Bubelinez.Interfaces
{
    public interface Layer
    {
        LayersEnum GetLayer(Vector2f position);
        void Draw(RenderTarget target, RenderStates states);
    }
}