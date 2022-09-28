class Laptop : Computer
{
    public int Weight { get; set; }

    public override string ToString()
    {
        return "**************************************************************************"
        + $"\nThis laptops weight is {Weight} gram."
        + $"\nThis laptop comes with {Ram} GB ram and have a storage unit of {Storage} GB.";
    }
}