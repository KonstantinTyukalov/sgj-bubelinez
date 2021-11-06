using System;
using System.Collections.Generic;
using Bubelinez.Components;
using Bubelinez.Interfaces;
using SFML.Graphics;
using SFML.System;

namespace Bubelinez.Layers
{
    public class Menu : Drawable, Layer
    {
        public readonly string _name;

        public Vector2f Position
        {
            get => Sprite.Position;
            set
            {
                if (Sprite != null) Sprite.Position = value;
            }
        }

        public readonly List<NavigationButton> Buttons;
        public readonly Sprite Sprite;

        public Menu()
        {
            _name = "Menu";
            Sprite = new Sprite()
            {
                Texture = new Texture("Assets/Test.jpg")
            };
            Position = new Vector2f(0, 0);
            Buttons = new List<NavigationButton>()
            {
                //new NavigationButton("Start", new Vector2i(100, 100), new Vector2i(100, 100)
            };
        }
        
        public LayersEnum GetLayer(Vector2f position)
        {
            // foreach (var button in Buttons)
            // {
            //     if()
            // }
            return LayersEnum.Menu;
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            target.Draw(Sprite);
            foreach (var button in Buttons)
            {
                target.Draw(button);
            }
        }
    }
}