using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Costing_Engine
{
    public class Configuration
    {
       public class AreaConfig
        {
            public bool Canvas { get; set; }
            public bool PhotoPaper { get; set; }
            public bool MountBoard { get; set; }
            public bool Hardboard { get; set; }
            public bool PrinterInk { get; set; }
            public bool BrownPaper{ get; set; }


        }
    }
}
