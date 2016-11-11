using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Engines
{
    public class EngineConfiguration
    {

        public class AreaConfiguration : EngineConfiguration
        {

            [XmlTextAttribute]
            public String AreaAttributes { get; set; }
            public bool CanvasCost { get; set; }
            public bool PhotoPaperCost { get; set; }
            public bool MountBoardCost { get; set; }
            public bool HardboardCost { get; set; }
            public bool PrinterInkCost { get; set; }
            public bool BrownPaperCost { get; set; }

            public void Save(string filename)
            {
                using (FileStream stream = new FileStream(filename, FileMode.Open))
                {
                    var XML = new XmlSerializer(typeof(AreaConfiguration));
                    XML.Serialize(stream, this);
                }
            }

            public static AreaConfiguration loadFromFile(string filename)
            {
                using (FileStream stream = new FileStream(filename, FileMode.Open))
                {
                    var XML = new XmlSerializer(typeof(AreaConfiguration));
                    return (AreaConfiguration)XML.Deserialize(stream);
                }
            }


        }

        public class VolumeConfiguration : EngineConfiguration
        {

            [XmlTextAttribute]
            public String VolumeAttributes { get; set; }
            public bool qCanvasCost { get; set; }
            public bool qPhotoPaperCost { get; set; }
            public bool qMountBoardCost { get; set; }
            public bool qHardboardCost { get; set; }
            public bool qPrinterInkCost { get; set; }
            public bool qBrownPaperCost { get; set; }

            public void Save(string filename)
            {
                using (FileStream stream = new FileStream(filename, FileMode.Append))
                {
                    var XML = new XmlSerializer(typeof(VolumeConfiguration));
                    XML.Serialize(stream, this);
                }
            }

            public static VolumeConfiguration loadFromFile(string filename)
            {
                using (FileStream stream = new FileStream(filename, FileMode.Open))
                {
                    var XML = new XmlSerializer(typeof(VolumeConfiguration));
                    return (VolumeConfiguration)XML.Deserialize(stream);
                }
            }


        }



    }
}

