using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    public static void Main()
    {
        List<string> phoneBook = new List<string>();
        phoneBook.Add("John Parrot 06786543276");
        phoneBook.Add("Lily Spider 0554865321");
        phoneBook.Add("Jake Cat 0568536743");
        phoneBook.Add("Din Dog 099564634589");
        phoneBook.Add("Silvia Hamster 044566784326");

        Console.WriteLine("Enter command: search/add/quit");
        string userInput = Console.ReadLine();
        while (userInput != "quit")
        {
            if (userInput == "search")
            {
                Console.WriteLine("What do you want to search?");
                Console.WriteLine(search(phoneBook, Console.ReadLine()));
            }
            else if (userInput == "add")
            {
                Console.WriteLine("What do you want to add?");
                addContact(phoneBook, Console.ReadLine());
            }
            Console.WriteLine("Enter command: search/add/quit");
            userInput = Console.ReadLine();
        }
    }

    static String search(List<string> data, String search)
    {
        foreach (string element in data)
        {
            if (element.Contains(search))
            {
                return element;
            }
        }
        return "There is no such contact";
    }

    static void addContact(List<string> data, String contact)
    {
        data.Add(contact);
        Console.WriteLine("added " + contact);
    }
}