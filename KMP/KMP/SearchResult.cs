using System.Collections.ObjectModel;

namespace Lista_1.KMP;

public class SearchResult
{
    private readonly List<int> _indexes = [];
    
    public void Add(int index) {
        _indexes.Add(index);
    }
    
    public ReadOnlyCollection<int> GetIndexes() {
        return _indexes.AsReadOnly();
    }
    
    public void PrintResult()
    {
        if (_indexes.Count == 0)
        {
            Console.WriteLine("Pattern Not Found");
            return;
        }
        
        Console.WriteLine("Pattern found at index " + string.Join(", ", _indexes));
    }
}