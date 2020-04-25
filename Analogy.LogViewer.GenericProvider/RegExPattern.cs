using System;

namespace Analogy.LogViewer.GenericProvider
{
    [Serializable]
    public class RegExPattern
    {
        public string Pattern { get; set; }
        public string DateTimeFormat { get; set; }
        public bool IsSet => !string.IsNullOrEmpty(Pattern) && !string.IsNullOrEmpty(DateTimeFormat);
        public RegExPattern()
        {
            Pattern = string.Empty;
            DateTimeFormat = "yyyy-MM-dd HH:mm:ss,fff";

        }
        public RegExPattern(string pattern, string dateTimeFormat)
        {
            Pattern = pattern;
            DateTimeFormat = dateTimeFormat;
        }
    }
}
