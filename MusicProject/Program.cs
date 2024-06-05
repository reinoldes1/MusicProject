// C# Training

Song song1 = new Song();
song1.Name = "Doomed";
song1.Album = "That's the Spirit";
song1.Artist = "Bring me the Horizon";
song1.Duration = 360;
song1.Available = true;

Song song2 = new Song();
song2.Name = "The Summoning";
song2.Album = "Take me back to Eden";
song2.Artist = "Sleep Token";
song2.Duration = 243;
song2.Available = false;


Song song3 = new Song();
song3.Name = "Custer";
song3.Album = "5: The Grey Chapter";
song3.Artist = "Slipknot";
song3.Duration = 275;
song3.Available = true;

Song song4 = new Song();
song4.Name = "Happy Song";
song4.Album = "That's the Spirit";
song4.Artist = "Bring me the Horizon";
song4.Duration = 210;
song4.Available = true;

Album album = new Album();
album.Name = "That's the Spirit";

List<Song> songs = new List<Song> {song1, song2, song3, song4};

foreach (var song in songs) 
{ 
    album.AddSongs(song); 
}

album.ShowAlbumSongs();
song1.ShowTrackDetails();
song2.ShowTrackDetails();
song3.ShowTrackDetails();
song4.ShowTrackDetails();
