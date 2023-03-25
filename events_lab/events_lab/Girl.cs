using System;
namespace events_lab
{
	public class Girl
	{
        public string dayOfWeek { get; set; }
        public string GirlCondition { get; set; }

        public Girl()
		{
			dayOfWeek = "No day";
		}

		public Girl(string day)
		{
			dayOfWeek = day;
		}

        public override string ToString()
        {
            return $"It is {dayOfWeek} and I am {GirlCondition}";
        }

        public void WhenUp(object sender)
        {
            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                GirlCondition = "studying. No time for flowers";
                Console.WriteLine($"Today is {dayOfWeek}, sun is {sender as Sun}. Girl is {GirlCondition}");
            }
            if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                GirlCondition = "smelling flowers";
                Console.WriteLine($"Today is {dayOfWeek}, sun is {sender as Sun}. Girl is {GirlCondition}");
            }
        }

        public void WhenDown(object sender)
        {
            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                GirlCondition = "smelling flowers";
                Console.WriteLine($"Today is {dayOfWeek}, sun is {sender as Sun}. Girl is {GirlCondition}");
            }
            if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                GirlCondition = "studying. No time for flowers";
                Console.WriteLine($"Today is {dayOfWeek}, sun is {sender as Sun}. Girl is {GirlCondition}");
            }
        }
    }
}

