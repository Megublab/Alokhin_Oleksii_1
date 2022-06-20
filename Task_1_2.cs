using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_semestr.Laba_1
{
    /*
    Написати програму для пошуку однакових елементів у двох словниках.
    Вхідний словник: {'key1': 1, 'key2': 3, 'key3': 2}, { 'key1': 1, 'key2': 2}
    Результат програми: key1: 1 is present in both x and y
    */

    internal class Task_1_2
    {
        public static void Start()
        {
            Dictionary<string, int> dict_1 = new Dictionary<string, int>();
            Dictionary<string, int> dict_2 = new Dictionary<string, int>();
            dict_1.Add("key1", 1);
            dict_1.Add("key2", 3);
            dict_1.Add("key3", 2);
            dict_2.Add("key1", 1);
            dict_2.Add("key2", 2);
            foreach (var item_1 in dict_1)
            {
                foreach (var item_2 in dict_2)
                {
                    if(item_1.Value == item_2.Value)
                    {
                        if(item_1.Key == item_2.Key)
                        {
                            Console.WriteLine($"{item_1.Value} contains in both dictionaries");
                        }
                    }
                }
            }
        }
    }
}
