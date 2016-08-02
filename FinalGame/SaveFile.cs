using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace FinalGame
{
    public static class SaveFile
    {
        // Takes a class ands it coponents and converts it to Xml
        public static void SerializeXml<T>(string s, T t , string path) {
            if (Directory.Exists(path)) {
                using (FileStream fs = File.Create(path + s + ".xml")) {
                    XmlSerializer serialier = new XmlSerializer(typeof(T));
                    fs.Close();
                }
            }
        }
        //allows me to use the information in the file to referrer to later when needed
        public static T DeserializeXml<T>(string s) {
            T t; 

            using ( FileStream fs = File.OpenRead(s + "xml")) {
                XmlSerializer deserialize = new XmlSerializer(typeof(T));
                t = (T)deserialize.Deserialize(fs);
                fs.Close();
            }
            return t;

        }
    }
}
