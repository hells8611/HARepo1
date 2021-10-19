using System;
using System.IO;

namespace garyproject1
{
    class Program
    {
        static void Main(string[] args)
        {
            //hello world blurb
            Console.WriteLine("Hello World!");

            //ask them their name
            Console.Out.WriteLine("Please tell me your name darling");
            string input = Console.ReadLine();
            Console.WriteLine($"Hi {input} I love your name, so original");

            //ask them how they are
            Console.Out.WriteLine("How are you doing today then darling?");
            string status = Console.ReadLine();

            if (status == "good")
            
            {
            Console.WriteLine("Bringing all the joy to the world one smile at a time... I hope !");
            }
            else
            {
            Console.WriteLine("remember that all feelings are temporary and this will get better");
            }


            Console.WriteLine("Well darling, I have another question for you");
        
        
            
            //random questions for all involved
            Random question = new Random();
            int x = question.Next(3);
            string[] array = new string[3];
            array[0] = "-what kitchen appliance can be used to describe quantum physics?";
            array[1] = "-what is a popular camping kettle called?";
            array[2] = "-Finish this sentence - fur coat and no ...";
        
            Console.WriteLine(array[x]);

             string[] answer = new string[3];
             answer[0] = "toaster";
             answer[1] = "kelly kettle";
             answer[2] = "knickers";
            

            string a = Console.ReadLine();

             if (a == answer[x])
             {
                Console.WriteLine("congratulations");
            
            }
            else
            {
                Console.WriteLine("Incorrect, please try harder...");
            }
        }

    }
            

}