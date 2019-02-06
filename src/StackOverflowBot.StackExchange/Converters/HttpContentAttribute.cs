using System;

namespace StackOverflowBot.StackExchange.Converters
{
    [AttributeUsage(AttributeTargets.Property)]
    public class HttpContentAttribute : Attribute
    {
        public string Key { get; private set; }

        public HttpContentAttribute(string key)
        {
            Key = key;
        }
    }
}