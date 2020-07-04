using NumToWord.Strategy;
using System;

namespace NumToWord
{
    public class Num2Word
    {

        public static string ToWord(int num, WordNotation notation = WordNotation.Lakh)
        {
            return GetWord(num.ToString(), notation);
        }

        public static string ToWord(long num, WordNotation notation = WordNotation.Lakh)
        {
            return GetWord(num.ToString(), notation);
        }

        public static string ToWord(byte num, WordNotation notation = WordNotation.Lakh)
        {
            return GetWord(num.ToString(),notation);
        }

        public static string ToWord(double num, WordNotation notation = WordNotation.Lakh)
        {
            return GetWord(num.ToString(), notation);
        }

        public static string ToWord(decimal num, WordNotation notation = WordNotation.Lakh)
        {
            return GetWord(num.ToString(), notation);
        }

        private static string GetWord(string number, WordNotation notation)
        {
            StrategyContext strategy = new StrategyContext();
            if (notation == WordNotation.Million)
            {
                strategy.SetNewStrategy(new UsCurrencyStrategy());
            }
            return strategy.GetWord(number);
        }

    }
}
