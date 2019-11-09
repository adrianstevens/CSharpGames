using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogger.Game
{
    public class Frog : GameObject
    {
        enum Direction
        {
            Left,
            Right,
            Up,
            Down,
        }

        public Frog (uint width, uint height)
        {
            Width = width;
            Height = height;
        }

        public void Left()
        {
            XPosition -= Width;
        }

        public void Right()
        {
            XPosition += Width;
        }

        public void Up()
        {
            YPosition += Height;
        }

        public void Down()
        {
            XPosition -= Height;
        }

        public void Jump()
        {

        }
    }
}
