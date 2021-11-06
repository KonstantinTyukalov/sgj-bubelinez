using System;
using System.Collections.Generic;
using System.Linq;
using Bubelinez.Components;
using Bubelinez.EventsArgs;
using Bubelinez.Interfaces;
using Bubelinez.Utils;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Bubelinez.Layers
{
    public class Menu : Drawable, Layer
    {
        public string Name { get; init; }
        public event EventHandler<NavigationTriggerArgs> NavigationTriggerArgs;
        
        private readonly List<NavigationButton> _buttons;
        private readonly RectangleShape _background;

        public Menu()
        {
            Name = "Menu";
            _background = new RectangleShape(new Vector2f(1280, 720))
            {
                Texture = new Texture(".\\Assets\\Textures\\Menu_Background.png")
            };
            _buttons = new List<NavigationButton>();
            createButtons();
        }

        private void createButtons()
        {
            var sprite = new Sprite();
            sprite.Position = new Vector2f(100, 220);
            sprite.Texture = new Texture(".\\Assets\\Textures\\Menu_Button_Play.png");
            sprite.TextureRect = new IntRect(new Vector2i(0, 0), new Vector2i(300, 60));
            _buttons.Add(new NavigationButton("Game", sprite, LayersEnum.Game));
            
            sprite = new Sprite();
            sprite.Position = new Vector2f(100, 300);
            sprite.Texture = new Texture(".\\Assets\\Textures\\Menu_Button_Settings.png");
            sprite.TextureRect = new IntRect(new Vector2i(0, 0), new Vector2i(300, 60));
            _buttons.Add(new NavigationButton("Settings", sprite, LayersEnum.Settings));
            
            sprite = new Sprite();
            sprite.Position = new Vector2f(100, 380);
            sprite.Texture = new Texture(".\\Assets\\Textures\\Menu_Button_Exit.png");
            sprite.TextureRect = new IntRect(new Vector2i(0, 0), new Vector2i(300, 60));
            _buttons.Add(new NavigationButton("Exit", sprite, LayersEnum.None));
        }

        public void HandleMouseEvent(object sender, MouseButtonEventArgs e)
        {
            foreach (var button in _buttons.Where(button => button is NavigationButton))
            {
                var mousePosition = new Vector2f(e.X, e.Y);
                var buttonSize = new Vector2f(button.Rect.Width, button.Rect.Height);
                var buttonRect = new FloatRect(button.Position, buttonSize);
                var isIntersec = Intersection.CheckPointRectIntersect(mousePosition, buttonRect);
                if(isIntersec) NavigationTriggerArgs.Invoke(this, new NavigationTriggerArgs(button.LayerToMove));
            }
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            target.Draw(_background);
            foreach (var button in _buttons)
            {
                target.Draw(button);
            }
        }
    }
}
