using System;

class Program
{
    static void Main(string[] args)
    {
        House myHouse = new House("My Smart Home");

        Room livingRoom = new Room("Living Room");
        Room bedroom = new Room("Bedroom");

        SmartHeater livingRoomHeater = new SmartHeater("Living Room Heater", livingRoom, 22);
        SmartLight livingRoomLight = new SmartLight("Living Room Light", livingRoom, false);

        SmartHeater bedroomHeater = new SmartHeater("Bedroom Heater", bedroom, 20);
        SmartLight bedroomLight = new SmartLight("Bedroom Light", bedroom, true);

        livingRoom.AddDevice(livingRoomHeater);
        livingRoom.AddDevice(livingRoomLight);

        bedroom.AddDevice(bedroomHeater);
        bedroom.AddDevice(bedroomLight);

        myHouse.AddRoom(livingRoom);
        myHouse.AddRoom(bedroom);

        myHouse.DisplayHouseStatus();

        livingRoom.TurnOnAllDevices();
        bedroom.TurnOffDevice("Bedroom Light");
        livingRoom.ReportAllItemsInRoom();
        bedroom.ReportAllItemsThatAreOn();
        livingRoom.ReportItemThatHasBeenOnTheLongest();

        Console.WriteLine("\nAfter modifying some devices:\n");
        myHouse.DisplayHouseStatus();
    }
}
