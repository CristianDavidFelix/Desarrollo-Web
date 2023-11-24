# Aplicación de Gestión de Empleados

Esta aplicación está desarrollada en C# y utiliza conceptos de Programación Orientada a Objetos (POO) para gestionar empleados, incluyendo cálculos de salarios y la jerarquía de gerentes.

## Instrucciones para Ejecutar

### Requisitos Previos

- [.NET SDK](https://dotnet.microsoft.com/download) instalado en tu máquina.

### Pasos para Ejecutar
1. La explicacion de ejecucion se basa en el sistema operativo windows ya que es el que yo utilizo.
2. Abre tu terminal de comandos.
3. Clona o descarga el repositorio en tu máquina local:

    git clone https://github.com/tu-usuario/Desarrollo-Web.git

4. Navega al directorio del proyecto:

    cd Desarrollo-Web\POOApp

5. Compila la aplicación:

    dotnet build

6. Ejecuta la aplicación:

    dotnet run

### Cómo Probar la Aplicación

1. La aplicación creará instancias de un `Empleado` y un `Gerente`.
2. Mostrará la información de ambos empleados utilizando polimorfismo a través de la interfaz `IMostrarInformacion`.
