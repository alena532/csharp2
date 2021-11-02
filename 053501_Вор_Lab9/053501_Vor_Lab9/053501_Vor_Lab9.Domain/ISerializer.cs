using System;
using System.Collections;
using System.Collections.Generic;
namespace _053501_Vor_Lab9.Domain
{
    public interface ISerializer
    {
        IEnumerable<Airport> DeSerializeByLINQ(string fileName);
        IEnumerable<Airport> DeSerializeXML(string fileName);
        IEnumerable<Airport> DeSerializeJSON(string fileName);
        void SerializeByLINQ(IEnumerable<Airport> xxx, string fileName);
        void SerializeXML(IEnumerable<Airport> xxx, string fileName);
        void SerializeJSON(IEnumerable<Airport> xxx, string fileName);

    }
}
