using System;
using System.Reflection;

class Program
{
    // 3
    static void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Library!");
    }
    // 4
    static void PrintBookTitle(string title)
    {
        Console.WriteLine("Book title: " + title);
    }
    // 5
    static void AddBonusPages(int pages)
    {
        pages += 50;
    }
    // 6
    static void ApplyDiscount(double[] prices)
    {
        prices[0] -= 5;
    }
    // 7
    static void AddBonusPagesByRef(ref int pages)
    {
        pages += 50;
    }
    // 8
    static void ReplaceArray(ref double[] prices)
    {
        prices = new double[] { 10.0, 12.5, 15.0 };
    }
    // 9
    static bool TryGetPrice(string title, out double price)
    {
        if (title == "Clean Code")
        {
            price = 25.5;
            return true;
        }

        price = 0;
        return false;
    }
    // 10
    static void PrintBookInfo(string title, int pages = 300)
    {
        Console.WriteLine($"Title: {title}, Pages: {pages}");
    }
    // 11
    static void PrintAllTitles(params string[] titles)
    {
        foreach (string title in titles)
        {
            Console.WriteLine(title);
        }
    }
    // 12
    static void Main(string[] args)
    {

        int pages = 400;
        double[] discountPrices = { 25.5, 40.0 };

        // 1
        double[] price = { 33.75, 40.0, 25.5 };
        Console.WriteLine($"prices: {price[1]}");

        //2
        int[,] shelfCopies = {
             { 3, 5},
             { 1, 4},
         };
        Console.WriteLine($"shelfCopies : {shelfCopies[1, 0]}");


        PrintWelcomeMessage();
        PrintBookTitle("Clean Code");
        AddBonusPages(pages);
        Console.WriteLine($"AddBonusPages: {pages}");
        ApplyDiscount(discountPrices);
        Console.WriteLine($"ApplyDiscount: {discountPrices[0]}");
        AddBonusPagesByRef(ref pages);
        Console.WriteLine($"AddBonusPagesByRef: {pages}");
        ReplaceArray(ref discountPrices);
        Console.WriteLine($"ReplaceArray: {discountPrices.Length}");
        if (TryGetPrice("Clean Code", out double foundPrice))
        {
            Console.WriteLine($"Found price: {foundPrice}");
        }
        else
        {
            Console.WriteLine("not found.");
        }
        PrintBookInfo("C# in Depth");
        PrintBookInfo("Design Patterns", 395);
        PrintBookInfo(pages: 520, title: "CLR via C#");
        PrintAllTitles("Clean Code", "The Pragmatic Programmer", "Refactoring");
    }
}
