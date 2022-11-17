using System.Collections;

namespace FreqCalculator
{
    public class FreqCalc
    {
        int elementPosition;
        public void countFreq(int []arr)
        {
            Array.Sort(arr);

            Dictionary<int, int> storage = new Dictionary<int,int>();

            foreach(int value in arr)
            {
                if (storage.ContainsKey(value))
                {
                    storage[value]++;
                }
                else
                {
                    storage[value] = 1;
                }
            }

            int[] number = new int[storage.Count];
            int[] frequency = new int[storage.Count];

            foreach(KeyValuePair<int, int> entry in storage)
            {                
                number[elementPosition] = entry.Key;
                frequency[elementPosition] = entry.Value;
                elementPosition++;
            }

            ArrayList numbersNew = new ArrayList();
            ArrayList freqNew = new ArrayList();
            int misNumber = number[0];
            for (int i=0;i<number.Length;i++)
            {
                if (misNumber==number[i])
                {
                    numbersNew.Add(misNumber);
                    freqNew.Add(frequency[i]);
                    misNumber++;                   
                    continue;
                }
                else
                {
                    numbersNew.Add(misNumber);
                    freqNew.Add(0);
                    i--;
                    misNumber++;
                }
            }

            int[] finalNumber = new int[numbersNew.Count];
            int[] finalFrequency = new int[freqNew.Count];
            
            numbersNew.CopyTo(finalNumber);
            freqNew.CopyTo(finalFrequency);

            DrawGraph(finalFrequency, finalNumber);   
        }

        public void DrawGraph(int[] frequencyArray, int[] numberArray)
        {
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.Write(numberArray[i]);
                if (frequencyArray[i] != 0)
                {
                    for(int j = 1; j <= frequencyArray[i]; j++)
                    {
                        Console.Write(" *");
                    }
                }
                else
                {
                    Console.Write("");
                }               

                Console.WriteLine();
            }
        }
    }
}