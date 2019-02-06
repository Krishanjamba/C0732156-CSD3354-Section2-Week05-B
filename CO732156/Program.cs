using System;

namespace CO732156
{
    class Program
    {
        static void Main(String[] args)
        {
            LinkedList a = new LinkedList();
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

    }

    class LinkedList
    { 
        public Dog current = new Dog();
        public Dog Head = new Dog();
        public Dog Peanut = new Dog();
        public Dog Fifi = new Dog();
        public Dog Jordan = new Dog();
        public Dog Fido = new Dog();

        public void run()
        {
            Head = Peanut;
            Peanut.DogName = "Peanut";
            Peanut.DogBreed = "Bichon";

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

