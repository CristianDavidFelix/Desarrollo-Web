public class EstudianteModel
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Calificacion { get; set; }
}

// Clase derivada EstudianteGraduado que hereda de Estudiante
public class EstudianteGraduadoModel : EstudianteModel
{
    public string Titulo { get; set; }
}


