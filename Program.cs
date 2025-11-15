class Program
{
    static void Main(string[] args)
    {
        int cantidadNotas = 0;
        double suma = 0;

        while (true)
        {
            try
            {
                Console.Write("Ingrese la cantidad de notas: ");
                cantidadNotas = int.Parse(Console.ReadLine() ?? "0");

                if (cantidadNotas <= 0)
                {
                    Console.WriteLine("La cantidad debe ser mayor que cero");
                    continue;
                }

                break; 
            }
            catch
            {
                Console.WriteLine("Error ingrese un número entero valido");
            }
        }


        for (int i = 1; i <= cantidadNotas; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write("Ingrese la nota: ");
                    double nota = double.Parse(Console.ReadLine() ?? "0");

                    if (nota < 0 || nota > 100)
                    {
                        Console.WriteLine("La nota debe estar entre 0 y 100");
                        continue;
                    }

                    suma += nota;
                    break; 
                }
                catch
                {
                    Console.WriteLine("Error ingrese un numero válido.");
                }
            }
        }

    
        double promedio = suma / cantidadNotas;

        Console.WriteLine($"Promedio final: {promedio:F2}");
    }
}
