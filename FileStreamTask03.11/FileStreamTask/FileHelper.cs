using Newtonsoft.Json;

namespace FileStreamTask;

public class FileHelper
{
    public List<string> names = new List<string>();
    public string path = Path.Combine("/Users","elmin","RiderProjects","FileStreamTask","FileStreamTask","names.json");
    
    public void Add(string newName)
    {
        names.Add(newName);
        string newNames = JsonConvert.SerializeObject(names);
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine(newNames);
        }
    }

    public bool Exist(string searchName)
    {
        StreamReader sr = new StreamReader(path);
        string name=  sr.ReadToEnd();
        var deserOb = JsonConvert.DeserializeObject<List<string>>(name);
        return deserOb.Contains(searchName);
    }

    public void Update(int index, string newName)
    {
        if (0 <= index && index < names.Count)
        {
            names[index] = newName;
            string newNames = JsonConvert.SerializeObject(names);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(newNames);
            }
        }
    }

    public void Delete(int index)
    {
        if (0 <= index && index < names.Count)
        {
            names.RemoveAt(index);
            string newNames = JsonConvert.SerializeObject(names);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(newNames);
            }
        }
    }
}
