using SFML.Graphics;
using SFML.System;

namespace Bubelinez.Components
{
    public abstract class Button : Drawable
    {
        public string Info { get; protected set; }

        public Vector2f Position
        {
            get => Sprite.Position;
            set
            {
                if (Sprite != null) Sprite.Position = value;
            }
        }

        protected Sprite Sprite;

        public virtual void Draw(RenderTarget target, RenderStates states)
        {
            target.Draw(Sprite);
        }
    }
}