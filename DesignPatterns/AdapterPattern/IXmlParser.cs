using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// Adaptee (existing logic/ logic available in current system)
    /// </summary>
    public interface IXmlParser<T>
    {
        T Parse(string data);
        string ConvertToXml(T data);
    }
}
