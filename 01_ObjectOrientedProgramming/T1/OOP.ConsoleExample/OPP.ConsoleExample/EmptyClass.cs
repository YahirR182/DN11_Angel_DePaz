using System;
using AudioManager;
namespace OPP.ConsoleExample
{
	public class EmptyClass
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
            Animal animal = new Animal();
            animal.AnimalSound();
            Console.ReadKey();
            

		}
	}
}

