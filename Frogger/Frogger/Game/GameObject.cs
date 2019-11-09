using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogger.Game
{
    public abstract class GameObject
    {
        public uint XPosition { get; set; }
        public uint YPosition { get; set; }

        public uint Width { get; protected set; }
        public uint Height { get; protected set; }
    }
}
