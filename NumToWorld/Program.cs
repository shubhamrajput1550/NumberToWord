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
            List<string> l = new List<string>();

            string a =Num2Roman.ToRoman(10);

            //Random r = new Random();
            //Random r1 = new Random();
            //int i = 100;
            //while ((i--) > 0)
            //{
            //    int rNum = r.Next(1, 4999);
            //    string word = Num2Roman.ToRoman(rNum);
            //    l.Add(rNum + "  ====  " + word);
            //    rNum = r1.Next(int.MinValue, int.MaxValue);
            //    word = Num2Word.ToWord(rNum, WordNotation.Indian);
            //    l.Add(rNum + "  ====  " + word);
            //    word = Num2Word.ToWord(rNum, WordNotation.Us);
            //    l.Add(rNum + "  ====  " + word);
            //}

            //System.IO.File.WriteAllLines("M.txt", l.ToArray());

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
