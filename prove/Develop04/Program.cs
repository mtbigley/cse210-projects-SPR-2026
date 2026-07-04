    using System;

    class Program
    {
        static void Main(string[] args)
        {

            Activity spin = new Activity("spin", "spinning animation");

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
                }
                
                else if (input == "2")
                {
                    Console.WriteLine("Starting Reflection activity");
                }

                else if (input == "3")
                {
                    Console.WriteLine("Starting Listening activity");
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
            test.Countdown(5);
            Console.WriteLine();
            Console.WriteLine("Test complete"); */
    }