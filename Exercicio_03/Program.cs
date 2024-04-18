// Escreva um programa que leia um número inteiro positivo e imprima a tabuada dele;
int num = 0;
Console.WriteLine("Digite um número positivo:");
num = int.Parse(Console.ReadLine());
int res = 0;

if (num > 0)
{
    for (int i = 1; i <= 10; i++)
    {
        res = num * i;
        Console.WriteLine(num + "x" + i + "=" + res);
    }
}
else
{
    Console.WriteLine("Digite um número POSITIVO na próxima");
}