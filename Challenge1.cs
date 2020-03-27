using System;

namespace CodeChallenge
{
    class Challenge1
    {
        static void addToArray(int[] inArray, int num)
        {
            int inLength = inArray.Length;
            int arrayInteger = 0;
            Console.Write("Input: [");
            if (inLength > 0)
            {
                for (int i = 0; i < inLength; i++)
                {
                    arrayInteger += inArray[i] * (Convert.ToInt32(Math.Pow(10, inLength - 1 - i)));

                    //print input array
                    Console.Write(inArray[i]);
                    if (i != inLength - 1)
                    {
                        Console.Write(",");
                    }
                }
            }
            Console.WriteLine("]" + ", " + num);

            int outArrayInteger = arrayInteger + num;
            int outLength = outArrayInteger.ToString().Length;
            int[] outArray = new int[outLength];
            Console.Write("Output:[");
            for (int i = 0; i < outLength; i++)
            {
                int divisor = Convert.ToInt32(Math.Pow(10, outLength - 1 - i));
                outArray[i] = outArrayInteger / divisor;
                outArrayInteger %= divisor;

                //print output array
                Console.Write(outArray[i]);
                if (i != outLength - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("]\n");
        }
        public static void Main()
        {
            int[] array = new int[] { 1, 2, 3 };
            addToArray(array, 5);

            array = new int[] { 5, 6, 7, 8 };
            addToArray(array, 500);

            array = new int[0];
            addToArray(array, 987);
        }
    }
}
