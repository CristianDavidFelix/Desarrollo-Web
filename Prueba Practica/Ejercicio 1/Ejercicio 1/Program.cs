class Program
{
    static void Main()
    {
        // Crea instancias del modelo, la vista y el controlador
        CalculadoraModel modelo = new CalculadoraModel();
        CalculadoraView vista = new CalculadoraView();
        CalculadoraController controlador = new CalculadoraController(modelo, vista);

        // Ingresa valores
        int numero1 = 5;
        int numero2 = 10;

        // Realiza el cálculo a través del controlador
        controlador.RealizarCalculo(numero1, numero2);
    }
}
