using System;

// Definición de la clase Empleado que implementa la interfaz
public class Empleado : IMostrarInformacion
{
    // Propiedades autoimplementadas para Nombre y Salario
    public string Nombre { get; set; }
    public double Salario { get; set; }

    // Constructor para inicializar instancias de Empleado
    public Empleado(string nombre, double salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    // Método para calcular el salario anual
    public double CalcularSalarioAnual()
    {
        return Salario * 12;
    }

    // Implementación del método de la interfaz IMostrarInformacion
    public void MostrarInformacion()
    {
        Console.WriteLine($"Empleado: {Nombre}");
        Console.WriteLine($"Salario Mensual: {Salario:C}");
        Console.WriteLine($"Salario Anual: {CalcularSalarioAnual():C}");
    }
}

