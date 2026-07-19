using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>(); 

        // Create 3-4 videos and set appropriate values 
        Video video1 = new Video("You have Uno!", "McLovin", 50);
        Video video2 = new Video("Frogge", "Luke Correia", 26); 
        Video video3 = new Video("McDonald's Newest Sandwich - The MacBeth", "GameChangerShorts", 60);
        Video video4 = new Video("Just a complicated country lawyer", "GameChangerShorts", 60);

        // Video 1 comments
        Comment comment1 = new Comment("ItsMcLovinXD", "Just so everyone knows, this video was not originally mine. All credit goes to NobodyEpic for the original footage back in the day.");
        Comment comment2 = new Comment("BDSbowling", "“The oldest xbox known to man” lol");
        Comment comment3 = new Comment("goldensunset-yt", "i love the way it escalates WAY quicker than it needs to. within two lines they get hostile for no reason at all");
        Comment comment4 = new Comment("dead-aaa623", "Meanwhile in another universe: 'You guys wanna play uno real quick and make it my upload tonight?' 'Yeah sure.'");

        // Video 2 comments
        Comment comment5 = new Comment("Akula111", "a dwarf bursts into the tavern holding a tiny frog in his hands and start ranting to everybody about how cool it is");
        Comment comment6 = new Comment("Sonichero151", "When the Scottish Pokemon Trainer talks about her Politoad");
        Comment comment7 = new Comment("derpymule7977", "I’m not laughing about the article or about the accent. I’m laughing at how aggressive this man is about the frogge");
        Comment comment8 = new Comment("mrfancysnail2699", "i would love to see a whole series just reading more Wikipedia like this. edited to clarify my intent");

        // Video 3 comments
        Comment comment9 = new Comment("markosmywords9202", "This wasn't improv, he just got possessed by Macbeth");
        Comment comment10 = new Comment("tomm9789", "The 'ba da ba ba ba' is played with bagpipes");
        Comment comment11 = new Comment("Cainerr", "“THAT TRUSTED THE BUTCHER WITH ITS LIFE!” Like how Duncan trusted Macbeth with his.");
        Comment comment12 = new Comment("KiraAsakura14", "'When the dawn breaks, how shall ye break yer fast.' Poetry/10");

        // Video 4 comments
        Comment comment13 = new Comment("korumann", "I love the twist from 'It's only a crime if you get caught' into 'You made it a crime by witnessing it'");
        Comment comment14 = new Comment("thefinalgrimswald354", "To Confuse a Mockingbird");
        Comment comment15 = new Comment("Kelarys", "In a surprise verdict, the jury declared itself guilty");
        Comment comment16 = new Comment("FruitPuppyYT", "Ross breaking out the handkerchief like they’re Atticus Finch lmaooo");

        // Add comments to lists
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment4);

        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);
        video2.AddComment(comment8);

        video3.AddComment(comment9);
        video3.AddComment(comment10);
        video3.AddComment(comment11);
        video3.AddComment(comment12);

        video4.AddComment(comment13);
        video4.AddComment(comment14);
        video4.AddComment(comment15);
        video4.AddComment(comment16);

        //add videos to list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // iterate through videos
        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}