using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            int i,j,k;
            int key;
            int[] numbers = { 1, 2, 4, 3,5,0};
           
            for (j = numbers.Length - 1; j<=2; j--) // со второго элемента цикл. Счетчик цикла =2 
            {
                key = numbers[j]; //в качсестве ключа - текущий элемент 
                i = j - 1; // Вспомогательный счетчик - на единицу меньше основного 
                while (i>0 && numbers[i]>key) //пока вспомогательный счетчик больше 0 и текущий элемент больше кллюча  
                {
                    numbers[i + 1] = numbers[i]; // меняем следующий с предыдущим 
                    i = j - 1; // возвращаем вспомогательный счетчик на единицу назад 
                    numbers[i] = key;// вставляем в массив элемент ключа 
                }
            }
            // вывод массива 
            for (k = numbers.Length - 1; k >0 ; k--)
            {
                Console.WriteLine(k);
            }
            Console.ReadKey();


        }
    }
}
