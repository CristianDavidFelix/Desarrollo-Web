using System;

public class EstudianteView
{
    public void MostrarInformacionEstudiante(EstudianteModel estudiante)
    {
        Console.WriteLine("Información del Estudiante:");
        Console.WriteLine("Nombre: {0}", estudiante.Nombre);
        Console.WriteLine("Edad: {0} años", estudiante.Edad);
        Console.WriteLine("Calificación: {0}", estudiante.Calificacion);
    }
}
