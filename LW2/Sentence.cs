using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace LW2
{
    class Sentence
    {
        public string sent;
        public Sentence(string sent)
        {
            this.sent = sent;
        }

        public string RemovePunctuation()
        {
            string str = String.Join("", sent.Where(w => !char.IsPunctuation(w)).Select(s => s));
            return str;
        }
        public void RemoveGap()
        {
            while (sent.Contains("  "))
                sent = sent.Replace("  ", " ");
        }

        public string myInsert(int number, string word)
        {
            string result = sent.Insert(number, word);
            return result;
        }

        public string myRemove(int num1, int num2)
        {
            string result1 = sent.Remove(num1, num2);
            return result1;
        }

        public string myRemove(int number)
        {
                string toDel = "";             
                string[] parts = sent.Split(' ');

                for (int i = 0; i < parts.Length; i++)
                {
                    if (i == number-1)
                    {
                        toDel = parts[i]; 
                    }
                } 
                string str = sent.Replace(toDel, "");
            return str;
        }

        public int CountLetters()
        {
            sent = Regex.Replace(sent, "[0-9]", "", RegexOptions.IgnoreCase);
            int count = RemovePunctuation().Replace(" ", string.Empty).Count();
            return count;
        }

        public int CountWords()
        {
            RemoveGap();        

            int count = RemovePunctuation().Split(' ').Count();
            return count;
        }

        public string LongestWord()
        {
            RemoveGap();

            string longestWord = "";
            string[] array = RemovePunctuation().Split(' ').ToArray();
            foreach (var str in array)
            {
                if (str.Length >= longestWord.Length)
                    longestWord = str;
            }
            return longestWord;
        }

        public string ShortestWord()
        {
            string shortestWord = LongestWord();

            RemoveGap();

            string[] array = RemovePunctuation().Split(' ').ToArray();
            foreach (var str in array)
            {
                if (str.Length <= shortestWord.Length)
                    shortestWord = str;
            }

            return shortestWord;
        }

        public bool Contains(string item)
        {
            List<string> list = RemovePunctuation().Split(' ').ToList();
            bool result = list.Contains(item);
            return result;
        }

        public string SearchNumberWord(int number)
        {                            
                string res = "";             
                string[] parts = sent.Split(' ');

                for (int i = 0; i < parts.Length; i++)
                {
                    if (i == number-1)
                    {
                        res = parts[i]; 
                    }
                } 
                
            return res;          
        }

        public bool Equality(string str)
        {
            if (sent==str)
            {
                return true;
            }
            return false;
        }

        public void SaveJson()
        {
            string json = JsonSerializer.Serialize(sent);           
            File.WriteAllText("D:\\с#\\LW2\\file.json", json);
            Console.WriteLine("Збережено у JSON файл");
        }    
    }
}
