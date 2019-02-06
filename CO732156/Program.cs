using System;

namespace CO732156
{
    class Program
    {
        static void Main(String[] args)
        {
            LinkedList a = new LinkedList();
            a.run();
            a.WalkOverTheList();
            a.ReverseTheList();
        }
    }

    class Dog

    {
        public static int NumberOfDogs = 0;
        public Dog()
        {
            Dog.NumberOfDogs++;
        }
        public String DogName;
        public String DogBreed;
        public Dog nextDog;
        public Dog previousDog;

    }

    class LinkedList
    { 
        public Dog current = new Dog();
        public Dog Head = new Dog();
        public Dog Tail = new Dog();
        public Dog Peanut = new Dog();
        public Dog Fifi = new Dog();
        public Dog Jordan = new Dog();
        public Dog Fido = new Dog();
        public Dog Roy = new Dog();
        public Dog Coco = new Dog();

        public void run()
        {
            Head = Peanut;
            Tail = Fido;
            Peanut.DogName = "Peanut";
            Peanut.DogBreed = "Bichon";
            Peanut.nextDog = Fifi;
            Fifi.previousDog = 

            Peanut.nextDog = Fifi;

            Fifi.DogName = "Fifi";
            Fifi.DogBreed = "Poodle";

            Fifi.nextDog = Jordan;
            Jordan.DogName = "Jordan";
            Jordan.DogBreed = "German Shepperd";

            Jordan.nextDog = Fido;
            Fido.DogName = "Fido";
            Fido.DogBreed = "Beagle";
            Fido.nextDog = null;

            Coco.DogName = "Coco";
            Coco.DogBreed = "Border Colli";
            Coco.nextDog = Jordan;
            Coco.previousDog = Fifi;

            Roy.DogName = "Roy";
            Roy.DogBreed = "Tail";
            Roy.nextDog = 

        }
        public void WalkOverTheList()
        {
            current = Head;
            while (true)
            {
                Console.WriteLine(current.DogName);
                current = current.nextDog;
            }
        }
    }
}

