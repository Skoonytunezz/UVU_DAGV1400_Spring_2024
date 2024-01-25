using System;

public class Operators
{
    public static void Main()
    {

        string receipt = "Receipt"; //Header for Receipt
        Console.WriteLine(receipt);

        int mediumShirt = 5;
        Console.WriteLine("Medium Shirt Count: " + mediumShirt); //Medium Shirt Count

        int largeShirt = 14;
        Console.WriteLine("Large Shirt Count: " + largeShirt); //Large Shirt Count

        int x = mediumShirt;
        int y = largeShirt;

        int sum = x + y;                                                // Number of shirts bought
        Console.WriteLine("Total Shirts Bought: " + sum);

        double mediumCost = 35.35D;
        Console.WriteLine("Medium Shirt Total = " + x*mediumCost);  // shows total cost of medium shirts bought

        double largeCost = 44.35D;
        Console.WriteLine("Large Shirt Total = " + y*largeCost);  // shows total cost of large  shirts bought


        double totalOrder = y*largeCost + x*mediumCost; 
        Console.WriteLine("Your Order Total - " + totalOrder);  // shows total cost of order before discounts


        if (totalOrder > 100)  //applies discount if order is greater than $100
        {
            Console.WriteLine("discount " + "-50"); 
        }
        else 
        {
            Console.WriteLine("No Discount");
        }

    }

}

//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers