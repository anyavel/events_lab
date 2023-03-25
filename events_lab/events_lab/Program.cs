namespace events_lab;
class Program
{
    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    static void Main(string[] args)
    {
        Sun sun = new Sun();
        Flower poppy = new Flower("Poppy", "day", 5);
        Flower chamomile = new Flower("Chamomile", "day", 2);
        Flower matiola = new Flower("Matiola", "evening", 8);
        Girl girl = new Girl("Monday");
        Bee bee = new Bee();
        sun.Up += girl.WhenUp;
        sun.Up += poppy.WhenUp;
        sun.Up += chamomile.WhenUp;
        sun.Up += matiola.WhenUp;
        sun.Up += bee.WhenUp;

        sun.Down += girl.WhenDown;
        sun.Down += poppy.WhenDown;
        sun.Down += chamomile.WhenDown;
        sun.Down += matiola.WhenDown;
        sun.Down += bee.WhenDown;

        Console.Write('\n');

        Flower[] flowers = new Flower[3];
        flowers[0] = poppy;
        flowers[1] = chamomile;
        flowers[2] = matiola;
        for (int i = 0; i < flowers.Length; ++i)
        {
            Console.Write(flowers[i]);
        }
        Console.Write('\n');

        for (int j = 0; j < 7; ++j)
        {
            Console.WriteLine("-----------------------------------------------------------------------");
            girl.dayOfWeek = ((Days)j).ToString();
            sun.IsUp();
            Console.Write('\n');
            for (int i = 0; i < 3; ++i)
            {
                flowers[i].GettingOlder();
            }
            Console.Write('\n');
            sun.IsDown();
            Console.Write('\n');
        }

    }

    
}

