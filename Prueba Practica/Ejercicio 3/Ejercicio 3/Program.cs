class Program
{
    static void Main()
    {
        // Crea instancias del modelo, la vista y el controlador
        EstudianteModel modelo = new EstudianteModel();
        EstudianteView vista = new EstudianteView();
        EstudianteController controlador = new EstudianteController(modelo, vista);

        // Inicializa el estudiante a través del controlador
        controlador.InicializarEstudiante("Cristian Felix", 22, 8.5);
    }
}

