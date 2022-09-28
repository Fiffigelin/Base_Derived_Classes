internal class Program
{
    // Utgår från Gustavs exempelkod bara för att inte fastna på smådetaljer som jag gärna gör :)
    private static void Main(string[] args)
    {
        Laptop newLaptop = new();
        newLaptop.Weight = 1542;
        newLaptop.Ram = 7;
        newLaptop.Storage = 255;
        newLaptop.AddStorage();
        newLaptop.AddRam();

        Smartphones newSmartphone = new();
        newSmartphone.Storage = 127;
        newSmartphone.Selfies = 93745;
        newSmartphone.AddStorage();

        Computer newComputer = new();
        newComputer.Ram = 16;
        newComputer.Storage = 238;
        newComputer.Keyboard = "A";

        List<Computer> listWithProducts = new();

        listWithProducts.Add(newLaptop);
        listWithProducts.Add(newSmartphone);
        listWithProducts.Add(newComputer);

        foreach (Computer item in listWithProducts)
        {
            Console.WriteLine(item.GetInfo());
        }

    }
}