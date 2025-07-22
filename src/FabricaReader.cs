namespace ReaderJsonProject;

public class FabricaReader
{
    public static IReader Creador(int option)
    {
        switch (option)
        {
            case 1: return new ReaderJson(); break;
            case 2: return new ReaderAdapter(); break;
            default: return null; break;
        }
    }
}