using System;

public class SmartLight : SmartDevice
{
    public SmartLight(string name, Room room, bool isOn) : base(name, room)
    {
        if (isOn)
        {
            TurnOn();
        }
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"  Device: {Name}, Type: Light, Status: {(IsOn ? "On" : "Off")}");
    }
}
