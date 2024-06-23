using System;
using System.Collections.Generic;

public class House
{
    public string Name { get; private set; }
    private List<Room> rooms;

    public House(string name)
    {
        Name = name;
        rooms = new List<Room>();
    }

    public void AddRoom(Room room)
    {
        rooms.Add(room);
    }

    public void DisplayHouseStatus()
    {
        Console.WriteLine($"House: {Name}");
        foreach (var room in rooms)
        {
            room.DisplayDevices();
        }
    }
}
