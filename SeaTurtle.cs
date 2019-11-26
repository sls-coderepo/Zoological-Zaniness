using System;

namespace ZoologicalZaniness
{
    public class SeaTurtle : IWalking, ISwimming
    {
        public int MaximumDepth { get; } = 100;

        public void Run()
        {
            Console.WriteLine("Animal is now running");
        }

        public void Swim()
        {
            Console.WriteLine("Animal is now swimming");
        }

        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }
    }
}