namespace ReaderJsonProject;

public class Screen
{
    private bool on = true;
    
    public void Start()
    {
        do
        {
            Menu();
        } while (on);
    }



    private void Menu()
    {
        Console.Clear();
        Console.WriteLine("-- Bienvenido a su leedor de archivos.\n");
        Console.WriteLine("Que archivo quiere leer hoy?\n[1] Json\t[2] CSV\n");

        int option = int.Parse(Console.ReadLine());

        Console.Write("\nEscriba la ruta de su archivo: ");
        var ruta = Console.ReadLine();

        var fabricador = FabricaReader.Creador(option);

        var reader = new ReaderStrategy(fabricador);
        reader.ReadData(ruta);
        Console.ReadKey();
    }
}