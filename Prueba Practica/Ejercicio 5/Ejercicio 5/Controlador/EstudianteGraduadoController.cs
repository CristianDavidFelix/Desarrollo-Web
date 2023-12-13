public class EstudianteGraduadoController
{
    private EstudianteGraduadoModel modeloGraduado;
    private EstudianteView vistaGraduado;

    public EstudianteGraduadoController(EstudianteGraduadoModel modelo, EstudianteView vista)
    {
        this.modeloGraduado = modelo;
        this.vistaGraduado = vista;
    }

    public void InicializarEstudianteGraduado(string nombre, int edad, double calificacion, string titulo)
    {
        // Inicializa las propiedades del modelo graduado
        modeloGraduado.Nombre = nombre;
        modeloGraduado.Edad = edad;
        modeloGraduado.Calificacion = calificacion;
        modeloGraduado.Titulo = titulo;

        // Utiliza la vista graduada para mostrar la información del estudiante graduado
        vistaGraduado.MostrarInformacionEstudianteGraduado(modeloGraduado);
    }
}
