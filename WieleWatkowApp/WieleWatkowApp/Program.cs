using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WieleWatkowApp
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Task.Factory.StartNew(() => { Console.WriteLine("Napis wygenerowany z wątku"); });

            Console.WriteLine("Napis wygenerowany z watku glownego");
            Console.ReadKey(); */


            /*Task task1 = new Task(new Action(printinfo));
            task1.Start();

            Console.WriteLine("Napis wygenerowany z watku glownego");
            Console.ReadKey(); */



            /*Task task2 = new Task(delegate { printinfo(); });
            task2.Start();

            Console.WriteLine("Napis wygenerowany z watku glownego");
            Console.ReadKey();

            Task task1 = new Task(() => { printinfo(); });
            task1.Start();


            Console.WriteLine("Napis wygenerowany z watku glownego");
            Console.ReadKey(); 

            Task task1 = new Task(new Action<object>(printInfo2), "1 zadanie");

            Task task2 = new Task(delegate (object obj) { printInfo2(obj); },"2 zadanie");

            Task task3 = new Task((obj) => printInfo2(obj), "3 zadanie");

            Task task4 = new Task((obj) => { printInfo2(obj); }, "4 zadanie");

            task1.Start();

            task2.Start();

            task3.Start();

            task4.Start(); 


            string[] messages = { "1 zadanie", "2 zadanie", "3 zadanie", "4 zadanie" };

            foreach(string msg in messages)
            {

                Task task = new Task(obj => printInfo2((string)obj), msg);
                task.Start();

            }

            Console.WriteLine("Napis wygenerowany z watku glownego");
            Console.ReadKey(); 

            Action<string> messageTarget;

            if (Console.ReadKey(true).Key == ConsoleKey.A)

            {
                messageTarget = s => ShowMessage(s);

            }

            else messageTarget = s => Console.WriteLine(s);


            messageTarget("uzycie delegate");
            Console.WriteLine("Napis wygenerowany z watku golownego");
            Console.ReadKey(); 


            Task<int> task1 = new Task<int>(() =>
            {
                int sum = 0;

                for (int i = 0; i < 10; i++)
                {
                    sum += i;
                }

                return sum;
            });

            Task<int> task2 = Task.Factory.StartNew(() =>
            {
                int sum = 0;

                for (int i = 0; i < 10; i++)
                {
                    sum += i;
                }

                return sum;
            });

            task1.Start();

            
            Console.WriteLine("Suma {0}", task1.Result);
            Console.WriteLine("Suma {0}", task2.Result);

            Console.WriteLine("Wiadomosc z watku glownego");

             Console.ReadLine(); 

            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            Task task = new Task(() =>
            {
                for(int i =0;i< int.MaxValue;i++)
                {
                    if(token.IsCancellationRequested)
                    {
                        Console.WriteLine("Wykrycie odwolania zadania");
                        throw new OperationCanceledException(token);
                    }

                    else
                    {
                        Console.WriteLine("ints ->{0}", i);
                    }
                }

            }, token
                );

            Console.ReadLine();
            task.Start();

            Console.ReadLine();
            Console.WriteLine("Konczenie tasku");
            tokenSource.Cancel();

            Console.WriteLine("Wiadomosc wygenerowana z glownego watku");
            Console.ReadKey(); */



            Task task1 = new Task(new Action(printSign));
            Task task2 = new Task(new Action(printSign2));
            Task task3 = new Task(new Action(printSign3));
            Task task4 = new Task(new Action(printSign4));
            Task task5 = new Task(new Action(printSign5));
            Task task6 = new Task(new Action(printSign6));
            task1.Start();
            task2.Start();
            task3.Start();
            task4.Start();
            task5.Start();
            task6.Start();
            Console.ReadLine();

            

            //  Task task3 = new Task((obj) => printInfo2(obj), "3 zadanie");

            //  Task task4 = new Task((obj) => { printInfo2(obj); }, "4 zadanie");




        }

        private static void printSign2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.ForegroundColor = (System.ConsoleColor.White);
                Console.WriteLine("*");
                System.Threading.Thread.Sleep(800);
                



            }
            
        }

        private static void printSign()
        
        {
             
            for(int i= 0; i<10;i+=2)
            {
                Console.SetCursorPosition(0, i);
                Console.ForegroundColor = (System.ConsoleColor.Red);
                Console.WriteLine("*");
                System.Threading.Thread.Sleep(400);
                
                


            }
        }


        private static void printSign6()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(5, i);
                Console.ForegroundColor = (System.ConsoleColor.White);
                Console.WriteLine("*");
                System.Threading.Thread.Sleep(800);




            }
        }

        private static void printSign3()

        {

            for (int i = 0; i < 10; i+=3)
            {
                Console.SetCursorPosition(2, i);
                Console.ForegroundColor = (System.ConsoleColor.Red);
                Console.WriteLine("*");
                System.Threading.Thread.Sleep(400);




            }
        }


        private static void printSign4()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(3, i);
                Console.ForegroundColor = (System.ConsoleColor.White);
                Console.WriteLine("*");
                System.Threading.Thread.Sleep(800);




            }
        }

        private static void printSign5()

        {

            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(4, i);
                Console.ForegroundColor = (System.ConsoleColor.Red);
                Console.WriteLine("*");
                System.Threading.Thread.Sleep(400);




            }
        }

        

        delegate void DisplayMessage(string message);

        private static void ShowMessage(string message)
        {
            Console.WriteLine("***" + message + "***");
        }

        private static void printInfo2(object msg)
        {
            Console.WriteLine("Info{0}", msg);
        }

        private static void printinfo()
        {
            Console.WriteLine("Napis wygenerowany z watku");
        }
    }
}
