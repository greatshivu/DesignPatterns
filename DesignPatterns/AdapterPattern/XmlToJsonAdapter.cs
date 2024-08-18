using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class XmlToJsonAdapter<T> : IJsonParser<T>
    {
        public readonly IXmlParser<T> _xparser;
        public readonly IJsonParser<T> _jparser;
        public XmlToJsonAdapter() 
        {
            _xparser = new XmlParser<T>();
            _jparser = new JsonParser<T>();
        }

        

        public T Parse(string json)
        {
            return _xparser.Parse(json);
        }
        public string ConvertToJson(T obj)
        {
            return _jparser.ConvertToJson(obj);
        }
    }
}
