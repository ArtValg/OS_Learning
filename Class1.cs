using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace ThreadApp
{
    public class Execute
    {
        public static void Exec()
        {
            int i = 0;
            while(i != 1)
            {
                Console.WriteLine("Поток2 " + DateTime.Now.ToString("h:mm:ss tt"));
                Thread.Sleep(200);
            }
        }
    }
}
