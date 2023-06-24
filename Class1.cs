using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseTranslite
{
    internal class MorseTranslite
    {
        private Dictionary<char, string> morseAlphabet = new Dictionary<char, string>()
        {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."},
            {'F', "..-."}, {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"},
            {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."}, {'O', "---"},
            {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
            {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"},
            {'Z', "--.."}, {'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"},
            {'4', "....-"}, {'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."},
            {'9', "----."}, {' ', "/"}
        };

        private Dictionary<string, char> reverseMorseAlphabet;

        public MorseTranslite()
        {
            reverseMorseAlphabet = new Dictionary<string, char>();

            foreach (KeyValuePair<char, string> entry in morseAlphabet)
            {
                reverseMorseAlphabet[entry.Value] = entry.Key;
            }
        }

        public string TranslateToMorse(string text)
        {
            string translatedText = "";

            foreach (char character in text.ToUpper())
            {
                if (morseAlphabet.ContainsKey(character))
                {
                    translatedText += morseAlphabet[character] + " ";
                }
            }

            return translatedText.Trim();
        }

        public string TranslateToText(string morseText)
        {
            string[] morseWords = morseText.Split(new[] { " / " }, StringSplitOptions.None);
            string translatedText = "";

            foreach (string morseWord in morseWords)
            {
                string[] morseLetters = morseWord.Split(' ');

                foreach (string morseLetter in morseLetters)
                {
                    if (reverseMorseAlphabet.ContainsKey(morseLetter))
                    {
                        translatedText += reverseMorseAlphabet[morseLetter];
                    }
                }

                translatedText += " ";
            }

            return translatedText.Trim();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MorseTranslite translator = new MorseTranslite();

            Console.WriteLine("Введіть текст для перекладу в азбуку Морзе:");
            string inputText = Console.ReadLine();

            string translatedToMorse = translator.TranslateToMorse(inputText);
            Console.WriteLine("Результат перекладу в азбуку Морзе:");
            Console.WriteLine(translatedToMorse);

            Console.WriteLine("Введіть текст для перекладу з азбуки Морзе:");
            string morseInputText = Console.ReadLine();

            string translatedToText = translator.TranslateToText(morseInputText);
            Console.WriteLine("Результат перекладу:");

        }
    }
}
