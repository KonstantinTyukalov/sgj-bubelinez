using Bubelinez.Interfaces;
using SFML.Graphics;

namespace Bubelinez.Layers
{

    class Duda : Drawable
    {
        private Sprite nna;

        public Duda()
        {
            nna = new Sprite();
        }
        public void Draw(RenderTarget target, RenderStates states)
        {
            target.Draw(nna);
        }
    }
    
    public class LayerFactory
    {
        public Layer getLayer(LayersEnum layer)
        {
            switch (layer)
            {
                case LayersEnum.None:
                {
                    return new Menu();
                    break;
                }
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