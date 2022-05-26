using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muxanov_Kutin_laba6_OS
{
    class Program
    {

        static String[] menu = { "Добавить задачу\n", "Удалить задачу\n", "Приостановить задачу\n", "Состояние памяти\n", "Выход\n" };
        static bool isExit = false;

        static int globalID = 0;

        public static void Main(String[] args)
        {
            OperationMemory op = new OperationMemory();
            while (!isExit)
            {
                printMenu();
                Console.WriteLine("Введите пункт меню: ");
                int option = int.Parse(Console.ReadLine());
                int num;
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Введите размер нового процесса: ");
                        num = int.Parse(Console.ReadLine());
                        op.addProcess(new Process(num, globalID++));
                        break;

                    case 2:
                        Console.WriteLine("Введите id процесса для удаления: ");
                        num = int.Parse(Console.ReadLine());
                        op.deleteFromOpMemory(num);
                        break;

                    case 3:
                        Console.WriteLine("Введите id процесса для приостановки: ");
                        num = int.Parse(Console.ReadLine());
                        op.pauseProcess(num);
                        break;

                    case 4: op.showStatusMemory(); break;
                    case 5:
                        isExit = true; break;

                    default: Console.WriteLine("Введен неверный вариант!!!\n\n"); break;
                }
            }
        }

        static void printMenu()
        {
            Console.WriteLine("\n\n");


            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine("{0}) {1}", i + 1, menu[i]);
            }
        }
    }
}