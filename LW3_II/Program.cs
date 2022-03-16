using System;

/*Завдання 1
Створити додаток, який задовольняє вимогам, наведеним в завданні. Наслідування застосовувати тільки в тих завданнях,
в яких воно логічно обґрунтоване. Аргументувати належність класу кожного створюваного методу і коректно перевизначити 
для кожного класу методи Equals, GetHashCode, ToString. При виклику будь-которого методу класу,
виводити на екран текстове повідомлення.

25.Створити об'єкт класу Одновимірний масив, використовуючи класи Масив, Елемент.
Методи: створити, вивести на консоль, виконати операції (скласти, відняти, помножити).*/

namespace LW3_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Element el1 = new Element(2);
            Element el2 = new Element(2);
            Element el3 = new Element(0);
            Element el4 = new Element(7);
            Element el5 = new Element(10);

            OneDimensionalArray ar = new OneDimensionalArray();

            Console.WriteLine("Створюємо масив ar");
            ar.CreateArray(5);

            Console.WriteLine("Додаємо елементи у масив ar");
            ar.AddElement(el1);
            ar.AddElement(el2);
            ar.AddElement(el3);
            ar.AddElement(el4);
            ar.AddElement(el5);

            Console.WriteLine("Виводимо масив ar");
            ar.Show();

            OneDimensionalArray ar1 = new OneDimensionalArray();

            Console.WriteLine("\nСтворюємо масив ar1");
            ar1.CreateArray(5);

            Console.WriteLine("Додаємо елементи у масив ar1");
            el4.value = 20;
            ar1.AddElement(el1);
            ar1.AddElement(el2);
            ar1.AddElement(el3);
            ar1.AddElement(el4);
            ar1.AddElement(el5);

            Console.WriteLine("Виводимо масив ar1");
            ar1.Show();

            Console.WriteLine("\nДодаємо масиви ar та ar1");
            OneDimensionalArray ar3 = ar + ar1;
            ar3.Show();

            Console.WriteLine("\nВіднімаємо масиви ar та ar1");
            OneDimensionalArray ar4 = ar - ar1;
            ar4.Show();

            Console.WriteLine("\nМножимо масив ar на 5");
            OneDimensionalArray ar5 = ar * 5;
            ar5.Show();

            Console.WriteLine("\nМетод ToString для класу Element");
            Console.WriteLine(el1);

            Console.WriteLine("\nМетод ToString для класу OneDimensionalArray");
            Console.WriteLine(ar);

            Console.WriteLine("\nМетод ToEquals для класу Element");
            Console.WriteLine(el1.Equals(el2));

            Console.WriteLine("\nМетод GetHashCode для класу Element");
            Console.WriteLine(el1.GetHashCode());

            Console.WriteLine("\nМетод ToEquals для класу OneDimensionalArray");
            Console.WriteLine(ar.Equals(ar1));

            Console.WriteLine("\nМетод GetHashCode для класу OneDimensionalArray");
            Console.WriteLine("ar4: "+ar4.GetHashCode());
            Console.WriteLine("ar:"+ar.GetHashCode());
        }
    }
}
