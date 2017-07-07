using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace bfClassLib
{
    class Correction
    {
        public string Correct(string text)
        {
            string NewTxt = null;

            NewTxt = text.ToLower();
            NewTxt += Regex.Replace(text, "\t(.)\\1{1,}", "$1");
            
            return NewTxt;
        }
    }
}
