using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class PrivateHouse : AbstractHouse
    {
        public override void BuildFloor()
        {
            Console.WriteLine("Build 2 floors");
        }

        public override void BuildRoof()
        {
            Console.WriteLine("Build slate foof");
        }

        public override void BuildWalls()
        {
            Console.WriteLine("Build wooden walls");
        }
    }
}
