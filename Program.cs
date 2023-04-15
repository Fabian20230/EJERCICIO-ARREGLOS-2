using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la cantidad de alumnos: ");
        int cantidadAlumnos = Convert.ToInt32(Console.ReadLine());

        string[] nombres = new string[cantidadAlumnos];
        int[] notas = new int[cantidadAlumnos];

        for (int i = 0; i < cantidadAlumnos; i++)
        {
            Console.WriteLine("Ingrese el nombre del alumno #" + (i + 1) + ": ");
            nombres[i] = Console.ReadLine();

            Console.WriteLine("Ingrese la nota del alumno #" + (i + 1) + ": ");
            notas[i] = Convert.ToInt32(Console.ReadLine());
        }

        int notaMayor = notas[0];
        int notaMenor = notas[0];

        for (int i = 1; i < cantidadAlumnos; i++)
        {
            if (notas[i] > notaMayor)
            {
                notaMayor = notas[i];
            }

            if (notas[i] < notaMenor)
            {
                notaMenor = notas[i];
            }
        }

        Console.WriteLine("El alumno con la nota más alta es: " + nombres[Array.IndexOf(notas, notaMayor)] + " con una nota de: " + notaMayor);
        Console.WriteLine("El alumno con la nota más baja es: " + nombres[Array.IndexOf(notas, notaMenor)] + " con una nota de: " + notaMenor);
    }
}
