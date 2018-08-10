﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class PanelHouse : AbstractHouse
    {
        public override void BuildFloor()
        {
            Console.WriteLine("Build 9 floors");
        }

        public override void BuildRoof()
        {
            Console.WriteLine("Build panel roof");
        }

        public override void BuildWalls()
        {
            Console.WriteLine("Build panel walls");
        }
    }
}
