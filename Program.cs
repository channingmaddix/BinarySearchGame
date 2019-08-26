using System;

namespace BinarySearchGame
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch binarySearch = new BinarySearch();
            
            binarySearch.Search();
            binarySearch.HumanPlayer();
            binarySearch.ComputerPlayer();
        }
    }
}
