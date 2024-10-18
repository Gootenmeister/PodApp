using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PodApp // trelagersarkitektur - behövs annan namespace eller hur länkar man olika projs?
{
    [XmlSerializerAssembly] // kolla om rätt serializer
    public class XMLCer
    {

        public void WriteXML()
        {



            ReadXML(); // laddar om efter den har skrivit någon ny data
        }

        public void ReadXML()
        {

        }


    }
}
