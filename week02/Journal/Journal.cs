

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    
    public void SaveToFile(string file)
    {
        using (StreamWriter entryfile = new StreamWriter(file, append: true))
        {
            foreach (Entry entry in _entries)
            {
                entryfile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] entryLines = System.IO.File.ReadAllLines(file);
        foreach (string entryline in entryLines)
        {
            string[] parts = entryline.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
            

        }
    }

}