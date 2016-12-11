using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace The_Occasion.Models
{
    public class Class
    {

        public string BigString = "this is a string";
        public Array BigStringSplit()
        {
            string[] FullNameArray = Regex.Split(BigString, @"i").Where(s => s != string.Empty).ToArray();
            return FullNameArray;
        }
    }
}
