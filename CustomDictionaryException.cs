using System;

namespace KoreanHanjaDictionary
{
    public class CustomDictionaryException : Exception
    {
        public CustomDictionaryException(string message) : base(message)
        {
        }
    }
}