using System;

namespace Codility
{
    public static class BinaryGapSolution
    {
        public static int FindLargestBinaryGap(int input = 0)
        {
            var binaryGapInput = string.Empty;
            if (input == 0)
            {
                binaryGapInput = GetInput();
            }
            else
            {
               binaryGapInput = ConvertToBinary(input.ToString());
            }

            Console.WriteLine($"Binary: {binaryGapInput}");

            var maxBinaryGapLength = GetMaxBinaryGap(binaryGapInput);
            Console.WriteLine($"Longest binary gap's length is: {maxBinaryGapLength}");

            return maxBinaryGapLength;

        }
        private static string GetInput()
        {
            Console.WriteLine($"Please enter a positive int to get binary.");
            var enteredNumber = Console.ReadLine();

            try
            {
                return ConvertToBinary(enteredNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                throw ex; //TODO handle exception
            }
        }

        private static string ConvertToBinary(string input)
        {
           return Convert.ToString(Convert.ToInt32(input), 2);
        }

        private static int GetMaxBinaryGap(string binary)
        {
            var length = binary.Length;
            var startIndex = 0;
            var endIndex = 0;
            var foundStartIndex = false;
            var currentBinaryGapLength = 0;
            var maxBinaryGapLength = 0;

            for (int i = 0; i < length; i++)
            {
                if (!foundStartIndex && binary[i] == '1')
                {
                    startIndex = i;
                    foundStartIndex = true;
                }

                if (foundStartIndex)
                {
                    if (binary[i] == '1')
                    {
                        endIndex = i;
                    }
                }
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (binary[i] == '0')
                {
                    currentBinaryGapLength++;
                }
                else
                {
                    if (currentBinaryGapLength > maxBinaryGapLength)
                    {
                        maxBinaryGapLength = currentBinaryGapLength;
                        currentBinaryGapLength = 0;
                    }
                }
            }

            return maxBinaryGapLength;
        }
    }
}

