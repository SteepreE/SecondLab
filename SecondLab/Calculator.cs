using System;

namespace SecondLab
{
    class Calculator
    {
        public static long Calculate(String str)
        {
            long result = 0;
            str = str.Replace(" ", "");

            if (String.IsNullOrEmpty(str)) return result;

            String[] elems = str.Split('+', '-');
            result = long.Parse(elems[0]);
            for (int i = 1; i < elems.Length; i++)
            {
                var value = long.Parse(elems[i]);
                result = (i % 2 == 1) ? result + value : result - value;
            }

            return result;
        }
    }
}