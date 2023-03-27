class Dog : DomesticAnimal
{
    public override string sound()
    {
        return "Guau guau";
    }

    public void view_sound_dog(){
        Console.WriteLine(sound());
    }

}