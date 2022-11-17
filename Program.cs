using System;

namespace FreqCalculator 
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int []arr = new int[]{1, 4, 1, 5, 8, 1, 3, 5, 1, 4, 1, 3, 7, 2};
        FreqCalc freqResult = new FreqCalc();
        freqResult.countFreq(arr);
        }

    }
}