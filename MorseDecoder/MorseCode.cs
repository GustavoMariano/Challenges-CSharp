using System;

namespace MorseDecoder
{
    public class MorseCode
    {
        //See the image "Morse Code Translator" that is in the project.
        //See the image "Morse Code Translator" that is in the project.
        //See the image "Morse Code Translator" that is in the project.

        /* 
         * Background You've started work as morse code translator. Unfortunately some of the signals aren't as distinguishable as others and there are times where a . seems indistinguishable from -. In these cases you write down a ? so that you can figure out what all the posibilities of that letter for that word are later.
         * Task Write a function possibilities that will take a string signals and return an array of possible characters that the Morse code signals could represent.
         * 
         * Specification Challenge.Possibilities(signals) Parameters signals: string - The Morse code signals that needs to be parsed. The may contain one or more unknown signals (?).
         * Return Value List - The list of possible letters for the given group of signals. Letters will always be ordered from how they appear on the chart, from left to right.
         * Constraints There will be no more than 3 characters within signals.
         * 0 - 3 unknown signals may be given. */

        //See the image "Morse Code Translator" that is in the project.
        //See the image "Morse Code Translator" that is in the project.
        //See the image "Morse Code Translator" that is in the project.

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
