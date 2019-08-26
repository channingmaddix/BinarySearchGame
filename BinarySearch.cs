using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchGame
{
    class BinarySearch
    {
        public void Search()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Pick a number between 1 and 10: ");
            int num = System.Int32.Parse(Console.ReadLine());
            bool valid = false;
            while (valid == false)
            {
                if (num < 1 || num > 10)
                {
                    Console.WriteLine("Please input a number between 1 and 10.:");
                    num = System.Int32.Parse(Console.ReadLine());
                }
                else valid = true;
            }

            int mid = (arr.Length - 1) / 2;
            int start = 0;
            int end = arr.Length - 1;
            while(arr[mid] != num)
            {
                if (mid == -1 || mid == arr.Length)
                {
                    Console.WriteLine("Number is not in the array.");
                    break;
                }
                if (arr[mid] > num)
                {
                    Console.WriteLine(mid);
                    end = mid;
                    mid = (start + end) / 2;
                }
                else if (arr[mid] < num)
                {
                    Console.WriteLine(mid);
                    start = mid;
                    mid = (start + end) / 2;
                }
            }
            if (arr[mid] == num)
            {
                Console.WriteLine("Number is in place #" + (mid + 1) + ".");
            }
        }
        public void HumanPlayer()
        {
            Random random = new Random();
            int[] arr = new int[1000];
            arr[0] = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + 1;
            }
            int winningNum = random.Next(1001);
            bool win = false;
            Console.WriteLine("Pick a number between 1 and 1000: ");
            while (win == false)
            {
                int num = -1;
                bool valid = false;
                num = System.Int32.Parse(Console.ReadLine());
                while (valid == false)
                {
                    if (num < 1 || num > 1000)
                    {
                        Console.WriteLine("Please input number between 1 an 1000.");
                        num = System.Int32.Parse(Console.ReadLine());
                    }
                    else valid = true;
                }
                if (num < winningNum)
                {
                    Console.WriteLine("Too low.");
                }
                else if (num > winningNum)
                {
                    Console.WriteLine("Too high.");
                }
                else
                {
                    win = true;
                    Console.WriteLine("You win!");
                }
            }
        }
        public void ComputerPlayer()
        {
            Console.WriteLine("Write down a number between 1 and 100 and tell me if I guess too high or low." +
                "Input 'H' for high and 'L' for low. Input 'W' if I win. Press enter when ready.");
            Console.ReadLine();
            /*int[] arr = new int[100];
            arr[0] = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + 1;
            }*/
            int start = 0;
            int end = 99;
            int mid = 50;
            string condition = "";
            while (condition != "W")
            {
                Console.WriteLine(mid + "?");
                condition = Console.ReadLine();
                bool valid = false;
                while (valid == false)
                {
                    if (condition != "H" && condition != "L" && condition != "W")
                    {
                        Console.WriteLine("Please input a capital H for high, L for low, or W for win.");
                        condition = Console.ReadLine();
                    }
                    else valid = true;
                }
                if (condition == "H")
                {
                    end = mid;
                    mid = (start + end) / 2;
                }
                else if (condition == "L")
                {
                    start = mid;
                    mid = (start + end) / 2;
                }
                else if (condition == "W")
                {
                    Console.WriteLine("Thank you for playing!");
                }
            }
        }
    }
}
