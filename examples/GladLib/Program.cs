using System;

namespace GladLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a noun then press Enter: ");
            var noun1 = Console.ReadLine();
            Console.Write("Enter another noun: ");
            var noun2 = Console.ReadLine();
            Console.Write("Enter a verb: ");
            var verb1 = Console.ReadLine();

            Console.WriteLine("You stand in a room and see a " + noun1 + " and a " + noun2 + ".");
            Console.WriteLine(string.Concat("For no reason at all you decide to pick up the ", noun2, " and ", verb1, "."));
            Console.WriteLine(string.Format("You {0} and {0} repeatedly and eventually trip over the {1}.", verb1, noun1));
            Console.WriteLine("You consider trying to {0} again but the {1} is still there so you think better of it.", verb1, noun1);
            Console.WriteLine($"Determined, you {verb1} but still trip over the {noun1}.");

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("You have died.\n(╯°□°)╯ / ┻━┻");
        }
    }
}
