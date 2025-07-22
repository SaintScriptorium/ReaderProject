using System.Text;
namespace ReaderJsonProject;

public class ReaderCSV
{
    public string GetCSV(string ruta)
    {
        var path = ruta;

        return File.ReadAllText(path);
    }
    
}