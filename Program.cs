//By Silktz 
Console.WriteLine("TABUADA DE MULTIPLICAÇÃO");

int resultado;
int multiplicador = 0;

Console.WriteLine("Digite um número inteiro para mostragem de tabuada...");
int numero = Convert.ToInt32(Console.ReadLine());

while (multiplicador <= 10)
{
resultado = numero*multiplicador;
    Console.WriteLine($"{numero} x {multiplicador} = {resultado} ");
    multiplicador += 1;
}



