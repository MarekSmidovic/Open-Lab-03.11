using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            string resrt = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                resrt += str[i].ToString();
            }
            if (resrt == str)
                return true;
            else
                return false;       //    
        } 
    }
}
