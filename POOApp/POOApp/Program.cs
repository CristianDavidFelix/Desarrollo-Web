using System;

class Program
{
    static void Main()
    {
        // Crear instancias de Empleado y Gerente
        Empleado empleado = new Empleado("Bill Gates", 5000);
        Gerente gerente = new Gerente("Cristian Felix", 8000, "Ventas");

        // Mostrar información del Empleado utilizando polimorfismo
        Console.WriteLine("Información del Empleado:");
        MostrarInformacionConPolimorfismo(empleado);

        // Mostrar información del Gerente utilizando polimorfismo
        Console.WriteLine("\nInformación del Gerente:");
        MostrarInformacionConPolimorfismo(gerente);
    }

    // Método que utiliza polimorfismo a través de la interfaz
    static void MostrarInformacionConPolimorfismo(IMostrarInformacion entidad)
    {
        entidad.MostrarInformacion();
    }
}

