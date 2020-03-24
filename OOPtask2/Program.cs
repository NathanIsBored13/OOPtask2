using System;

namespace OOPtask2
{
    class Animal
    {
        protected string state;
        protected int size;

        public Animal(string s, int n)
        {
            state = s;
            size = n;
        }

        public void feed()
        {
            size++;
            Console.WriteLine($"{state} fed");
        }

        public string GetState() => state;

        public int GetSize() => size;
    }

    class Fish : Animal
    {
        private int maxSize;
        public Fish(string s) : base(s, 1)
        {
            maxSize = 2;
        }

        public void setMaxSize(int m)
        {
            maxSize = m;
        }

        public new void feed()
        {
            size += 2;
            Console.WriteLine($"{state} fed");
            if (size >= maxSize)
            {
                state = "BIG FISH";
            }
        }
    }

    class Duck : Animal
    {
        public Duck(string s, int n) : base(s, n) { }

        public new void feed()
        {
            base.feed();
            if (size == 5)
            {
                state = "BIG DUCK";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fish thisFish = new Fish("little Fish");
            thisFish.setMaxSize(3);
            Duck thisDuck = new Duck("little Duck", 1);
            for (int i = 0; i < 3; i++)
            {
                thisDuck.feed();
                Console.WriteLine(thisDuck.GetState());
                thisFish.feed();
                Console.WriteLine(thisFish.GetState());
            }
        }
    }
}
