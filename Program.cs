using System;

namespace RGBtoHEX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to convert RGB to Hex values\n");
            Console.Write("\nType RGB value in a format like this: rgb(255, 128 , 64) ");
            string colorRGB = Console.ReadLine();

            string[] hexPreparation = colorRGB.Split(',');
            string[] hexPreparation2 = new string[hexPreparation.Length];

            for (int i = 0; i < hexPreparation.Length; i++)
            {
                hexPreparation2[i] = hexPreparation[i].Trim('r', 'g', 'b', '(', ',', ' ', ')');

            }

            int red = int.Parse(hexPreparation2[0]);
            string redAsHex = ConvertIntToHex(red);
            int green = int.Parse(hexPreparation2[1]);
            string greenAsHex = ConvertIntToHex(green);
            int blue = int.Parse(hexPreparation2[2]);
            string blueAsHex = ConvertIntToHex(blue);
            Console.WriteLine($"\n\n#{redAsHex}{greenAsHex}{blueAsHex}\n");

        }

        private static string ConvertIntToHex(int colorValue)
        {
            int numberOf16s = colorValue / 16;
            int remainder = colorValue % 16;
            // Calculate the hex values for each
            string hexValue = "";

            if (numberOf16s >= 10)
            {
                hexValue += ConvertBetween10And15ToHex(numberOf16s);
            }
            else
            {
                hexValue += numberOf16s.ToString();
            }

            if (remainder >= 10)
            {
                hexValue += ConvertBetween10And15ToHex(remainder);
            }
            else
            {
                hexValue += remainder.ToString();
            }

            return hexValue;
        }
        private static char ConvertBetween10And15ToHex(int between10and15)
        {
            return between10and15 switch
            {
                10 => 'a',
                11 => 'b',
                12 => 'c',
                13 => 'd',
                14 => 'e',
                15 => 'f',
                _ => 'z',
            };
        }

    }
}
