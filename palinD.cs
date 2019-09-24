using System;

public class Program {
    public static void Main()
    {
        Console.WriteLine("Enter a word:");
        string userWord = Console.ReadLine();
        char[] charArray = userWord.ToCharArray();
        char[] oGCharArray = userWord.ToCharArray();
        Array.Reverse(charArray);
        foreach (char entry in charArray)
        {
        Console.WriteLine(entry);
        }
        foreach (char entry in oGCharArray)
        {
            Console.WriteLine(entry);
        }

        string regArray = new string(oGCharArray);
        string revArray = new string(charArray);

        if(regArray == revArray)
        {
            Console.WriteLine("That is a Palindrome.");
        }
        else 
        {
            Console.WriteLine("That is not a Palindrome.");
        }
    }
}

