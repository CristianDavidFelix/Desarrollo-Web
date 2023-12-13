using System;

public class VerificadorEdadView
{
    public void MostrarMensaje(bool esMayorDeEdad)
    {
        if (esMayorDeEdad)
        {
            Console.WriteLine("La persona es mayor de edad.");
        }
        else
        {
            Console.WriteLine("La persona NO es mayor de edad.");
        }
    }
}
