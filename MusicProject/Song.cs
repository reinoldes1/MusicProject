class Song 
{
    public string Name {  get; set; }
    public string Artist { get; set; }
    public string Album { get; set; }
    public int Duration { get; set; }
    public bool Available {  get; set; }
    public string ShortDescription => $"The song '{Name} by {Artist}' has {Duration} seconds";
    public void ShowTrackDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Duration: {Duration}");
        Console.WriteLine($"{ShortDescription}");
        if (Available) Console.WriteLine("Available to listen");
        else Console.WriteLine("Not available to listen at the moment");
        Console.WriteLine("\n");
    }

}