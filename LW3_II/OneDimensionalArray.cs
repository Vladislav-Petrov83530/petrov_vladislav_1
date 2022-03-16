using System;

namespace LW3_II
{
    class OneDimensionalArray : Array 
    {
        public override int[] IntArray1 { get ; set ; }
        //public sealed override int[,] IntArray2 { get; set; }
        //public sealed override int[,,] IntArray3 { get; set; }
        
        int length = 0;
        public override void AddElement(Element el)
        {
            for (int i = length; i < IntArray1.Length; i++)
            {
                if (IntArray1[i] == 0)
                {
                    IntArray1[i] = el.value;
                    length++;
                    break;
                }
            }         
        }
        
        public override void CreateArray(int length)
        {
            IntArray1 = new int[length];
        }

        public override void Show()
        {
            Console.WriteLine("Масив:");

            foreach (int i in IntArray1)
                Console.Write("{0} ", i);
            Console.WriteLine();
        }

        public static  OneDimensionalArray operator +(OneDimensionalArray ar1, OneDimensionalArray ar2)
        {
            if (ar1.length == ar2.length)
            {
                OneDimensionalArray ar3 = new OneDimensionalArray();
                ar3.CreateArray(ar1.length);
                Console.WriteLine("Сума масивів:");
                for (int i = 0; i < ar1.length; i++)
                {
                    ar3.IntArray1[i] = ar1.IntArray1[i] + ar2.IntArray1[i];
                }
                return ar3;
            }
            else
            {
                Console.WriteLine("Помилка!Кількість елментів у масивах має бути однаковою");
                OneDimensionalArray ar4 = new OneDimensionalArray();
                ar4.CreateArray(ar1.length);
                for (int i = 0; i < ar1.length; i++)
                {
                    ar4.IntArray1[i] = 0;
                }
                return ar4;
            }
        }

        public static OneDimensionalArray operator -(OneDimensionalArray ar1, OneDimensionalArray ar2)
        {
            if (ar1.length == ar2.length)
            {
                OneDimensionalArray ar3 = new OneDimensionalArray();
                ar3.CreateArray(ar1.length);
                Console.WriteLine("Різниця масивів:");
                for (int i = 0; i < ar1.length; i++)
                {
                    ar3.IntArray1[i] = ar1.IntArray1[i] - ar2.IntArray1[i];
                }
                return ar3;
            }
            else
            {
                Console.WriteLine("Помилка!Кількість елментів у масивах має бути однаковою");
                OneDimensionalArray ar4 = new OneDimensionalArray();
                ar4.CreateArray(ar1.length);
                for (int i = 0; i < ar1.length; i++)
                {
                    ar4.IntArray1[i] = 0;
                }
                return ar4;
            }
        }

        public static OneDimensionalArray operator *(OneDimensionalArray ar,int scal)
        {
            Console.WriteLine("Різниця масивів:");
            for (int i = 0; i < ar.length; i++)
            {
                ar.IntArray1[i] *=scal ;
            }
            return ar;
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < IntArray1.Length; i++)
                str += IntArray1[i] + " ";
            return str;
        }

        public override bool Equals(object obj)
        {
            if (obj==null)
            {
                return false;
            }
            OneDimensionalArray ar = obj as OneDimensionalArray;
            if (ar as OneDimensionalArray==null)
            {
                return false;
            }
            return ar.IntArray1 == this.IntArray1;
        }

        public override int GetHashCode()
        {
            if (IntArray1 == null) 
                return 0;

            if (IntArray1.Length== 0)
                return -1;

            int hash = 5;
            for (int i = 0; i < IntArray1.Length; i++)
                hash = 31 * hash + IntArray1[i].GetHashCode();
             
            return hash;
        }
    }
}
