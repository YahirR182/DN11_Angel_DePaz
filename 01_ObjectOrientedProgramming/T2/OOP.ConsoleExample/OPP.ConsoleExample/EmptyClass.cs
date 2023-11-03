using System;
using AudioManager;
namespace OPP.ConsoleExample
{
	public class EmptyClass
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Type the animal!");
            string animalType = Console.ReadLine() ?? "DefaultAnimalType";

            Animal? animal = null;

			switch (animalType)
			{
				case "cat":
					animal = new Cat();
					break;
                case "cow":
                    animal = new Cow();
                    break;
                case "dog":
                    animal = new Dog();
                    break;
                case "elephant":
                    animal = new Elephant();
                    break;
                case "lion":
                    animal = new Lion();
                    break;
                case "pig":
                    animal = new Pig();
                    break;
                default:
                    Console.WriteLine("Animal not found");
                    break;

            }

            if (animal != null)
            {
                animal.AnimalSound();
            }
        }
	}
}

