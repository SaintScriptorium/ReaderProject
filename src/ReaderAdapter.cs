namespace ReaderJsonProject;

public class ReaderAdapter : IReader
{
    
    
    public void ReadData(string ruta)
    {
        var reader = new ReaderCSV();
        
        Console.WriteLine(reader.GetCSV(ruta));
    }
}