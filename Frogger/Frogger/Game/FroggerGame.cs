using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogger.Game
{
    

    public class FroggerGame
    {
        public uint Score { get; private set; }

        public uint ScreenWidth { get; private set; }
        public uint ScreenHeight { get; private set; }
        public uint ObjectWidth { get; private set; }
        public uint ObjectHeight { get; private set; }

        Frog player;

        public FroggerGame(uint screenWidth, uint screenHeight, uint objectWidth, uint objectHeight)
        {
            ScreenHeight = screenHeight;
            ScreenWidth = screenWidth;

            ObjectWidth = objectWidth;
            ObjectHeight = objectHeight;
        }

        public void Reset ()
        {

        }

        public void Left ()
        {
            player.Left();
        }

        public void Right ()
        {
            player.Right();
        }

        public void Up()
        {
            player.Up();
        }

        public void Down()
        {
            if (player.XPosition > 0)
                player.Down();
        }

        public void Jump()
        {

        }

        void UpdatePositions ()
        {

        }
    }
}
