using System;
using System.Collections.Generic;

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
            //var fifty = new int[50];
            //Random random = new Random();
            //for(int i=0; i <fifty.Length; i++)
            //{
            //    fifty[i] = random.Next(1, 50);
            //}

            //foreach (int i in fifty)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine($"First number in array:{fifty[0]}");
            //Console.WriteLine($"Last number in array: {fifty[49]}");

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50


            //TODO: Print the first number of the array

            //TODO: Print the last number of the array            
            var fifty = new int[50];
            Populater(fifty);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(fifty);
            Console.WriteLine("-------------------");

            Console.WriteLine($"First number in array:{fifty[0]}");
            Console.WriteLine($"Last number in array: {fifty[49]}");
            

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(fifty);

            foreach (int i in fifty)
            {
                Console.WriteLine(i);
            }
            

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(fifty);

            NumberPrinter(fifty);
            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(fifty);


            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
              
            Console.WriteLine("Sorted numbers:");
            Array.Sort(fifty);
            NumberPrinter(fifty);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var numberList = new List<int>();
            
            Console.WriteLine($"current capacity:{numberList.Capacity}");

            Populater(numberList);

            Console.WriteLine($"new capacity: {numberList.Capacity}");

            //TODO: Print the capacity of the list to the console


            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            


            //TODO: Print the new capacity


            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            bool isANum;
            int userNum;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isANum = int.TryParse(Console.ReadLine(), out userNum);
            } while (!isANum);

            NumberChecker(numberList, userNum);


            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            
            Console.WriteLine("------------------");
            OddKiller(numberList);
            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            

            //TODO: Clear the list
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
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
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            while (numberList.Count <= 50)
            {
                numberList.Add(rng.Next(1, 51));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(1, 50);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;

            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;

                start++;
                end--;
            }
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
