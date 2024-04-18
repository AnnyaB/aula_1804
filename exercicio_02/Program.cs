// Escreva um programa que leia um número inicial e um final e imprima quais números entre eles
// são pares e impares;

int num1 = 0;
int num2 = 0;

Console.WriteLine("Digite um valor inicial:");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um valor final:");
num2 = int.Parse(Console.ReadLine());
for (int i = num1+1; i < num2; i ++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + " - Esse numero é par");
    }
    else
    {
        Console.WriteLine(i + " - Esse numero é impar");
    }
}