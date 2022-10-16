using System;
///Here we have the board of our game. Here we will create the men and the spaces for our game.
namespace Jumper
{
    public class Board {
        public Board()
        {            
        }

        public string[] Men()
        {
            string[] men = {
                "   ___"," | ___ |",
                " 0  |  0 ",
                " 0  |  0 ",
                "    O",
                "   I|I","   J L"};

                  return men;
        }
        public string[] deadMen()
        {
            string[] deadMen = {
                "    X",
                "   I|I","   J L"};

                  return deadMen;
        }
        public string[] Space()
        {
            string[] space = {
                "_ ",
                "_ ",
                "_ ",
                "_ "
            };

            return space;
        }
    }
}
