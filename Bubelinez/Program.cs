using Bubelinez.Layers;
using Bubelinez.Window;

namespace Bubelinez
{
    class Program
    {
        static void Main(string[] args)
        {
            MainWindow window = new MainWindow(new LayerManager(new LayerFactory()));
            window.Run();
        }
    }
}
