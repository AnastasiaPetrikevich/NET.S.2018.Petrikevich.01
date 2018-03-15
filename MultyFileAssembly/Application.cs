using System;
using House;

class Program
{
    static void Main()
    {
        Cottage cottage = new Cottage();
        cottage.CottageInfo();

        Flat flat = new Flat();
        flat.FlatInfo();

        Mansion mansion = new Mansion();
        mansion.MansionInfo();

        Console.ReadLine();
    }
}