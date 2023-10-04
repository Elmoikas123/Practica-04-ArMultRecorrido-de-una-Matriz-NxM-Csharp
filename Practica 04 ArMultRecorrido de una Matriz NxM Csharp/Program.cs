using System;

class Program
{
    const int maxf = 3;
    const int maxc = 5;

    static void Main(string[] args)
    {
        float[,] a = new float[maxf, maxc];

        // Leer valores en el array
        for (int f = 0; f < maxf; f++)
        {
            for (int c = 0; c < maxc; c++)
            {
                Console.Write($"Ingresa el valor para la fila {f + 1}, columna {c + 1}: ");
                if (float.TryParse(Console.ReadLine(), out float valor))
                {
                    a[f, c] = valor;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingresa un valor flotante válido.");
                    // Decrementar los contadores del bucle para volver a intentar la entrada actual
                    f--;
                    c--;
                }
            }
        }

        // Mostrar el array
        Console.WriteLine("Array:");
        for (int f = 0; f < maxf; f++)
        {
            for (int c = 0; c < maxc; c++)
            {
                Console.Write(a[f, c] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Array:");
        for (int f = 0; f < maxf; f++)
        {
            for (int c = 0; c < maxc; c++)
            {
                Console.Write(a[f, c] + " ");
            }
            Console.WriteLine();
        }

        // Agregar una pausa antes de salir
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }

}

