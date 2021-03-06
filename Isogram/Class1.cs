﻿using System;
using System.Linq;

namespace Isogram
{
    public class Class1
    {
        public static bool IsIsogram(string str)
        {
            string rotate = "";
            if (str == null)
            {
                return false;
            }
            else
            {
                foreach (char c in str)
                {
                    if (char.IsLetter(c))
                    {
                        rotate += c;
                    }
                }
            }
            var count = rotate.Distinct().Count();
            var length = rotate.Count();
            if(count == length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
