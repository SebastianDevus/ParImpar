int numero;

// Espacamento
Console.WriteLine();

// Solicitando e armazenando número
Console.Write("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());

// Testando se o número é par
if (numero % 2 == 0)
{ 
    // Mensagem caso seja par
    Console.WriteLine($"O número {numero} é par!");
}
else
{
    // Mensagem caso seja ímpar
    Console.WriteLine($"O número {numero} é ímpar!");
}

// Espacamento
Console.WriteLine();