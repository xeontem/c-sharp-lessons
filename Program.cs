using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Timer timer = new Timer(200);

        static string wakeUpNeo = "Wake up, Neo...";
        static string matrixHasYou = "The matrix has you...";
        static string whiteRabbit = "Follow the white rabbit.";
        static string knock = "Knock, knock, Neo.";

        static int counter = 0;

        static void Main(string[] args)
        {
            timer.Elapsed += PrintWakeUpNeo;
            timer.Enabled = true;

            Console.ReadLine();
        }
        private static void PrintWakeUpNeo(Object source, ElapsedEventArgs e)
        {
            Console.Write(wakeUpNeo[counter]);

            if (counter == wakeUpNeo.Length - 1) {
                timer.Interval = 2000;
                counter = 0;
                timer.Elapsed -= PrintWakeUpNeo;
                timer.Elapsed += PrintMatrixHasYou;
            } else { 
                counter++;
            }
        }
        private static void PrintMatrixHasYou(Object source, ElapsedEventArgs e)
        {
            if (counter == 0) { 
                Console.Clear();
            }
            timer.Interval = 600;
            Console.Write(matrixHasYou[counter]);
            if (counter == matrixHasYou.Length - 1) {
                timer.Interval = 2000;
                counter = 0;
                timer.Elapsed -= PrintMatrixHasYou;
                timer.Elapsed += PrintWhiteRabbit;
            } else {
                counter++;
            }
        }
        private static void PrintWhiteRabbit(Object source, ElapsedEventArgs e)
        {
            if (counter == 0) {
                Console.Clear();
            }
            timer.Interval = 200;
            Console.Write(whiteRabbit[counter]);
            if (counter == whiteRabbit.Length - 1) {
                timer.Interval = 2000;
                counter = 0;
                timer.Elapsed -= PrintWhiteRabbit;
                timer.Elapsed += PrintKnock;
            } else {
                counter++;
            }
        }
        private static void PrintKnock(Object source, ElapsedEventArgs e)
        {
            Console.Clear();
            Console.Write(knock);
            timer.Enabled = false;
        }
    }
}
