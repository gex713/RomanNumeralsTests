using System;

namespace DoRomanNumerals
{
    public class ConvertArabicToRoman
    {
        public string Convert(int arabic)
        {
            var romanNumeral = "";
            var remaining = arabic;

            if (arabic == 4 )
            {
                romanNumeral = "IV";
            }
            if (arabic >= 5)
            {
                romanNumeral += "V";
                remaining -= 5;
            }

            if (remaining <= 3)
            {
                for (var i = 0; i < remaining; i++)
                    romanNumeral += "I";
            }
            return romanNumeral;
        }
    }
}
