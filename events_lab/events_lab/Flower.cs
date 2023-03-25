using System;
namespace events_lab
{
	public class Flower 
	{
		private string flowerName;
        private string flowerType;
        private int numberOfDays;
        public string FlowerCondition { get; set; }
        public int countingDays = 0;
        
        public Flower()
		{
			flowerName = "No name";
			flowerType = "No type";
			numberOfDays = 0;
		}

        public Flower(string name, string type, int number)
        {
            flowerName = name;
            flowerType = type;
            numberOfDays = number;
        }

        public override string ToString()
        {
            return $"I am {flowerName}, {flowerType} flower. Number of my blooming days: {numberOfDays}\n";
        }

        public void WhenUp(object sender)
        {
            if (flowerType == "day")
            {
                FlowerCondition = "open";
                Console.WriteLine($"Sun is {sender as Sun} so {flowerName} is {FlowerCondition}");
            }
            if (flowerType == "evening")
            {
                FlowerCondition = "closed";
                Console.WriteLine($"Sun is {sender as Sun} so {flowerName} is {FlowerCondition}");
            }
        }

        public void WhenDown(object sender)
        {
            if (flowerType == "evening")
            {
                FlowerCondition = "open";
                Console.WriteLine($"Sun is {sender as Sun} so {flowerName} is {FlowerCondition}");
            }
            if (flowerType == "day")
            {
                FlowerCondition = "closed";
                Console.WriteLine($"Sun is {sender as Sun} so {flowerName} is {FlowerCondition}");
            }
        }

        public void GettingOlder()
        {
            if (countingDays < numberOfDays)
            {
                countingDays += 1;
                Console.WriteLine($"Your {flowerName} is blooming for {countingDays} days");
            }
            
            if (countingDays >= numberOfDays)
            {
                countingDays += 1;
                Console.WriteLine($"Sorry, your {flowerName} is dead");
            }
        }
    }
}

