using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLClasses
{
    public class Dock
    {        
        public int DockId { get; set; }

        public string DockName { get; set; }
        
        public bool WaterService { get; set; }

        public bool ElectricalService { get; set; }
    }
}
