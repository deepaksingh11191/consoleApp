using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GenericsExample;

public class JsonLoader<T>() where T : class
{
    public T? LoadData()
    {
        // Simulate loading JSON and returning an instance of T
        Console.WriteLine($"Loading JSON for type: {typeof(T).Name}");
        string fileName = $"JsonData/{typeof(T).Name}.json";
        string jsonData = File.ReadAllText(fileName);
        return JsonSerializer.Deserialize<T>(jsonData);
    }
}
