namespace Assignment_3_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 3.2.5
             * Create a function that finds the index of a given item in the array
             * Examples
             * Search([1, 5, 3], 5) ➞ 1
             * Search([9, 8, 3], 3) ➞ 2
             * Search([1, 2, 3], 4) ➞ -1
             * Notes
             * If the item is not present, return -1.
             */

            // Title
            Console.WriteLine("Find The Index");

            // Prompt user to specify the number of elements in the array and instantiate it
            Console.Write("\nHow many elements are in the array? ");
            int elementAmount = Convert.ToInt32(Console.ReadLine());
            int[] arr = EnterArray(elementAmount);

            // Prompt user to specify what integer they are trying to find the index of
            Console.Write("What value are you searching for? ");
            int value = Convert.ToInt32(Console.ReadLine());

            // Print the results found after searching for the index
            Console.Write("In array [");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                    Console.Write(" " + arr[i] + " ] ");
                else Console.Write(" " + arr[i] + ",");
            }
            Console.WriteLine($"the value {value} can be found in index {GetIndexOf(arr, value)}");
        }

        static int[] EnterArray(int ElementAmount_)
        {
            int[] arr_ = new int[ElementAmount_];

            Console.WriteLine("Enter elements one at a time.");

            for (int i = 0; i < ElementAmount_; i++)
            {
                Console.Write("Enter element: ");
                arr_[i] = Convert.ToInt32(Console.ReadLine());
            }

            return arr_;
        }

        static string GetIndexOf(int[] Arr_, int Value_)
        {
            for (int i = 0;i < Arr_.Length;i++)
                if (Arr_[i] == Value_)
                    return Convert.ToString(i);

            return Convert.ToString(-1);
        }

    }
}
