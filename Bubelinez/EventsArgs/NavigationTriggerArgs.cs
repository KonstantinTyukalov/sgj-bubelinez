using System;
using Bubelinez.Interfaces;

namespace Bubelinez.EventsArgs
{
    public class NavigationTriggerArgs : EventArgs
    {
        public LayersEnum Layer { get; private set; }        

        public NavigationTriggerArgs(LayersEnum layer)
        {
            Layer = layer;
        }
    }
}
