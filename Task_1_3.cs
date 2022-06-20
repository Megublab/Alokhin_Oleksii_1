using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_semestr.Laba_1
{
    internal class Task_1_3
    {
        /*Дана послідовність додатніх цілих чисел. 
         * Обробляючи тільки непарні числа, 
         * отримати послідовність їх строкових уявлень і впорядкувати її в лексикографічному порядку по зростанню. 
         * - Select, SelectMany, Where
         * */
        public static void Start()
        {
            List<int> lis = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                lis.Add(i);
            }
            
            //var result = from i in lis
            //             where i % 2 != 0 && lis.Contains(i)
            //             select i;
            
            var result = lis.Where(x => x % 2 !=0).ToList();


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
               
        }
    }
}
