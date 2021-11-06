using Bubelinez.Interfaces;
using Bubelinez.Services;
using SFML.Window;

namespace Bubelinez.Layers
{
    public class LayerManager
    {
        private Layer _currentLayer;

        public LayerManager(LayerFactory layerFactory)
        {
            _currentLayer = layerFactory.getLayer(LayersEnum.Menu);
        }

        public void HandleMouseEvent(object sender, MouseButtonEventArgs e)
        {
           
        }
    }
}