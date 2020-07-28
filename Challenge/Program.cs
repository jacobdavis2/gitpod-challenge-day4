using System;
using System.Collections.Generic;

namespace Challenge
{
    class Program
    {
        // Challenge 1: Write a function that returns a list of three delegates,
        //  each mapped to one of the given functions: Sing(), TwoPlusTwoIs(),
        //  or WriteSomeText()
        public delegate void DelegatedWriter();
        public static List<DelegatedWriter> GetDelegates()
        {
            throw new NotImplementedException();
        }

        // Challenge 2: Given a list of names, return a subset of
        //  that list containing only names starting with "A".
        public static List<string> FilterNames(List<string> names)
        {
            throw new NotImplementedException();
        }

        // Challenge 3: Write a function that serializes it and returns
        //  the Banana in strng format. Next, write a function that takes
        //  a serialized Banana and returns it as a real Banana.
        public static string SerializeBanana(Banana b)
        {
            throw new NotImplementedException();
        }

        public static Banana DeserializeBanana(string serializedBanana)
        {
            throw new NotImplementedException();
        }

        // Do not edit anything below this line! 
        public static void Sing()
        {
            Console.WriteLine("Singing in the rain!");
        }

        public static void TwoPlusTwoIs()
        {
            Console.WriteLine(2 + 2);
        }

        public static void WriteSomeText()
        {
            Console.WriteLine("Some text written!");
        }

        static void Main(string[] args)
        {
            int testsPassed = 0, totalTests = 3;

            // Test for Challenge 1
            try
            {
                List<DelegatedWriter> writers = GetDelegates();

                if (writers.Count != 3)
                    Console.WriteLine("Challenge 1 failed: wrong number of elements!");
                else
                {
                    foreach(DelegatedWriter dw in writers)
                    {
                        dw();
                    }

                    ++testsPassed;
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Challenge 1 failed with an exception: " + e.Message);
            }

            // Test for Challenge 2
            try
            {
                List<string> names = new List<string> { "Jacob", "Mark", "Alfonso", "Nick", "Pushpinder", "Amy", "Austin", "Marielle" };
                List<string> onlyANames = FilterNames(names);

                if (onlyANames.Count == 3)
                {
                    bool good = true;
                    foreach (string s in onlyANames)
                    {
                        if (s[0] != 'a' && s[0] != 'A')
                        {
                            good = false;
                            Console.WriteLine("Challenge 2 failed: non-A name detected: " + s);
                        }
                    }

                    if (good)
                        ++testsPassed;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Challenge 2 failed with an exception: " + e.Message);
            }

            // Test for Challenge 3
            try
            {
                Banana b = new Banana();
                string serializedBanana = SerializeBanana(b);
                Banana newBanana = DeserializeBanana(serializedBanana);

                if (newBanana.Name == "Banana" && newBanana.Cost == 5 && newBanana.ScientificName == "Musa")
                    ++testsPassed;
            }
            catch (Exception e)
            {
                Console.WriteLine("Challenge 3 failed with an exception: " + e.Message);
            }

            // Results
            Console.WriteLine(testsPassed + " tests passed out of " + totalTests);

            if (testsPassed == totalTests)
                Console.WriteLine("All tests passed. Challenge complete!");
        }
    }
}
