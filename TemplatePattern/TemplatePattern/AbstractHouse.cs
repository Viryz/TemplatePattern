using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    abstract class AbstractHouse
    {
        public void BuildFoundation()
        {
            Console.WriteLine("Build foundation");
        }

        public abstract void BuildFloor();
        public abstract void BuildWalls();
        public abstract void BuildRoof();

        public void Build()
        {
            BuildFoundation();
            BuildFloor();
            BuildWalls();
            BuildRoof();
        }
    }
}
