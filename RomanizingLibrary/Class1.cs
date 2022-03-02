using System;


namespace RomanizingLibrary
{
    public class Program
    {
        public string convertRoman(int number)
        {
         //   string result = "";
            if ((number < 0) || (number > 3000)) throw new ArgumentOutOfRangeException("Number must be atleast 0 but not more than 3000");
            if (number < 1) return string.Empty;

            if (number >= 1000) return "M" + convertRoman(number - 1000);
            if (number >= 500)
            {
                if (number >= 900) return "CM" + convertRoman(number - 900);
                if (number >= 500) return "D" + convertRoman(number - 500);
            }
               
            if (number >= 100)
            {
                if (number >= 400) return "CD" + convertRoman(number - 400);
                if (number >= 100) return "C" + convertRoman(number - 100);
            }

            if (number >= 50)
            {
                if (number >= 90) return "XC" + convertRoman(number - 90);
                if (number >= 50) return "L" + convertRoman(number - 50);
            }

            if (number >= 10)
            {
                if (number >= 40) return "XL" + convertRoman(number - 40);
                if (number >= 10) return "X" + convertRoman(number - 10);


            }

            if (number >= 5)
            {
                if (number >= 9) return "IX" + convertRoman(number - 9);
                if (number >= 5) return "V" + convertRoman(number - 5);

            }


            if (number >= 4) return "IV" + convertRoman(number - 4);
            if (number >= 1)
            {
                if (number >= 4) return "IV" + convertRoman(number - 4);
                if (number >= 1) return "I" + convertRoman(number - 1);
            }
            return "";
        }

            //   public class Class1
            //   {
            //   }
    }
}