class Smartphones : Computer
{
    public int Selfies { get; set; }

    public int PrintWeightInfo()
    {
        return Selfies++;
    }

    public override string ToString()
    {
        return "**************************************************************************"
        + $"\nThe mobilephone has been used {Selfies} times for selfies. GET A HOLD ON YOURSELF";
    }
}