using System; 
using System.IO; 


public class Journal
{
    public List<Entry> _entries = new List<Entry>{};

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display(); 
        }
    }

    string fileName = "JournalEntries.txt";
    public void SaveToFile()
    {
        using (StreamWriter outputFile = new StreamWriter(fileName));

            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
            }
    }
}