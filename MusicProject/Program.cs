// C# Training

Song song1 = new Song();
song1.Name = "Doomed";
song1.Artist = "Bring me the Horizon";
song1.Duration = 360;
song1.Available = true;

Song song2 = new Song();
song2.Name = "The Summoning";
song2.Artist = "Sleep Token";
song2.Duration = 243;
song2.Available = false;

Song song3 = new Song();
song3.Name = "Custer";
song3.Artist = "Slipknot";
song3.Duration = 275;
song3.Available = true;


song1.ShowTrackDetails();
song2.ShowTrackDetails();
song3.ShowTrackDetails();


