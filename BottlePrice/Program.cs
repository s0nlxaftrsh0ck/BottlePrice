using System;

class BottlePrice
{
    static void Main()
    {
        string pricePerBottleString = Console.ReadLine();
        int pricePerBottle = int.Parse(pricePerBottleString);

        string tableCountString = Console.ReadLine();
        int tableCount = int.Parse(tableCountString);

        int bottleCount = ((tableCount + 99) / 100);

        int salePrice = bottleCount * pricePerBottle;

        Console.WriteLine ("The number of bottle is " +
                                          bottleCount);
        Console.WriteLine("The total price is " +
                                            salePrice);
    }
}