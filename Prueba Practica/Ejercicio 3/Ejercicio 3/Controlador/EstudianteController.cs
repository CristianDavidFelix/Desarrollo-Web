public class EstudianteController
{
    private EstudianteModel modelo;
    private EstudianteView vista;

    public EstudianteController(EstudianteModel modelo, EstudianteView vista)
    {
        this.modelo = modelo;
        this.vista = vista;
    }

    public void InicializarEstudiante(string nombre, int edad, double calificacion)
    {
        // Inicializa las propiedades del modelo con valores proporcionados
        modelo.Nombre = nombre;
        modelo.Edad = edad;
        modelo.Calificacion = calificacion;

        // Utiliza la vista para mostrar la información del estudiante
        vista.MostrarInformacionEstudiante(modelo);
    }
}

