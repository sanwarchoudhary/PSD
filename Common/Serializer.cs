using System.IO;
using System.Xml.Serialization;

namespace PDC.Common
{
    /// <summary>
    /// This class is used for Serialzing and Deserialize the XML
    /// </summary>

    public sealed class Serializer
    {
        private static Serializer instance = null;
        private static readonly object obj = new object();

        private Serializer()
        {

        }
        public static Serializer Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new Serializer();
                        }
                    }
                }
                return instance;
            }
        }

        /// <summary>
        /// Method to get Deserialized object.
        /// </summary>
        /// <typeparam name="T">Type parameter</typeparam>
        /// <param name="input">input xml string</param>
        /// <returns></returns>
        public T Deserialize<T>(string input) where T : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }

        /// <summary>
        /// Method to get Serialized .
        /// </summary>
        /// <typeparam name="T">Typed parameter</typeparam>
        /// <param name="ObjectToSerialize">input object of type T</param>
        /// <returns></returns>
        public string Serialize<T>(T ObjectToSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, ObjectToSerialize);
                return textWriter.ToString();
            }
        }
    }
}
