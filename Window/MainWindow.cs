using System;
using SFML.Graphics;
using SFML.Window;

namespace Bubelinez.Window
{
    public class MainWindow
    {
        private readonly RenderWindow _window;
        private const uint _windowWidth = 1280;
        private const uint _windowHeight = 720;
        private const string _windowName = "BUBELINEZ";
        private const uint _depthBits = 0;
        private const uint _stencilBits = 0;
        private const uint antialiasingLevel = 1;

        public MainWindow()
        {
            VideoMode videoMode = new VideoMode(_windowWidth, _windowHeight);
            ContextSettings contextSettings = new ContextSettings(_depthBits, _stencilBits, antialiasingLevel);
            _window = new RenderWindow(new VideoMode(_windowWidth, _windowHeight), _windowName, Styles.Fullscreen, contextSettings);
            _window.SetFramerateLimit(60);
            _window.SetVerticalSyncEnabled(true);
            _window.SetKeyRepeatEnabled(false);

            _window.Closed += WindowOnClosed;
        }

        public void Run()
        {
            while (_window.IsOpen)
            {
                _window.DispatchEvents();
                _window.Clear();

                // Paste game logics this
                    
                _window.Display();
            }
        }

        private void WindowOnClosed(object sender, EventArgs e)
        {
            _window.Close();
        }
    }
}
