using System;

// Move all zeros to the left

namespace MoveZerosLeft
{
    class Program
    {
        static void shiftZeros(int[] orig, int len)
        {
            int readIndex, writeIndex;

            readIndex = writeIndex = len - 1;

            for (readIndex = len - 1; readIndex >= 0; --readIndex)
            {
                if (orig[readIndex] != 0)
                {
                    orig[writeIndex] = orig[readIndex];
                    writeIndex--;
                }
            }
            for (int ii = 0; ii <= writeIndex; ++ii)
                orig[ii] = 0;

            return;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Move all 0s to the left");

            int[] original = { 1, 0, 5, 2, 9, 0, 3, 0};
            Console.WriteLine ("After shifting");

            shiftZeros (original, original.Length);
            for (int ii = 0; ii < original.Length; ++ii)
            {
                Console.Write(original[ii] + ", ");
            }
            Console.WriteLine();
        }
    }
}
