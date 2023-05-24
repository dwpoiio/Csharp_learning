using System;
namespace String1
{
    public class SummaryText
    {
        public static string Method(string text, int maxLength = 20)
        {
            return SummerizeText(text, maxLength);
        }
        static string SummerizeText(string sentence, int maxLength)
        {
            if (sentence.Length < maxLength)
            return sentence;
           
            var words = sentence.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                break;
            }

            return String.Join(" ", summaryWords) + "...";
        
        }
    }
}

