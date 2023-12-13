public class EstudianteModel
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Calificacion { get; set; }

    // Método para mostrar la información del estudiante
    public void MostrarInformacion()
    {
        Console.WriteLine("Información del Estudiante:");
        Console.WriteLine("Nombre: {0}", Nombre);
        Console.WriteLine("Edad: {0} años", Edad);
        Console.WriteLine("Calificación: {0}", Calificacion);
    }
}
