using Bubelinez.Interfaces;
using SFML.Graphics;
using SFML.System;

namespace Bubelinez.Components
{
    public class NavigationButton : Button, Drawable
    {
        public LayersEnum LayerToMove { get; private set; }
        public NavigationButton(string info, Vector2f position, Sprite sprite, LayersEnum layerToMove)
        {
            LayerToMove = layerToMove;
            Info = info;
            Sprite = sprite;
            Position = position;
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            target.Draw(Sprite);
        }
    }
}