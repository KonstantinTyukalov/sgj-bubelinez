using SFML.Graphics;
using SFML.Window;

namespace Bubelinez.RenameIt
{
    public class MainWindow
    {
        private RenderWindow window;

        public MainWindow()
        {
            window = new RenderWindow(new VideoMode(1280, 720), "DigitalBattle", Styles.Close);
            window.SetFramerateLimit(60);
            window.SetVerticalSyncEnabled(true);
            window.SetKeyRepeatEnabled(false);

            window.Closed += (sender, args) => { window.Close(); };
        }

        public void Run()
        {
            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear();

                // Paste game logics this
                    
                window.Display();
            }
        }
    }
}
