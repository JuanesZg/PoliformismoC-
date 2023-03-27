abstract class DomesticAnimal{
    //Propiedades
    public string Id { get; set; }
    public short Age { get; set; }

    //Methods 
    public void to_run()
    {
        //Return "is running";
        Console.WriteLine("is running");
    }

    //Structure definitions 
    public abstract string sound();
}