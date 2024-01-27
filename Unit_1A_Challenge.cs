using System;

public class Unit1aChallange 
{
    public static void Main()
    {
        Console.WriteLine("This place looks good!");  //Start convo
        Console.WriteLine("How much for 4 drinks?"); // Convo cont.

        string brokeBoy = "I dont have enough money :("; // string for if the drinks are too expensive
        string richGuy  =  "Ill take the lot!";             // string for if the drinks are affordable.

        double drinkPrice = 50.54D;  //the cost of 1 drink
        int drinkQnt = 4;       // total of drinks requested

        double totalCost = drinkQnt*drinkPrice;  // formula to find total drink cost
		Console.WriteLine(totalCost);       //writes total cost 

        if (totalCost < 20)         // boolean stating that if the drinks cost more than 20 to display the next step in the convo!
        {
            Console.WriteLine(richGuy);
        }
        else
        {
            Console.WriteLine(brokeBoy);
        }
    }
}
