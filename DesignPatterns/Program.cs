using DesignPatterns.AdapterDP;
using DesignPatterns.DI;
using DesignPatterns.StructuralDP.AdapterDP;
using DesignPatterns.StructuralDP.Facade_DP;
using DesignPatterns.StructuralDP.Facade_DP.RealTimeExample;
using DesignPatterns.StructuralDP.Flyweight_DP;
using DesignPatterns.StructuralDP.Flyweight_DP.RealTimeExample;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Program
    {

        static void PrintNumbers(object id)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Thread {id}: {i}");
                Thread.Sleep(500);
            }
        }

        static void Main()
        {
            Thread thread1 = new Thread(PrintNumbers);
            Thread thread2 = new Thread(PrintNumbers);

            thread1.Start(1);
            thread2.Start(2);

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Main Thread: {i}");
                Thread.Sleep(500);
            }

            thread1.Join();
            thread2.Join();

            Console.WriteLine("All threads finished!");
        }

        //static async Task PrintMessage()
        //{
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        Console.WriteLine($"Task Message {i}");
        //        await Task.Delay(500); // Simulate async work
        //    }
        //}

        //static async Task Main()
        //{
        //    Task task = PrintMessage();

        //    for (int i = 1; i <= 5; i++)
        //    {
        //        Console.WriteLine($"Main Task Message {i}");
        //        await Task.Delay(500);
        //    }

        //    await task; // Wait for the task to finish
        //    Console.WriteLine("Task finished!");
        //}

        //static void PrintMessage()
        //{
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        Console.WriteLine($"Thread Message {i}");
        //        Thread.Sleep(500); // Simulate work
        //    }
        //}

        //static void Main()
        //{
        //    Thread thread = new Thread(PrintMessage);
        //    thread.Start();

        //    for (int j = 1; j <= 5; j++)
        //    {
        //        Console.WriteLine($"Main Thread Message {j}");
        //        Thread.Sleep(500);
        //    }

        //    thread.Join(); // Wait for the thread to finish
        //    Console.WriteLine("Thread finished!");
        //}
    }
}

//Multi-cast Delegate:
//a multi cast delegate is a delegate which holds reference to more than one method.

