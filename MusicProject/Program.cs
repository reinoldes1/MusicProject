// C# Training

Song song1 = new Song();
song1.name = "Doomed";
song1.artist = "Bring me the Horizon";
song1.duration = 360;
song1.available = true;

Song song2 = new Song();
song2.name = "The Summoning";
song2.artist = "Sleep Token";
song2.duration = 243;
song2.available = false;

Song song3 = new Song();
song3.name = "Custer";
song3.artist = "Slipknot";
song3.duration = 275;
song3.available = true;

song1.ShowTrackDetails();
song1.ShowNameArtist();
song2.ShowTrackDetails();
song2.ShowNameArtist();
song3.ShowTrackDetails();
song3.ShowNameArtist();