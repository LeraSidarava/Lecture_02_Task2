using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a array of numbers separated by commas: ");
        string input = Console.ReadLine();

        //Input transform to array reducing commas and count string length
        string[] numbers = input.Split(',');
        int length = numbers.Length;

        // Change the first and last values
        string temp = numbers[0];
        numbers[0] = numbers[length - 1];
        numbers[length - 1] = temp;

        // Change the second and penultimate values
        if (length > 3)
        {
            temp = numbers[1];
            numbers[1] = numbers[length - 2];
            numbers[length - 2] = temp;
        }

        //Display changed array + combine all elements of numbers to a string with commas
        Console.WriteLine("Changed array: " + string.Join(",", numbers));
    }
}