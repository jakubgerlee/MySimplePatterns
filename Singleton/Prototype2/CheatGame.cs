
namespace Prototype2
{
    public class CheatGame : Game
    {
        public override Game Clone()
        {
            var clonedVersion = this.MemberwiseClone() as CheatGame;
            clonedVersion.Player = new Player();
            clonedVersion.Player.Name = this.Player.Name;
            clonedVersion.Player.Type = this.Player.Type;

            return clonedVersion as Game;
        }
    }
}
// zeby tego uniknac  musimy stworzyc kopie do referencji nowo stworzonego obiektu