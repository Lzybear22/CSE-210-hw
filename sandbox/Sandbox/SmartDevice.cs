using System;

public abstract class SmartDevice
{
    public string Name { get; private set; }
    public Room Room { get; private set; }
    public bool IsOn { get; private set; }
    public DateTime? OnSince { get; private set; }

    public SmartDevice(string name, Room room)
    {
        Name = name;
        Room = room;
        IsOn = false;
    }

    public void TurnOn()
    {
        if (!IsOn)
        {
            IsOn = true;
            OnSince = DateTime.Now;
        }
    }

    public void TurnOff()
    {
        if (IsOn)
        {
            IsOn = false;
            OnSince = null;
        }
    }

    public abstract void DisplayStatus();
}
