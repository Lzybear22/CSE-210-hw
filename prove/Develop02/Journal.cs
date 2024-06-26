using System;
using System.Collections.Generic;
using System.IO;
 
class Journal
{
    private List<Entry> entries = new List<Entry>();
 
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
 
    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.UserEntry}");
            Console.WriteLine();
        }
    }
 
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.UserEntry}");
            }
        }
    }
 
    public void LoadFromFile(string filename)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                DateTime date = DateTime.Parse(parts[0]);
                string prompt = parts[1];
                string userEntry = parts[2];
                entries.Add(new Entry(userEntry, prompt, date));
            }
        }
    }
}