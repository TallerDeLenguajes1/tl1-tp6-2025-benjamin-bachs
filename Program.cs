// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b); 

 Console.WriteLine("=== PROGRAMA PARA INVERTIR NÚMEROS ===\n");

while (true)
{
    Console.Write("Ingrese un número mayor a 0 o 0 para salir: ");
    string entrada = Console.ReadLine();

    if (int.TryParse(entrada, out int numero))
    {
        if (numero == 0)
        {
            break;
        }
        else if (numero > 0)
        {
            int numeroInvertido = InvertirNumero(numero);
            Console.WriteLine($"Número original: {numero}");
            Console.WriteLine($"Número invertido: {numeroInvertido}");
        }
        else
        {
            Console.WriteLine("Error: El número debe ser mayor a 0.");
        }
    }
    else
    {
        Console.WriteLine("Error: El texto ingresado no es un número.");
    }

    Console.WriteLine();
}

static int InvertirNumero(int numero)
{
    int numeroInvertido = 0;

    while (numero > 0)
    {
        int ultimoDigito = numero % 10;
        numeroInvertido = numeroInvertido*10 + ultimoDigito;
        numero /= 10;
    }

    return numeroInvertido;
}