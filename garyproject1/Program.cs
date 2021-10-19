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

             Ask("How are you doing today then darling on a scale of 1 to 10?");
        
        
            //ask them how they are
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
                Console.WriteLine("congratulations \n*Next Question is:");
            
                }
            else
                Console.WriteLine("It's False \n*Please Try Again.");

                Console.ReadLine();

        }
        static void Ask(string question)
         {
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            Console.WriteLine($"Well darling, I have another question for you");

        }
        
    }
}   
