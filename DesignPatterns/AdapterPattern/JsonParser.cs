﻿using System.Text.Json;

namespace AdapterPattern
{
    public class JsonParser<T> : IJsonParser<T>
    {
       public T Parse(string data)
        {
            return JsonSerializer.Deserialize<T>(data);
        }
        public string ConvertToJson(T data)
        {
            return JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        }

        
    }
}
