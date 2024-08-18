using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// Target Client requesting, this is what client wants to use.
    /// </summary>
    public interface IJsonParser<T>
    {
        T Parse(string json);
        string ConvertToJson(T obj);
    }
}
