using System;

namespace InClassExampleDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declearing Variables to be used in the program
            String firstName, lastName;
            double gpa;

            //Output to get user information from console
            Console.WriteLine("Please enter your first name >>");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name >>");
            lastName = Console.ReadLine();

            Console.WriteLine("Please enter your gpa >>");
            string gpaString = Console.ReadLine();
            gpa = Convert.ToDouble(gpaString);

            gpa += 0.5; //gpa = gpa + 0.5 

            //Output user information to console with two ways to output the information
            string output = "Hello " + firstName + " " + lastName + "! " + "we bosted your gpa to " + gpa.ToString("N3");
            Console.WriteLine(output);

            output = $"Hello { firstName} { lastName}! we bosted your gpa to {gpa.ToString("N3")}";
            Console.WriteLine(output);
            Console.WriteLine("");
        }
    }
}
