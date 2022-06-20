using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_semestr.Laba_1
{
    /*
     * У колі стоять N людей, пронумерованих від 1 до N. 
     * При веденні рахунку по колу викреслюється кожна друга людина, поки не залишиться один. 
     * Скласти дві програми, що моделюють процес. Одна з програм повинна використовувати клас ArrayList, а друга - LinkedList.
     * Яка з двох програм працює швидше? Чому?
     */
    internal class Task_1_1
    {
        public static void Start()
        {
            Console.WriteLine("Enter people amount");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine();
            DateTime starttime = DateTime.Now;
            ArrayList_1(i);
            DateTime endtime = DateTime.Now;
            Console.WriteLine($"Time to complete task 1:{endtime - starttime}");
            DateTime starttime_1 = DateTime.Now;
            LinkedList_1(i);
            DateTime endtime_1 = DateTime.Now;
            Console.WriteLine($"Time to complete task 2:{endtime_1 - starttime_1}");
        }
        public static void ArrayList_1(int N)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < N; i++)
            {
                arrayList.Add(i);
            }
            int temp = 1;
            bool retro = false;
            while (arrayList.Count > 1)
            {
                if (arrayList.Count % 2 != 0 && retro == false)
                {
                    retro = true;
                }
                for (int i = temp; i < arrayList.Count; i += 2)
                {
                    arrayList.RemoveAt(i);
                    i -= 1;
                }
                if (retro)
                {
                    temp = 0;
                }
            }
            foreach (var i in arrayList)
            {
                Console.WriteLine($"left in ArrayList: {i}");
            }

        }
        public static void LinkedList_1(int N)
        {
            LinkedList<int> linklist = new LinkedList<int>();
            for (int i = 0; i < N; i++)
            {
                linklist.AddLast(i);
            }
            int temp = 1;
            bool retro = false;
            while (linklist.Count > 1)
            {
                if (linklist.Count % 2 != 0 && retro == false)
                {
                    retro = true;
                }
                for (int i = temp; i < linklist.Count; i += 2)
                {
                    linklist.Remove(linklist.ElementAt(i));
                    i --;
                }
                if (retro)
                {
                    temp = 0;
                }
            }
            foreach (var i in linklist)
            {
                Console.WriteLine("++++++++++++++++++");
                Console.WriteLine($"left in LinkedList: {i}");
            }

        }
    }
}
