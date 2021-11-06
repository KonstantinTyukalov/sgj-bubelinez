using System;
using Bubelinez.EventsArgs;
using Bubelinez.Interfaces;
using Bubelinez.Services;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Bubelinez.Layers
{
    public class LayerManager
    {
        public Layer CurrentLayer { get; private set; }
        private readonly LayerFactory _layerFactory;
        private readonly RenderWindow _window;

        public LayerManager(LayerFactory layerFactory, RenderWindow window)
        {
            _window = window;
            _layerFactory = layerFactory;
            
            CurrentLayer = layerFactory.getLayer(LayersEnum.Menu);
            SubscribeLayerToMouseButtonPressed(CurrentLayer);
        }

        public void Processe()
        {
            
        }

        public void SwitchLayer(object sender, NavigationTriggerArgs e)
        {
            UnsubscribeLayerFromMouseButtonPressed(CurrentLayer);
            CurrentLayer = _layerFactory.getLayer(e.Layer);
            SubscribeLayerToMouseButtonPressed(CurrentLayer);
            Console.WriteLine($"Layer is {e.Layer}");
        }

        private void SubscribeLayerToMouseButtonPressed(Layer layer)
        {
            _window.MouseButtonPressed += layer.HandleMouseEvent;
            layer.NavigationTriggerArgs += SwitchLayer;
        }
        
        private void UnsubscribeLayerFromMouseButtonPressed(Layer layer)
        {
            _window.MouseButtonPressed -= layer.HandleMouseEvent;
            layer.NavigationTriggerArgs -= SwitchLayer;
        }
    }
}