using System;

namespace SecondLab
{
    class Calculator
    {
        public static int Calculate(String str)
        {
            int result = 0;
            str = str.Replace(" ", "");

            if (String.IsNullOrEmpty(str)) return result;

            String[] elems = str.Split('+', '-');
            result = int.Parse(elems[0]);
            for (int i = 0; i < elems.Length; i++)
            {
                int value = int.Parse(elems[i]);
                result = (i % 1 == 0) ? result + value : result - value;
            }

            return result;
        }
    }
}
