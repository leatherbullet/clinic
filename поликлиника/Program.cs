using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace поликлиника
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int receptionTime = 10;
            int visitor = 14;
            int waitingTime = receptionTime * visitor;
            int hour = waitingTime / 60;
            int minute = waitingTime % 60;

            Console.WriteLine($"Вы должны стоять в очереди{hour} часа и{minute} минут.");

        }
    }
}
