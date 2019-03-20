using System;

namespace AnimalsEXE1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pig pig1 = new Pig("Domestic", 12);
            Sheep sheep1 = new Sheep("Dorset Horn", 5);
            Llama llama1 = new Llama("Alpaca", 7);
            Cow cow1 = new Cow("Angus", 4);
            Bird bird1 = new Bird("Duck", 15);


            Console.WriteLine(pig1.GetPigDeets());
            Console.WriteLine(sheep1.GetSheepDeets());
            Console.WriteLine(llama1.GetLlamaDeets());
            Console.WriteLine(cow1.GetCowDeets());
            Console.WriteLine(bird1.GetBirdDeets());

            Console.ReadLine();
        }
    }

    class Animal
    {
        public int Age { get; set; }
        public string Type { get; set; }
    }

    class Pig : Animal
    {
        public Pig(string _type, int _age)
        {
            Type = _type;
            Age = _age;
        }

        public string GetPigDeets()
        {
            return $"PIG; Type: {Type}, Age: {Age}";
        }
    }

    class Sheep : Animal
    {
        public Sheep(string _type, int _age)
        {
            Type = _type;
            Age = _age;
        }

        public string GetSheepDeets()
        {
            return $"SHEEP; Type: {Type}, Age: {Age}";
        }
    }
    class Llama : Animal
    {
        public Llama(string _type, int _age)
        {
            Type = _type;
            Age = _age;
        }
        public string GetLlamaDeets()
        {
            return $"LLAMA; Type: {Type}, Age: {Age}";
        }
    }
    class Cow : Animal
    {
        public Cow (string _type, int _age)
        {
            Type = _type;
            Age = _age;
        }
        public string GetCowDeets()
        {
            return $"COW; Type: {Type}, Age: {Age}";
        }
    }
    class Bird : Animal
    {
        public Bird(string _type, int _age)
        {
            Type = _type;
            Age = _age;
        }
        public string GetBirdDeets()
        {
            return $"BIRD; Type: {Type}, Age: {Age}";
        }
    }
}
