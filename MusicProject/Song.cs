class Song 
{
    public string name;
    public string artist;
    public int duration;
    public bool available;

    public void ShowTrackDetails()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Artist: {artist}");
        Console.WriteLine($"Duration: {duration}");
        if (available) Console.WriteLine("Available to listen");
        else Console.WriteLine("Not available to listen at the moment");
    }
}