using System;
using System.Collections.Generic;
using System.Linq;

public class Room
{
    public string Name { get; private set; }
    private List<SmartDevice> devices;

    public Room(string name)
    {
        Name = name;
        devices = new List<SmartDevice>();
    }

    public void AddDevice(SmartDevice device)
    {
        devices.Add(device);
    }

    public void TurnOnLights()
    {
        foreach (var device in devices.OfType<SmartLight>())
        {
            device.TurnOn();
        }
    }

    public void TurnOffLights()
    {
        foreach (var device in devices.OfType<SmartLight>())
        {
            device.TurnOff();
        }
    }

    public void TurnOnDevice(string deviceName)
    {
        var device = devices.FirstOrDefault(d => d.Name == deviceName);
        if (device != null)
        {
            device.TurnOn();
        }
    }

    public void TurnOffDevice(string deviceName)
    {
        var device = devices.FirstOrDefault(d => d.Name == deviceName);
        if (device != null)
        {
            device.TurnOff();
        }
    }

    public void TurnOnAllDevices()
    {
        foreach (var device in devices)
        {
            device.TurnOn();
        }
    }

    public void TurnOffAllDevices()
    {
        foreach (var device in devices)
        {
            device.TurnOff();
        }
    }

    public void ReportAllItemsInRoom()
    {
        Console.WriteLine($"Room: {Name}");
        foreach (var device in devices)
        {
            device.DisplayStatus();
        }
    }

    public void ReportAllItemsThatAreOn()
    {
        Console.WriteLine($"Room: {Name} - Devices that are on:");
        foreach (var device in devices.Where(d => d.IsOn))
        {
            device.DisplayStatus();
        }
    }

    public void ReportItemThatHasBeenOnTheLongest()
    {
        var longestOnDevice = devices.Where(d => d.IsOn).OrderBy(d => d.OnSince).FirstOrDefault();
        if (longestOnDevice != null)
        {
            Console.WriteLine($"Room: {Name} - Device that has been on the longest:");
            longestOnDevice.DisplayStatus();
        }
        else
        {
            Console.WriteLine($"Room: {Name} - No devices are currently on.");
        }
    }

    public void DisplayDevices()
    {
        Console.WriteLine($"Room: {Name}");
        foreach (var device in devices)
        {
            device.DisplayStatus();
        }
    }
}
