public class Exercise
{
    public string Name { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }

    public Exercise(string name, int sets, int reps)
    {
        Name = name;
        Sets = sets;
        Reps = reps;
    }

    public void Display()
    {
        Console.WriteLine($"{Name}: {Sets} sets, {Reps} reps");
    }
}
