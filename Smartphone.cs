class Smartphones : Computer
{
    public int Selfies { get; set; }

    public int PrintWeightInfo()
    {
        return Selfies++;
    }

    public override string GetInfo()
    {
        return "**************************************************************************"
        + $"\nThe mobilephone has been used {Selfies} times for selfies. GET A HOLD ON YOURSELF";
    }
}