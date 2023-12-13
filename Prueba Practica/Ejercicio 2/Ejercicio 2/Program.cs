class Program
{
    static void Main()
    {
        // Crea instancias del modelo, la vista y el controlador
        VerificadorEdadModel modelo = new VerificadorEdadModel();
        VerificadorEdadView vista = new VerificadorEdadView();
        VerificadorEdadController controlador = new VerificadorEdadController(modelo, vista);

        // En este aparatado se ingresa la edad 
        int edad = 22; 

        // Verifica la edad a través del controlador
        controlador.VerificarEdad(edad);
    }
}
