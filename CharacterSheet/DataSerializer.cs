using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace CharacterSheet
{
    static class DataSerializer<T>
    {
        public static void Serialize(string FileName, T data)
        {
            XmlSerializer Serializer = new XmlSerializer(typeof(T));

            TextWriter writer = new StreamWriter(Environment.CurrentDirectory + 
                "../Saves/" + FileName + ".xml");

            Serializer.Serialize(writer, data);
            writer.Close();
        }

        public static T Deserialize(string filename)
        {
            T data;

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            TextReader reader = new StreamReader(Environment.CurrentDirectory + 
                "../Saves/" + filename + ".xml");

            data = (T)serializer.Deserialize(reader);

            reader.Close();

            return data;
        }
    }
}
