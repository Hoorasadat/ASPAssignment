using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLClasses
{
    public class SlipDock
    {
        //public int DockId { get; set; }

        public string DockName { get; set; }

        public int SlipId { get; set; }

        public int Width { get; set; }
        
        public int Length { get; set; }

        public bool WaterService { get; set; }

        public bool ElectricalService { get; set; }
    }
}
