using System;
using System.Collections.Generic;

Dictionary<char, string> morseAlphabet = new Dictionary<char, string>()
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

Console.WriteLine("Введіть текст для перекладу в азбуку Морзе:");

string inputText = Console.ReadLine().ToUpper();

string translatedText = TranslateToMorse(inputText);
Console.WriteLine("Результат перекладу:");

Console.WriteLine(translatedText);

Console.ReadLine();

string TranslateToMorse(string text)
{
    string translatedText = "";

    foreach (char character in text)
    {
        if (morseAlphabet.ContainsKey(character))
        {
            translatedText += morseAlphabet[character] + " ";
        }
    }

    return translatedText.Trim();
}
