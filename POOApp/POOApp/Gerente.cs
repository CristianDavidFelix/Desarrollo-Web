using System;

// Definición de la clase Gerente que hereda de Empleado e implementa IMostrarInformacion
public class Gerente : Empleado, IMostrarInformacion
{
    // Nuevo atributo para el departamento supervisado
    public string Departamento { get; set; }

    // Constructor que inicializa instancias de Gerente y llama al constructor de la clase base (Empleado)
    public Gerente(string nombre, double salario, string departamento)
        : base(nombre, salario)
    {
        Departamento = departamento;
    }

    // Método MostrarInformacion que sobrescribe el de la clase base
    public new void MostrarInformacion()
    {
        // Llama al método MostrarInformacion de la clase base (Empleado)
        base.MostrarInformacion();

        // Agrega información específica de Gerente
        Console.WriteLine($"Departamento: {Departamento}");
    }
}

