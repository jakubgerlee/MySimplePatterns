namespace Prototyp
{
    public class CheatGame : Game
    {
        public override Game Clone()
        {
            return this.MemberwiseClone() as Game;
        }
    }
}
