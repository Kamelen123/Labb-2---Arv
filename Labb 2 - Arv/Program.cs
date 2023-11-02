namespace Labb_2___Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog()
            //{
            //    Name = "dawg",
            //    Nocturnal = false,
            //    TopSpeed = 0,
            //    Age = 0,
            //    Species = "Dog"
            //};

            Human human1 = new Human("Torbjörn", 28, 0, true, "Human", "");
            human1.Questions = "Koden känns väldigt upprepande, går det att ta bort något i koden? " +
                "och varför fungerar det inte att skriva så som jag har gjort i kommentaren ovan? :)";
            human1.AsksAQuestions();
            human1.MakeSound();
            human1.Eat();
            human1.Running();
            Console.WriteLine("------------------------------");
            Human human2 = new Human("Anas", 35, 30, false, "Human", "Har inga frågor, eller? ^^");
            human2.AsksAQuestions();
            human2.MakeSound();
            human2.Eat();
            human2.Running();
            Console.WriteLine("------------------------------");
            Cat cat1 = new Cat("DawgtheCat", 12, 40, true, "Cat", 9);
            cat1.MakeSound();
            cat1.Eat();
            cat1.Running();
            cat1.Climbing();
            Console.WriteLine("------------------------------");
            Cat cat2 = new Cat("Måns", 13, 60, true, "Cat", 8);
            cat2.MakeSound();
            cat2.Eat();
            cat2.Running();
            cat2.Climbing();
            Console.WriteLine("------------------------------");
            Dog dog1 = new Dog("Dawg", 7, 65, false, "Dog", 0);
            dog1.Happy(dog1.TailLengt);
            dog1.MakeSound();
            dog1.Eat();
            dog1.Running();
            Console.WriteLine("------------------------------");
            Dog dog2 = new Dog("Acke", 5, 60, false, "Dog", 2);
            dog2.Happy(dog2.TailLengt);
            dog2.MakeSound();
            dog2.Eat();
            dog2.Running();
            Console.WriteLine("------------------------------");
            SmallDog smallDog1 = new SmallDog("hans", 7, 30, false, "Dog", 15, 2);
            smallDog1.MakeSound();
            smallDog1.Eat();
            smallDog1.Running();
            smallDog1.Happy(smallDog1.TailLengt);
            smallDog1.GetsPickedUP();
            Console.WriteLine("------------------------------");
            SmallDog smallDog2 = new SmallDog("Mini", 7, 30, false, "Dog", 1, 0);
            smallDog2.MakeSound();
            smallDog2.Eat();
            smallDog2.Running();
            smallDog2.Happy(smallDog2.TailLengt);
            smallDog2.GetsPickedUP();
            Console.WriteLine("------------------------------");
            BigDog bigDog1 = new BigDog("Jumbo", 9, 40, false, "Dog", 30, 2);
            bigDog1.MakeSound();
            bigDog1.Eat();
            bigDog1.Running();
            bigDog1.Happy(bigDog1.TailLengt);
            bigDog1.GetsPickedUP();
            Console.WriteLine("------------------------------");
            BigDog bigDog2 = new BigDog("Mellanbocken Bruse", 7, 40, false, "Dog", 30, 0);
            bigDog2.MakeSound();
            bigDog2.Eat();
            bigDog2.Running();
            bigDog2.Happy(bigDog2.TailLengt);
            bigDog2.GetsPickedUP();
        }
    }
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int TopSpeed { get; set; }
        public bool Nocturnal { get; set;}
        public string Species { get; set; }

        public Animal( string name, int age, int topspeed, bool nocturnal, string species) 
        {
            Name = name;
            Age = age;
            TopSpeed = topspeed;
            Nocturnal = nocturnal;
            Species = species;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} Makes a Sound!");
        }
        public void Running()
        {
            Console.WriteLine($"{Name} Can run with a top speed of {TopSpeed} km/h");
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} Eats Something Yummy");
        }
    }
    public class Dog : Animal 
    {
        public int TailLengt { get; set; }
        public Dog(string name, int age, int topspeed, bool nocturnal, string species, int tailLengt)
            : base(name, age, topspeed, nocturnal, species)
        {
            TailLengt = tailLengt;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is Barking, Woof Woof!");
        }
        public void Happy(int tailLengt)
        {
            if (tailLengt > 1)
            { 
                Console.WriteLine($"{Name} is Wagging his Tail in Happiness "); 
            }
            else 
            {
                Console.WriteLine($"{Name} is Wagging his tail, in Happiness, but it's harder to see");
            }

        }
    }
    public class Human : Animal
    {
        public string Questions { get; set; }
        public Human(string name, int age, int topspeed, bool nocturnal, string species, string questions)
            : base(name, age, topspeed, nocturnal, species)
        {
            Questions = questions;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is Speaking, Woof Woof, oj så säger man inte!");
        }
        public void AsksAQuestions()
        {
            Console.WriteLine(Questions);
        }
    }
    public class Cat : Animal
    {
        public int NumberOfLives { get; set; }

        public Cat(string name, int age, int topspeed, bool nocturnal, string species, int numberoflives)
            : base(name, age, topspeed, nocturnal, species)
        {
            NumberOfLives = numberoflives;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is Purring");
        }
        public void Climbing()
        {
            Console.WriteLine($"{Name} Climbes up the tree");
        }
    }
    public class SmallDog : Dog
    {
        public int Weight { get; set; }
        public SmallDog(string name, int age, int topspeed, bool nocturnal, string species, int tailLengt, int weight)
            : base(name, age, topspeed, nocturnal, species, tailLengt)
        {
            Weight = weight;
        }
        public void GetsPickedUP()
        {
            if ( Weight < 5 )
            {
                Console.WriteLine($"{Name} is Tiny and is easy to Carry");
            }
            Console.WriteLine($"{Name} is not that Tiny but still easy to Carry");
        }
    }
    public class BigDog : Dog
    {
        public int Weight { get; set; }
        public BigDog(string name, int age, int topspeed, bool nocturnal, string species, int tailLengt, int weight)
            : base(name, age, topspeed, nocturnal, species, tailLengt)
        {
            Weight = weight;
        }
        public void GetsPickedUP()
        {
            if (Weight < 25)
            {
                Console.WriteLine($"{Name} is a Big Dog but gets Picked Up Anyways");
            }
            Console.WriteLine($"{Name} is a very Big Dog but gets Picked up Anyways");
        }

    }

}