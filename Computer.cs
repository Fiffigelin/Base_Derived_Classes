class Computer
{
    public int Ram { get; set;}
    public int Storage { get; set; }
    public string Keyboard { get; set; }

    private int _serialNumber { get; set; }

    public Computer()
    {
        _serialNumber++;
    }

    public void AddRam()
    {
        Ram++;
    }

        public void AddStorage()
    {
        Storage++;
    }

    public void AddKeys(string s)
    {
        Keyboard = s;
    }

    public virtual string GetInfo()
    {
        return "**************************************************************************"
        + $"\nThis is a computer with {Ram} GB ram and have a storage unit of {Storage} GB." 
        + $"\nSerialnumber : {_serialNumber}"
        + $"\nThe keyboard have this key : {Keyboard}";
    }
}