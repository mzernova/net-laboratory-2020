using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class Object
    {
        protected Location position;

        protected Object (Location position)
        {
            this.position = position;
        }

        public Location Position { get => position; }
    }
}
