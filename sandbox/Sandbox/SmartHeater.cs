using System;

public class SmartHeater : SmartDevice
{
    public int Temperature { get; private set; }

    public SmartHeater(string name, Room room, int temperature) : base(name, room)
    {
        Temperature = temperature;
    }

    public void SetTemperature(int temperature)
    {
        Temperature = temperature;
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"  Device: {Name}, Type: Heater, Temperature: {Temperature}°C, Status: {(IsOn ? "On" : "Off")}");
    }
}
