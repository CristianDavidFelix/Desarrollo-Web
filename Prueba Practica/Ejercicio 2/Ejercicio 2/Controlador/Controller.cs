public class VerificadorEdadController
{
    private VerificadorEdadModel modelo;
    private VerificadorEdadView vista;

    public VerificadorEdadController(VerificadorEdadModel modelo, VerificadorEdadView vista)
    {
        this.modelo = modelo;
        this.vista = vista;
    }

    public void VerificarEdad(int edad)
    {
        // Utiliza el modelo para determinar si la persona es mayor de edad
        bool esMayorDeEdad = modelo.EsMayorDeEdad(edad);

        // Utiliza la vista para mostrar el mensaje en la consola
        vista.MostrarMensaje(esMayorDeEdad);
    }
}
