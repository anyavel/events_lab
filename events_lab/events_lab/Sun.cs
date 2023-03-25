using System;
namespace events_lab
{
	public class Sun
	{
        public string SunCondition { get; set; }

        public override string ToString()
        {
            return SunCondition;
        }

        public delegate void MyEvent(object sender);

        public event MyEvent Up;

        public event MyEvent Down;

        public void IsUp()
        {
           SunCondition = "up";
            if (Up != null) Up(this); 
        }

        public void IsDown()
        {
            SunCondition = "down";
            if (Down != null) Down(this);
        }

        
    }
}

