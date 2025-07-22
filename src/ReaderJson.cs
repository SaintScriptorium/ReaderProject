using System.Collections;
using System.Text.Json;

namespace ReaderJsonProject;

public class ReaderJson : IReader
{
    
    public void ReadData(string ruta)
    {
        string contenido = File.ReadAllText(ruta);

         var user = JsonSerializer.Deserialize<User>(contenido);

        Console.WriteLine($"Nombre: {user.Nombre},\nMatricula: {user.Matricula},\nCarrera: {user.Carrera}");
    }
}