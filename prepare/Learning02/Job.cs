using System;
using System.Security.Cryptography.X509Certificates;

public class Job{
    public string _company;
    public string _title;
    public int _start;
    public int _end;

    public void Display()
    {
        Console.WriteLine($"{_company} ({_title}) {_start}-{_end}");
    }
}

