using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SSH_Panel_V1
{
    public class XmlSave
    {
        public static void SaveData(Object IClass, string filename)
        {
            StreamWriter writer = null;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer((IClass.GetType()));
                writer = new StreamWriter(filename);
                xmlSerializer.Serialize(writer, IClass);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                    writer = null;
                }
            }
        }
    }
    public class XmlLoad<T>
    {
        public static Type type;
        public XmlLoad()
        {
            type = typeof(T);
        }

        public T LoadData(string filename)
        {
            T result;
            XmlSerializer xmlSerializer = new XmlSerializer(type);
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
            result = (T)xmlSerializer.Deserialize(fs);
            fs.Close();
            return result;
        }
    }
}
