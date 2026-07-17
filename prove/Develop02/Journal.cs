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

    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName)) // learned about this from a stack overflow post from almost 18 years ago: https://stackoverflow.com/questions/38960/how-to-find-out-if-a-file-exists-in-c-sharp-net
        {
            _entries.Clear();

            string[] lines = System.IO.File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] entryData = line.Split("|");

                    Entry entry = new Entry(); 

                    entry._date = entryData[0];
                    entry._prompt = entryData[1];
                    entry._entry = entryData[2];

                    _entries.Add(entry);
                }

            Console.WriteLine("Journal loaded successfully!");
        }

        else
        {
            Console.WriteLine("Error: That file does not exist.");
        }
    }
    public void SaveToFile(string fileName)
        {
            {
                using (StreamWriter outputFile = new StreamWriter(fileName))

                    foreach (Entry entry in _entries)
                    {
                        outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
                    }
                
                Console.WriteLine("Journal saved successfully!");
            }
        }
}