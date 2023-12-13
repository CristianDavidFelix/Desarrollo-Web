using System;

public class EstudianteView
{
    public void MostrarInformacionEstudianteGraduado(EstudianteGraduadoModel graduado)
    {
        Console.WriteLine("Información del Estudiante Graduado:");
        Console.WriteLine("Nombre: {0}", graduado.Nombre);
        Console.WriteLine("Edad: {0} años", graduado.Edad);
        Console.WriteLine("Calificación: {0}", graduado.Calificacion);
        Console.WriteLine("Título obtenido: {0}", graduado.Titulo);
    }
}


