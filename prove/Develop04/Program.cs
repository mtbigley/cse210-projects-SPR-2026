    using System;

    class Program
    {
        static void Main(string[] args)
        {

            Activity spin = new Activity("spin", "spinning animation");
            Activity count = new Activity ("count", "countdown timer"); // put this here just in case, realizing I might not need it in program.cs-- I'll keep it around for a few more commits just in case 

            while(true)
            {
                Console.Clear();

                Console.WriteLine("_____Menu options_____");
                Console.WriteLine("1. Breathing activity");
                Console.WriteLine("2. Reflection activity");
                Console.WriteLine("3. Listing activity");
                Console.WriteLine("4. Exit");
                spin.Spinner(1);
                Console.WriteLine("Please select an activity to do from the menu: ");
                Console.WriteLine();

                string input = Console.ReadLine();

                spin.Spinner(1);

                if (input == "1")
                {
                    Console.WriteLine("Starting Breathing activity");
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunBreathingActivity();
                }
                
                else if (input == "2")
                {
                    Console.WriteLine("Starting Reflection activity");
                    ReflectionActivity reflection = new ReflectionActivity(); 
                    reflection.RunReflectionActivity();
                }

                else if (input == "3")
                {
                    Console.WriteLine("Starting Listing activity");
                    ListingActivity listing = new ListingActivity();
                    listing.RunListingActivity();
                }

                else if (input == "4")
                {
                    Console.WriteLine("Bye for now!");
                    spin.Spinner(1);
                    break; 
                }

                else
                {
                    Console.WriteLine("Invalid choice.");
                }

                Console.WriteLine();
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
        }






        /* // SPINNER TEST CODE
            
            Activity test = new Activity("test", "testing spinner");

            Console.WriteLine("Test spinner for 2 seconds");
            test.Spinner(5);
            Console.WriteLine();
            Console.WriteLine("Test complete"); */ 

        /* // COUNTDOWN FUNCTIONALITY TEST CODE
            Activity test = new Activity("test", "testing countdown");
            
            Console.WriteLine("Testing Countdown for 5 seconds");
            test.Countdown(15);
            Console.WriteLine();
            Console.WriteLine("Test complete"); */

        /*// BREATHING ACTIVITY TEST CODE
            BreathingActivity test = new BreathingActivity(); 

            test.RunBreathingActivity();
            
            Console.WriteLine();
            Console.WriteLine("test complete");*/
    }