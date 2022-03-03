using System;

namespace MorseDecoder
{
    public class MorseCode
    {
        public static string[] Possibilities(string signals)
        {
            string validatedSignals = SignalsValidate(signals);
            string decipheredMorse = MorseDecoder(validatedSignals);
            string[] result = decipheredMorse.Split(' ');

            return result;
        }

        static string MorseDecoder(string signals)
        {
            switch (signals)
            {
                case ".-":
                    return "A";
                case "-..":
                    return "D";
                case ".":
                    return "E";
                case "--.":
                    return "G";
                case "..":
                    return "I";
                case "-.-":
                    return "K";
                case "--":
                    return "M";
                case "-.":
                    return "N";
                case "---":
                    return "O";
                case ".-.":
                    return "R";
                case "...":
                    return "S";
                case "-":
                    return "T";
                case "..-":
                    return "U";
                case ".--":
                    return "W";

                //Specials Both
                case "?":
                    return "E T";
                case "??":
                    return "I A N M";
                case "?.":
                    return "I N";
                case "?-":
                    return "A M";
                case "?-?":
                    return "R W G O";
                case "?.?":
                    return "S U D K";
                case "???":
                    return "S U R W D K G O";

                //Left
                case ".?":
                    return "I A";
                case "..?":
                    return "S U";
                case ".-?":
                    return "R W";

                //Right
                case "-?":
                    return "N M";
                case "--?":
                    return "G O";
                case "-.?":
                    return "D K";

                default:
                    return "";
            }
        }

        private static string SignalsValidate(string signals)
        {
            string validated = "";
            foreach (var letter in signals)
                if (letter != '?' && letter != '.' && letter != '-')
                    validated += "?";
                else
                    validated += letter;

            return validated;
        }
    }
}
