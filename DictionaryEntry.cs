namespace KoreanHanjaDictionary
{
    public class DictionaryEntry : BaseEntry
    {
        public string Korean { get; set; }
        public string Hanja { get; set; }
        public string Definition { get; set; } 

        public string Display => $"{Korean} ({Hanja}): {Definition}";
    }
}