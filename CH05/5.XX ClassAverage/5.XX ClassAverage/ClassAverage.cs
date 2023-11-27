// ClassAverage.cs
// Solving the class average problem using sentinal-controlled iteration

using System;

class ClassAverage
{
    static void Main()
    {
        // initialization phase
        int total = 0; // initialise the sum of grades
        int gradeCounter = 0; //initialise the # of grades entered so far

        //processing phase
        //prompt for input and read grade from user
        Console.Write("Enter grade or -1 to quit: ");
        int grade = int.Parse(Console.ReadLine());

        // loop until sentinal value is read from the user
        while (grade != -1)
        {
            total = total + grade; // add grade to total
            gradeCounter = gradeCounter + 1; // increment the counter

            // prompt for input and read grade from the user
            Console.Write("Enter grade or -1 to quit: ");
            grade = int.Parse(Console.ReadLine());
        }

        // termination phase
        // if the user entered at least one grade
        if (gradeCounter != 0)
        {
            // use number with decimal point to calculate average of the grades
            double average = (double)total / gradeCounter;

            // displaye the total and average (with two digits of precision)
            Console.WriteLine($"\nTotal of the {gradeCounter} grades entered is {total}");
            Console.WriteLine($"Class average is {average:F}");
        }
        else // no grades were entered, so output error message
        {
            Console.WriteLine("No grades were entered");
        }
    }
}
