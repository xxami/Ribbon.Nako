
using Microsoft.Xna.Framework;

namespace Ribbon.Nako
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Game g = new Game())
            {
                new GraphicsDeviceManager(g);
                g.Run();
            }
        }
	}
}
