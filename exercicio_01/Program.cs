int n1 = 0, max = 0, aux = 0, contador = 0;

Console.WriteLine("Digite um número qualquer:");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um número de vezes que quer incrementar:");
max = int.Parse(Console.ReadLine());

aux = n1;

Console.WriteLine("---\nDoWhile:\n---");
do
{
    Console.WriteLine(aux);
    aux++;
    contador++;
}while(contador <= max);

Console.WriteLine("---\nWhile:\n---");
contador = 0;
aux = n1;
while(contador <= max)
{
    Console.WriteLine(aux);
    aux++;
    contador++;
}

Console.WriteLine("---\nfor:\n---");
aux = n1;
for (contador = 0; contador <= max; contador++)
{
    Console.WriteLine(aux);
    aux++;
}