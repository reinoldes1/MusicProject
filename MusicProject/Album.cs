using System;
using System.Collections.Generic;
using System.Linq;

class Album
{
    private List<Song> songs = new List<Song>();
    public string Name { get; set; }
    public int ReleaseDate { get; set; }
    public int FullLenght => songs.Sum(s => s.Duration);
    public void AddSongs(Song song)
    {
        if (song.Album == Name)
        {
            songs.Add(song);
            songs = songs.OrderBy(s => s.Name).ToList();
        }
    }
    public void ShowAlbumSongs()
    {
        Console.WriteLine($"Songs from the album {Name}:\n");

        foreach (var song in songs)
        {
            Console.WriteLine($"Song: {song.Name}");
        }

        Console.WriteLine($"\nThis album has {FullLenght} seconds");
        Console.WriteLine("\n");
    }
}