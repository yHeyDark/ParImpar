double numero;

Console.WriteLine("Digite o numero: ");
numero = Convert.ToDouble(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("Numero e par");
}

else
{
    Console.WriteLine("Numero e impar");
}