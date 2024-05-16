// See https://aka.ms/new-console-template for more information

// Write a program that takes a users's age as input and prints it to the screen.
// Display an error if an invalid input is received.

Console.Write("Enter your age: ");
try
{
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You are {age} years old.");

}
catch (Exception)
{
    Console.WriteLine("Your age value was incorrect, please try again. ");
}
finally 
{
    Console.WriteLine("********** Thank you for using this program - **********");
}