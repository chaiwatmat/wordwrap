using System;

namespace Chaiwatmat.WordWrap
{
    public class WordWrap
    {
        public string Wrap(string text, int maxLength){
            var length = text.Length;

            return text.Length > maxLength ? text.Substring(0, maxLength) + "..." : text;
        }
    }
}
