class Program
{
    static void Main()
    {
        // Crea instancias del modelo, la vista y el controlador para EstudianteGraduado
        EstudianteGraduadoModel modeloGraduado = new EstudianteGraduadoModel();
        EstudianteView vistaGraduado = new EstudianteView();
        EstudianteGraduadoController controladorGraduado = new EstudianteGraduadoController(modeloGraduado, vistaGraduado);

        // Inicializa el estudiante graduado a través del controlador de EstudianteGraduado
        controladorGraduado.InicializarEstudianteGraduado("Cristian Felix", 25, 9.2, "Ingenieria en software");
    }
}

