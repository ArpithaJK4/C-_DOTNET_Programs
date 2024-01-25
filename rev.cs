using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string reversedString = ReverseString(input);

        Console.WriteLine("Reversed string: " + reversedString);
    }

    static string ReverseString(string input)
    {
        // Convert the string to a character array
        char[] charArray = input.ToCharArray();

        // Use two pointers to swap characters from both ends
        int start = 0;
        int end = charArray.Length - 1;

        while (start < end)
        {
            // Swap characters
            char temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;

            // Move the pointers towards the center
            start++;
            end--;
        }

        // Convert the character array back to a string
        string reversedString = new string(charArray);

        return reversedString;
    }
}
