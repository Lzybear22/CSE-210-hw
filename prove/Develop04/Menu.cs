using System;

class Menu
{
    private string[] menuItems = {
        "Breathing Activity",
        "Reflection Activity",
        "Listing Activity",
        "Quit",
    };

    public bool ChooseAndRun()
    {
        Console.WriteLine("\nMenu Options:");
        for (int i = 0; i < menuItems.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {menuItems[i]}");
        }
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        switch (choice)
        {
            case 1:
                Breathing breathing = new Breathing();
                breathing.Run();
                break;
            case 2:
                Reflection reflecting = new Reflection();
                reflecting.Run();
                break;
            case 3:
                Listing listing = new Listing();
                listing.Run();
                break;
            case 4:
                Console.WriteLine("Goodbye!");
                return false;
            default:
                Console.WriteLine("Invalid option please try again.");
                break;
        }
        return true;
    }
}
