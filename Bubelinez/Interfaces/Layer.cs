using System;
using Bubelinez.EventsArgs;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Bubelinez.Interfaces
{
    public interface Layer
    {
        void HandleMouseEvent(object sender, MouseButtonEventArgs e);
        event EventHandler<NavigationTriggerArgs> NavigationTriggerArgs;
        void Draw(RenderTarget target, RenderStates states);
    }
}