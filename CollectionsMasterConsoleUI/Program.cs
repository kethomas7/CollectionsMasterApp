using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50

            var size50 = new int[20];
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50


            Populater(size50);

            // TODO: Print the first number of the array
            Console.WriteLine($"First number:{size50[0]}");

            //TODO: Print the last number of the array            
            Console.WriteLine($"Last number: {size50[size50.Length - 1]}");


            Console.WriteLine("All Numbers Original");
            //    //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(size50);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____();   
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(size50);
            NumberPrinter(size50);

            Console.WriteLine("---------REVERSE CUSTOM------------");


            ReverseArray(size50);

            Console.WriteLine("-------------------");

            //    //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(size50);

            Console.WriteLine("-------------------");

            //    //TODO: Sort the array in order now
            //    /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(size50);
            NumberPrinter(size50);


            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var numbers = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine($" Here is the capacity: {numbers.Capacity}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numbers);

            //TODO: Print the new capacity

            Console.WriteLine($" Here is the NEW capacity: {numbers.Capacity}");
            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!

            int searchedNumber;
            bool convertCompleted;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                var userAnswer = Console.ReadLine();
                convertCompleted = int.TryParse(userAnswer, out searchedNumber);

            }
            while (convertCompleted == false);

            NumberChecker(numbers, searchedNumber);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numbers);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numbers.Sort();
            NumberPrinter(numbers);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable

            int[] convertList = numbers.ToArray();

            //TODO: Clear the list
            numbers.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }

            }

            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {


            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Your choice: {searchNumber} is in the list");

            }
            else
            {
                Console.WriteLine($"Your choice: {searchNumber} is NOT in the list");
            }


        }

        private static void Populater(List<int> numberList)
        {
            while (numberList.Count < 50)
            {
                Random rng = new Random();
                numberList.Add(rng.Next(1, 50));
            }
            NumberPrinter(numberList);
        }

        private static void Populater(int[] numbers)
        {
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            for (int i = 0; i < numbers.Length; i++)
            {
                Random rng = new Random();
                numbers[i] = rng.Next(1, 50);
            }
        }

        private static void ReverseArray(int[] array)
        {

            var i = 0;
            var j = array.Length - 1; //equals the last position in the array

            while (i < j)
            {
                var temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }

            NumberPrinter(array);

        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

