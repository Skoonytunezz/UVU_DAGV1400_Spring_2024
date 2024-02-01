using System;

public class Program
{
    public void Main()
    {
    	int currentTemp = 30; // hard codes the outside temp in Cel
   	 Console.WriteLine("Temprature is: " + currentTemp);
 
   		if (currentTemp > 30)
    	{
        Console.WriteLine("Its hot out! Be sure to stay hydrated and avoid staying in the sun for too long!");
    	}
    	else
    	{
        Console.WriteLine("Enjoy the pleasant weather");
		}
		
		examGrader(); // Calls the examGrader method to be ran after the outside temp check
	}

    public void examGrader()
    {
        var examScore = 93; // Hard coded exam score
        if (examScore >= 90 && examScore <= 100)
        {
            Console.WriteLine("A: Great Job, keep up the good work!");
        }
        else if (examScore >= 80 && examScore <= 89)
        {
            Console.WriteLine("B: Good Job, Nearly got it!");
        }
        else if (examScore >= 70 && examScore <= 79)
        {
            Console.WriteLine("C: Improvement!");
        }
        else if (examScore >= 60 && examScore <= 69)
        {
            Console.WriteLine("D: More Effort is needed!");
        }
         else
        {
            Console.WriteLine("F: :( see me after class...");
        }
    }
}