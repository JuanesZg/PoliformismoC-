// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter an Animal Code (1. Dog, 2. Cat or 0. exit)");
short AnimalCode = short.Parse(Console.ReadLine());

while (AnimalCode != 0)
{
    Console.WriteLine("Type a id:");
    string AnimalId = Console.ReadLine();

    Console.WriteLine("Type an age");
    short AnimalAge = short.Parse(Console.ReadLine());

    switch (AnimalCode)
    {
        case 1:
            var MyDog = new Dog()
            {
                Id = AnimalId,
                Age = AnimalAge
            };
            Console.WriteLine($"The Dog data is Id {MyDog.Id} and Age {MyDog.Age}");
            //Console.WriteLine($"{MyDog.to_run()} and does {MyDog.sound()}");
            MyDog.view_sound_dog();
            break;
        case 2:
            var MyCat = new Cat()
            {
                Id = AnimalId,
                Age = AnimalAge
            };
            Console.WriteLine($"The Cat data is Id {MyCat.Id} and Age {MyCat.Age}");
            //Console.WriteLine($"{MyCat.to_run()} and does {MyCat.sound()}");
            MyCat.view_sound_cat();
            break;

        default:
            Console.WriteLine("Domestic Animal does not exist");
            break;
    }

    Console.WriteLine("Enter an Animal Code (1. Dog, 2. Cat)");
    AnimalCode = short.Parse(Console.ReadLine());

}