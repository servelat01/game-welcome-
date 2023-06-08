using System;

namespace game_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Люсьен", 1, 100, 1500);
            Skelet skelet = new Skelet("Костантин", 20, 500);
            Ork ork = new Ork("Ляррррва", 40, 700);
            Wizard wizard = new Wizard("Якубович", 55, 850);

            Text text = new Text();
            text.Welcome();
        }
    }
}
