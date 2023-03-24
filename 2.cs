using System;

class Package
{
    public string Description { get; set; }
    public double Weight { get; set; }

    public Package(string description, double weight)
    {
        Description = description;
        Weight = weight;
    }
}

class ShippingService
{
    private double weightLimit;
    private double totalWeight;

    public ShippingService(double weightLimit)
    {
        this.weightLimit = weightLimit;
        this.totalWeight = 0;
    }

    public void SendPackage(Package package)
    {
        if (totalWeight + package.Weight > weightLimit)
        {
            Console.WriteLine("Error: package weight limit exceeded.");
            return;
        }

        Console.WriteLine("Sending package: {0} ({1} kg)", package.Description, package.Weight);
        totalWeight += package.Weight;
    }
}

class Program
{
    static void Main()
    {
        ShippingService shippingService = new ShippingService(10.0);

        Package package1 = new Package("Book", 1.0);
        Package package2 = new Package("Shoes", 2.5);
        Package package3 = new Package("Computer", 5.0);

        shippingService.SendPackage(package1);
        shippingService.SendPackage(package2);
        shippingService.SendPackage(package3);
    }
}
