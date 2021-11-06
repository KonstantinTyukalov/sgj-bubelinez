using Bubelinez.Interfaces;

namespace Bubelinez.Layers
{
    public class LayerFactory
    {
        public Layer getLayer(LayersEnum layer)
        {
            switch (layer)
            {
                case LayersEnum.Menu:
                {
                    return new Menu();
                    break;
                }
                default: return new Menu();
            }
        }
    }
}