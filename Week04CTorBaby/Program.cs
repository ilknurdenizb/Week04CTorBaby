using Week04CTorBaby;
using System;
class Program // This is the main entry point of the program
{
    static void Main() // The Main method is the starting point of the application
    {
        Baby baby1 = new Baby(); // Calls the default constructor
        Baby baby2 = new Baby("Abraham", "Lincoln"); // Calls the parameterized constructor
        Console.WriteLine($"First baby: {baby1.Name} {baby1.Surname} - {baby1.DateOfBirth}"); // Outputs the details of the first baby
        Console.WriteLine($"Second baby: {baby2.Name} {baby2.Surname} - {baby2.DateOfBirth}"); // Outputs the details of the second baby
        Console.ReadLine();  // Waits for user input before closing the console window
    }

}
