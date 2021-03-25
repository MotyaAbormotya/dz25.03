using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int quantityLetter1 = 0;
            int quantityLetter2 = 0;
            int quantityDigit = 0;
            int quantityWords = 0;
            CountingVariables(text, ref quantityLetter1, ref quantityLetter2, ref quantityDigit, ref quantityWords);
            Console.WriteLine("Слова -" + quantityWords + " " + "Согласные -" + " " + quantityLetter1 + " " + "Гласные -" + " " + quantityLetter2 + " " + "Цифры -" + " " + quantityDigit);
            Console.ReadKey();

        }

        public static void CountingVariables(string text, ref int quantityLetter1, ref int quantityLetter2, ref int quantityDigit, ref int quantityWords)
        {

            string consonant = "цкнгшщзхфвпрлджчсмтб";
            string vowel = "юияоаыйуеъэ";

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]) == true)
                {
                    quantityDigit++;
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < consonant.Length; j++)
                {
                    if (text[i] == consonant[j])
                    {
                        quantityLetter1++;
                    }
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < vowel.Length; j++)
                {
                    if (text[i] == vowel[j])
                    {
                        quantityLetter2++;
                    }
                }
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]) == true)
                    {
                    if (i + 1 < text.Length)
                    {
                        if (char.IsLetter(text[i + 1]) == false)
                        {
                            quantityWords++;
                        }
                    }
                }
            }
        }
    }
}

