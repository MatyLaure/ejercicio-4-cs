using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese las dimensiones del rectángulo (ancho, alto, relleno):");
        string input = Console.ReadLine();
        string[] dimensions = input.Split(',');

        if (dimensions.Length != 3)
        {
            Console.WriteLine("Entrada inválida. Debe ingresar tres valores separados por coma.");
            return;
        }

        int width, height, fillType;
        if (!int.TryParse(dimensions[0].Trim(), out width) ||
            !int.TryParse(dimensions[1].Trim(), out height) ||
            !int.TryParse(dimensions[2].Trim(), out fillType))
        {
            Console.WriteLine("Entrada inválida. Los valores deben ser números enteros.");
            return;
        }

        if (width == height)
        {
            DrawSquare(width, fillType == 1);
        }
        else
        {
            DrawRectangle(width, height, fillType == 1);
        }

        Console.WriteLine("Ingrese el número de cuadrados o rectángulos a dibujar:");
        string countInput = Console.ReadLine();
        int count;

        if (!int.TryParse(countInput, out count))
        {
            Console.WriteLine("Entrada inválida. Debe ingresar un número entero.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Cuadrado o rectángulo " + (i + 1) + ":");

            if (width == height)
            {
                DrawSquare(width, fillType == 1);
            }
            else
            {
                DrawRectangle(width, height, fillType == 1);
            }
        }
    }

    static void DrawSquare(int sideLength, bool filled)
    {
        for (int i = 0; i < sideLength; i++)
        {
            for (int j = 0; j < sideLength; j++)
            {
                if (filled || i == 0 || i == sideLength - 1 || j == 0 || j == sideLength - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    static void DrawRectangle(int width, int height, bool filled)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (filled || i == 0 || i == height - 1 || j == 0 || j == width - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

