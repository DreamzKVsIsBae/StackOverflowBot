using System;
using System.Collections.Generic;
using System.Net.Http;

namespace StackOverflowBot.StackExchange.Converters
{
    public class HttpContentConverter
    {
        public static HttpContent GetHttpContent(object instance)
        {
            var type = instance?.GetType();
            var values = new Dictionary<string, string>();

            foreach (var property in type?.GetProperties())
            {
                if (Attribute.GetCustomAttribute(property, typeof(HttpContentAttribute))
                    is HttpContentAttribute httpContentAttribute)
                {
                    string key = httpContentAttribute.Key;

                    if (string.IsNullOrEmpty(key))
                    {
                        continue;
                    }

                    if (property?.GetValue(instance) is object propertyValue)
                    {
                        values.Add(key, propertyValue.ToString());
                    }
                }
            }

            return new FormUrlEncodedContent(values);
        }
    }
}