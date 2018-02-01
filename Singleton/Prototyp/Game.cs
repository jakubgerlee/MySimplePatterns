using System.Media;

namespace Prototyp
{
    public abstract class Game
    {
        public string Name { get; set; }
        public string Points { get; set; }
        public Player Player { get; set; }

        public abstract Game Clone();
    }
}
