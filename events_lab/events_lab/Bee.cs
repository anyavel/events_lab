using System;
namespace events_lab
{
	public class Bee
	{
        public string BeeCondition { get; set; }

        public override string ToString()
        {
            return $"Bee is {BeeCondition} now";
        }

        public void WhenUp(object sender)
        {
            BeeCondition = "working";
            Console.WriteLine($"Sun is {sender as Sun} so bee is {BeeCondition}");
        }

        public void WhenDown(object sender)
        {
            BeeCondition = "sleeping";
            Console.WriteLine($"Sun is {sender as Sun} so bee is {BeeCondition}");
        }

    }
}

