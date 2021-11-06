using System.Collections.Generic;
using Bubelinez.Components;
using Bubelinez.Interfaces;
using Bubelinez.Utils;
using SFML.Graphics;
using SFML.System;

namespace Bubelinez.Layers
{
    public class Menu : Drawable, Layer
    {
        public string Name { get; init; }

        public Vector2f Position
        {
            get => _sprite.Position;
            set
            {
                if (_sprite != null) _sprite.Position = value;
            }
        }

        private readonly List<NavigationButton> _buttons;
        private readonly Sprite _sprite;

        public Menu()
        {
            Name = "Menu";
            _sprite = new Sprite();
            Position = new Vector2f(0, 0);
            _buttons = new List<NavigationButton>();

            var buttonSprite = new Sprite();
            buttonSprite.Texture = new Texture(".\\Assets\\Textures\\ETexture.png");
            buttonSprite.Position = new Vector2f(100, 100);
            buttonSprite.TextureRect = new IntRect(new Vector2i(100, 100), new Vector2i(40, 20));
            _buttons.Add(new NavigationButton("Game", new Vector2f(100, 100), buttonSprite, LayersEnum.None));
        }

        public LayersEnum GetLayer(Vector2f position)
        {
            foreach (var button in _buttons)
            {
                
                if (Intersection.CheckPointRectIntersect(position, new FloatRect(button.Position, new Vector2f(button.Rect.Width, button.Rect.Height))))
                    return button.LayerToMove;
            }

            return LayersEnum.Menu;
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            target.Draw(_sprite);
            foreach (var button in _buttons)
            {
                target.Draw(button);
            }
        }
    }
}