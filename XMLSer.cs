using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PodApp // trelagersarkitektur - behövs annan namespace eller hur länkar man olika projs?
{
    [XmlSerializerAssembly] // kolla om rätt serializer
    public class XMLSer<T>
    {

        public void WriteXML(List<Podd> poddar, string filePath )

        {
            //här sker serialiseringen.

            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            FileStream fs = new FileStream(@"xml.xml", FileMode.Append, FileAccess.Write);
            serializer.Serialize(fs, poddar);
            fs.Close();

            ReadXML(filePath); // laddar om efter den har skrivit någon ny data
        }

        //public List<T> ReadXML(List<T> poddar)
        //{
        //    //läser in xmlfilen och gör om till en <Lista> som kan printas

        //    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
        //    FileStream fs = new FileStream(@"\fil.xml", FileMode.Open, FileAccess.Read);
        //    poddar = (List<T>)serializer.Deserialize(fs, poddar); //not null knull
        //    fs.Close();
        //    return poddar;
        //}
        // Läs data från en XML-fil
        public List<T> ReadXML(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<T>();  // Om filen inte finns, returnera en tom lista
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (StreamReader reader = new StreamReader(filePath))
            {
                return (List<T>)serializer.Deserialize(reader);
            }

        }
    }
}
