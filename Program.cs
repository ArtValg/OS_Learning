using System;
using System.Threading;

namespace ThreadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread firstThread = new Thread(Execute.Exec);
            firstThread.Start();
            int i = 0;

            while(i != 1)
            {
                Console.WriteLine("Поток1 " + DateTime.Now.ToString("h:mm:ss tt"));
                Thread.Sleep(150);
            }
            
        }
    }
}
