using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class BrickHouse : AbstractHouse
    {
        public override void BuildFloor()
        {
            Console.WriteLine("Build 5 floors");
        }

        public override void BuildRoof()
        {
            Console.WriteLine("Build tiling roof");
        }

        public override void BuildWalls()
        {
            Console.WriteLine("Build brick walls");
        }
    }
}
