using System;
using System.IO;
using System.Text.Json;

namespace LW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Sentence str1 = new Sentence("Hello my friends."); 
            Console.WriteLine(str1.sent);

            Console.WriteLine();
            Console.Write("Додати або вставити слово: ");
            str1.myInsert(9, "dear ");
            Console.WriteLine(str1.sent);

            Console.Write("Видалити слово: ");
            str1.myRemove(6, 3);
            Console.WriteLine(str1.sent);

            Console.Write("Видалити слово: ");
            str1.myRemove(3);
            Console.WriteLine(str1.sent);

            Console.Write("Кількість літер в реченні: ");
            int num = str1.CountLetters();
            Console.WriteLine(num);

            Console.Write("Кількість слів в реченні: ");
            int num2 = str1.CountWords();
            Console.WriteLine(num2);

            Console.Write("Найдовше слово: ");
            string str4 = str1.LongestWord();
            Console.WriteLine($"Longest: {str4}");

            Console.Write("Найкоротше слово: ");
            string str5 = str1.ShortestWord();
            Console.WriteLine($"Shortest: {str5}");

            Console.Write("Пошук слова в реченні: ");
            bool result = str1.Contains("Hello");
            Console.WriteLine(result);

            bool result1 = str1.Contains("Helloo");
            Console.WriteLine(result1);

            Console.Write("Пошук слова за номером: ");
            string result2 = str1.SearchNumberWord(2);
            Console.WriteLine(result2);

            Console.Write("Рівність двох речень: ");
            string str6 = "Hello my friends.";
            bool result3 = str1.Equality(str6);
            Console.WriteLine(result3);

            str1.SaveJson();

            string path = "D:\\с#\\LW2\\fileForRead.json";

            Console.Write("Створено новий екземпляр класу Sentence: ");
            Sentence str = NewSentence(path);
            Console.WriteLine(str.sent);
        }
        public static Sentence NewSentence(string path)
        {
            string json = File.ReadAllText(path);
            Sentence str = new Sentence(JsonSerializer.Deserialize<string>(json));            
            return str;
        }
    }
}
