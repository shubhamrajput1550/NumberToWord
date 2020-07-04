using NumToWord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Random r = new Random();
            int i = 100;
            while ((i--) > 0)
            {

                double rNum = r.Next(int.MinValue, int.MaxValue);
                string word = Num2Word.ToWord(rNum);

                Console.WriteLine(rNum + "  ====  " + word);

            }

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}