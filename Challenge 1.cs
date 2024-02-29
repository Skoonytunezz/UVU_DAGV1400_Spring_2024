using System;

class Program
{
    static void Main() 
    {

        int newRow = 5; // sets number of rows

        for (int i = 1; i <= newRow; i++) // loop through each row
        {
            for (int j = 0; j < i; j++) // loop to write each row
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
} 