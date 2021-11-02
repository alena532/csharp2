using System;
using System.IO;
using System.Linq;

//using System.Text.Json;
using System.Xml.Linq;
using System.Xml.Serialization;

using System.Collections.Generic;
using _053501_Vor_Lab9.Domain;
using Newtonsoft.Json;

namespace Serializer
{
    public class Serializer1 : ISerializer
    {
        public IEnumerable<Airport> DeSerializeByLINQ(string fileName)
        {
            XDocument xdoc = XDocument.Load(fileName);

            foreach (var AirportElement in xdoc.Element("airports").Elements("airport"))
            {
                XAttribute nameAttribute = AirportElement.Attribute("name");
                Airport airport = new Airport(nameAttribute.Value);

                foreach (var bookElement in AirportElement.Elements("runway"))
                {
                    XAttribute runwayLength = bookElement.Attribute("length");
                    
                    airport.Runways.Add(new RunWay(Convert.ToInt32(runwayLength.Value)));
                }

                yield return airport;
            
            }
        }

        public IEnumerable<Airport> DeSerializeJSON(string fileName)
        {
            using (StreamReader file = File.OpenText(fileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<Airport> airports = (List<Airport>)serializer.Deserialize(file, typeof(List<Airport>));
                return airports;
            }
        }

        public IEnumerable<Airport> DeSerializeXML(string fileName)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Airport>));
            
                using (FileStream fs = new FileStream("persons.xml", FileMode.Open))
                {
                    return (List<Airport>)formatter.Deserialize(fs);
                }
        }

        public void SerializeByLINQ(IEnumerable<Airport> xxx, string fileName)
        {
            XDocument doc = new XDocument();
            XElement header = new XElement("airports");
            foreach(var airport in xxx)
            {
                XElement el = new XElement("airport");
                el.Add(new XAttribute("name", airport.Name));
                foreach(var runways in airport.Runways)
                {
                    XElement ways = new XElement("runway");
                    ways.Add(new XAttribute("length", runways.Length));
                    el.Add(ways);
                }
                header.Add(el);
            }
            doc.Add(header);
            doc.Save(fileName);
        }

        public void SerializeJSON(IEnumerable<Airport> xxx, string fileName)
        {
            using (StreamWriter file = File.CreateText(fileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, xxx);
            }
        }
        public void SerializeXML(IEnumerable<Airport> xxx, string fileName)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Airport>));
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, xxx);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
