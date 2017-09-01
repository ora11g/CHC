using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace CHCIS.P.WebApi
{
    public static class SerializationHelper
    {
        /// <summary>
        /// The empty XML serializer namespace
        /// </summary>
        public static readonly XmlSerializerNamespaces EmptyXmlSerializerNamespace = new XmlSerializerNamespaces(new[] { new XmlQualifiedName("") });

        /// <summary>
        /// Deserializes the json.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonString">The json string.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">jsonString</exception>
        public static T DeserializeJson<T>(string jsonString)
        {
            if (string.IsNullOrEmpty(jsonString))
            {
                throw new ArgumentNullException("jsonString");
            }

            return DeserializeJson<T>(new MemoryStream(Encoding.UTF8.GetBytes(jsonString)));
        }

        /// <summary>
        /// Deserializes the json.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonStream">The json stream.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">jsonStream</exception>
        public static T DeserializeJson<T>(Stream jsonStream)
        {
            var jsonSerializer = new DataContractJsonSerializer(typeof(T));

            if (jsonStream == null)
            {
                throw new ArgumentNullException("jsonStream");
            }

            return (T)jsonSerializer.ReadObject(jsonStream);
        }

        /// <summary>
        /// Serializes to json string.
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <returns></returns>
        public static string SerializeToJsonString(object obj)
        {
            var jsonSerializer = new DataContractJsonSerializer(obj.GetType());
            using (MemoryStream buffer = new MemoryStream())
            {
                jsonSerializer.WriteObject(buffer, obj);
                return Encoding.UTF8.GetString(buffer.ToArray());
            }
        }

        /// <summary>
        /// Deserializes the XML.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlString">The XML string.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">xmlString</exception>
        public static T DeserializeXml<T>(string xmlString)
        {
            if (string.IsNullOrEmpty(xmlString))
            {
                throw new ArgumentNullException("xmlString");
            }

            return DeserializeXml<T>(new MemoryStream(Encoding.UTF8.GetBytes(xmlString)));
        }

        /// <summary>
        /// Deserializes the XML.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlStream">The XML stream.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">xmlStream</exception>
        public static T DeserializeXml<T>(Stream xmlStream)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));

            if (xmlStream == null)
            {
                throw new ArgumentNullException("xmlStream");
            }

            return (T)xmlSerializer.Deserialize(xmlStream);
        }

        /// <summary>
        /// Serializes to XML string.
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <returns></returns>
        public static string SerializeToXmlString(object obj)
        {
            XmlSerializer xs = new XmlSerializer(obj.GetType());
            using (MemoryStream buffer = new MemoryStream())
            {
                xs.Serialize(buffer, obj, EmptyXmlSerializerNamespace);
                return Encoding.UTF8.GetString(buffer.ToArray());
            }
        }

    } 
}