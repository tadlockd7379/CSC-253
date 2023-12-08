using System;
using System.Linq;

namespace TadlockLibrary
{
    public static class TadlockLibrary
    {
        public static char[] ToCharArray(this string str)
        {
            return str.ToArray();
        }

        public static string[] DateToArray(this string str)
        {
            return str.Split('/');
        }

        public static string PhoneNumber(this string str)
        {
            char[] split = str.ToCharArray();
            return $"({split[0]}{split[1]}{split[2]})-{split[3]}{split[4]}{split[5]}-{split[6]}{split[7]}{split[8]}{split[9]}";
        }

        public static string Backwards(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static int WordCount(this string str)
        {
            return str.Split(' ').Length;
        }
    }
}
