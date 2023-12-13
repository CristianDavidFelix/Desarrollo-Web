public class CalculadoraController
{
    private CalculadoraModel modelo;
    private CalculadoraView vista;

    public CalculadoraController(CalculadoraModel modelo, CalculadoraView vista)
    {
        this.modelo = modelo;
        this.vista = vista;
    }

    public void RealizarCalculo(int numero1, int numero2)
    {
        // Calcula la suma utilizando el modelo
        int resultado = modelo.Sumar(numero1, numero2);

        // Muestra el resultado utilizando la vista
        vista.MostrarResultado(resultado);
    }
}

