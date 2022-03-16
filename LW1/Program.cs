
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LW1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            string path = "D:\\с#\\LW1\\sometext.txt";
            Counter(ReadFile(path));        
            Console.ReadLine();
        }

       static public List<char> ReadFile(string path)
       {
            List<char> symbol = new List<char>();
            StreamReader reader = new StreamReader(path);           
            string text = reader.ReadToEnd().ToLower();
            foreach (char c in text)
              symbol.Add(c);                            
            return symbol;
       }

       static public void Counter(List<char> symbol)
        {
            char[] mas_p = { 'б', 'в', 'г', 'ґ', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'я', 'ю', 'є', 'ї', 'ь' };
            char[] mas_g = { 'а', 'о', 'е', 'у', 'и', 'і' };
            int count_g = 0;
            int count_p = 0;
            
            foreach (char item in symbol)
            {
                for (int i =0; i < mas_g.Length; i++)
                    if (item == mas_g[i])
                        count_g++;

                for (int i = 0; i < mas_p.Length; i++)
                    if (item == mas_p[i])
                        count_p++;                   
            }

            Console.WriteLine($"Кількість приголосних: {count_p}, кількість голосних: {count_g}");
        }       
    }
}
