using System;
using Bubelinez.Interfaces;
using Bubelinez.Layers;
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
        private const uint _antialiasingLevel = 1;

        private LayerManager _layerManager;

        public MainWindow(LayerManager layerManager)
        {
            var videoMode = new VideoMode(_windowWidth, _windowHeight);
            var contextSettings = new ContextSettings(_depthBits, _stencilBits, _antialiasingLevel);
            _window = new RenderWindow(videoMode, _windowName, Styles.Fullscreen, contextSettings);
            _window.SetFramerateLimit(60);
            _window.SetVerticalSyncEnabled(true);
            _window.SetKeyRepeatEnabled(false);

            _layerManager = layerManager;

            _window.MouseButtonPressed += _layerManager.HandleMouseEvent;
            _window.Closed += WindowOnClosed;
        }

        public void Run()
        {
            while (_window.IsOpen)
            {
                _window.DispatchEvents();
                _window.Clear();


                _window.Display();
            }
        }

        private void WindowOnClosed(object sender, EventArgs e)
        {
            _window.Close();
        }
    }
}