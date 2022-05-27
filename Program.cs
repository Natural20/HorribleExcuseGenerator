using System;
using System.Collections.Generic;

namespace HorribleExcuseGenerator
{
    //Horrible Excuse Generator
    //intended for use by deadweight to continue pulling a salary,
    //while pushing the work they're responsible for on actually qualified engineers.

    //As you might tell, I'm bitter about loudmouths that do nothing while continuing to claim
    //credit for my work and getting praise for it, so I thought I'd help them along

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uh oh, looks like you have something due...");
            Console.WriteLine("type excuses for 100 horrible excuses, exit to exit:  ");

            int excuseCount = 1;
            string input = "";
            while (input != "exit")
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "exit":
                        return;
                    case "excuses":
                        GenerateExcuse(ThingsToGetOutOf, ThingsToBlame, PersonOrPetToBlame, ObjectExcuseRoot);
                        break;
                    default:
                        Console.WriteLine("Guess you can't read instructions.  Shit, you really do need this tool.");
                        break;
                }
                excuseCount++;
            }
        }

        public static List<string> ThingsToGetOutOf = new List<string>()
        {
            "finish that task"
        ,   "go to that meeting"
        ,   "publish the change"
        ,   "make it today"
        ,   "review that code"
        ,   "send that to you"
        ,   "make it in to work today"
        ,   "proceed on that"
        ,   "really explain what's going on"
        ,   "provide assistance on that"
        ,   "give an answer on that"
        ,   "deploy to production"
        ,   "give you any more information on that"
        ,   "provide more information"
        ,   "complete the ticket"
        };

        public static List<string> ThingsToBlame = new List<string>()
        {
            "my laptop"
        ,   "my email"
        ,   "Visual Studio"
        ,   "SQL Server"
        ,   "my camera"
        ,   "my left monitor"
        ,   "my right monitor"
        ,   "my wrong monitor"
        ,   "my internet"
        ,   "my keyboard"
        ,   "my mouse"
        ,   "my house"
        ,   "my manager"
        ,   "my dog"
        ,   "my cat"
        ,   "my lizard"
        ,   "the dartboard"
        };

        public static List<string> PersonOrPetToBlame = new List<string>()
        {
        };

        public static List<string> ObjectExcuseRoot = new List<string>()
        {
            "is on fire"
        ,   "was hit by lightning"
        ,   "got zapped with static electricity"
        ,   "got water poured on it"
        ,   "got a bad update"
        ,   "doesn't have the right permissions"
        ,   "is giving me an error"
        ,   "isn't working"
        ,   "doesn't have a wots"
        ,   "doesn't have a task"
        ,   "didn't get a ticket assigned yet"
        ,   "is waiting for more information"
        ,   "is experiencing issues"
        ,   "is slow"
        ,   "is down"
        ,   "has covid"
        };

        public List<string> PersonOrPetExcuseDescriptor = new List<string>()
        {

        };

        public List<string> PersonOrPetObjectModifier = new List<string>()
        {

        };

        public List<string> ExcusePreamble = new List<string>()
        {
            "I can't"
        ,   "I'm unable to"

        };

        static void GenerateExcuse(List<string> ThingsToGetOutOf, List<string> ThingsToBlame, List<string> PeopleToBlame, List<string> ExcusesRoot)
        {
            Random rnd = new Random();
            int excusesCount = 1;
            while(excusesCount < 100)
            {
                string ThingToGetOutOf = ThingsToGetOutOf[rnd.Next(0, ThingsToGetOutOf.Count];
                string ThingToBlame = ThingsToBlame[rnd.Next(0, ThingsToBlame.Count)];
                string ExcuseRoot = ExcusesRoot[rnd.Next(0, ExcusesRoot.Count)];

                Console.WriteLine("I can't {0} because {1} {2}", ThingToGetOutOf, ThingToBlame, ExcuseRoot);
                excusesCount++;
            }

        }
    }
}
