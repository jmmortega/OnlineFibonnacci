using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;

namespace Fibonacci
{
    public class LoadAlgorithms
    {
        private const string c_envelopClass = "using System.Collections.Generic; public class Fibonacci{";


        private const string c_tagStart = "lang csharp>";
        private const string c_tagEnd = "&lt;/lang>";

        public const string c_Tail_Recursive_Url = "http://rosettacode.org/mw/index.php?title=Fibonacci_sequence&action=edit&section=53";
        public const string c_Tail_Recursive_Name = "Tail Recursive";
                
        private const string c_LesserThanCharacter = "&lt;";

        public string Load(string url)
        {
            WebClient wc = new WebClient();

            string html = wc.DownloadString(url);

            int start = html.IndexOf(c_tagStart) + c_tagStart.Length;
            int end = html.LastIndexOf(c_tagEnd) - html.IndexOf(c_tagStart) - c_tagEnd.Length -2;

            string code = html.Substring(start, end).Replace(c_LesserThanCharacter, "<").Replace("ulong", "long");

            return c_envelopClass + code + "}";
        }

    }
}
