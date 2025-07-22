namespace ReaderJsonProject;

public class ReaderStrategy
{
    private IReader reader;

    public ReaderStrategy(IReader reader)
    {
        this.reader = reader;
    }

    public void ReadData(string ruta)
    {
        reader.ReadData(ruta);
    }
}