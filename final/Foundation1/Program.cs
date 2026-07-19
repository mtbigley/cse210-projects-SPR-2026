using System;

class Program
{
    static void Main(string[] args)
    {
        // test code
        Video video1 = new Video("You have Uno!", "McLovin", 50);
        Video video2 = new Video("Frogge", "Luke Correia", 26); 

        Comment comment1 = new Comment("ItsMcLovinXD", "Just so everyone knows, this video was not originally mine. All credit goes to NobodyEpic for the original footage back in the day.");
        Comment comment2 = new Comment("BDSbowling", "“The oldest xbox known to man” lol");
        Comment comment3 = new Comment("Akula111", "a dwarf bursts into the tavern holding a tiny frog in his hands and start ranting to everybody about how cool it is");
        Comment comment4 = new Comment("Sonichero151", "When the Scottish Pokemon Trainer talks about her Politoad");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video2.AddComment(comment3);
        video2.AddComment(comment4);

        
    }
}