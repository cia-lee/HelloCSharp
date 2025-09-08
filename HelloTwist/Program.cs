using System.Net;

namespace HelloTwist;

public class Check
{
    public string userInput()
    {
        //string for user input reads line
        string userWriting = Console.ReadLine();

        //if the string for user input is empty, it enters a loop to ask for new input until it isn't
        if (string.IsNullOrEmpty(userWriting)){
            do{
                Console.WriteLine("That's a whole lot of nothing. Please write something.");
                userWriting = Console.ReadLine();
            } while (string.IsNullOrEmpty(userWriting));
        }

        return userWriting;
    }
}


class Program
{
    static void Main(string[] args)
    {
        //checking the text for name answer
        Console.WriteLine("What is your name?");
        Check first = new Check();
        string name = first.userInput();

        //console response
        Console.WriteLine("Hello " + name + ".");
        Console.WriteLine($"Did you know you name has {name.Length} characters in it?");

        //checking the text for hobby answer
        Console.Write("What's a hobby you have?");
        Check second = new Check();
        string hobby = second.userInput();

        //if statements for different messages by length
        if (hobby.Length > 25 && hobby.Length < 50){
            Console.WriteLine("Wow. That's quite a name for a hobby.");
        }
        else if (hobby.Length >= 50){
            Console.WriteLine("Wow, okay. That's a lot of detail for a hobby. Sure your real hobby isn't writing?");
        }
        else{
            Console.WriteLine("Hmm. Seems about average.");
        }

        //last goodbye
        Console.WriteLine("Welp, seems the conversation has run dry. Goodbye for now!");
    }
}
