using Bubelinez.Interfaces;
using Bubelinez.Services;
using SFML.System;
using SFML.Window;

namespace Bubelinez.Layers
{
    public class LayerManager
    {
        public Layer CurrentLayer { get; private set; }
        private readonly LayerFactory _layerFactory;

        public LayerManager(LayerFactory layerFactory)
        {
            _layerFactory = layerFactory;
            CurrentLayer = layerFactory.getLayer(LayersEnum.Menu);
        }

        public void HandleMouseEvent(object sender, MouseButtonEventArgs e)
        {
            var layer = CurrentLayer.GetLayer(new Vector2f(e.X, e.Y));
            if(layer != LayersEnum.None) CurrentLayer = _layerFactory.getLayer(LayersEnum.None);
        }
    }
}