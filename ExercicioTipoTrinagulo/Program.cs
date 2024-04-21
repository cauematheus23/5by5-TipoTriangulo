float l1, l2, l3;
do
{
    Console.Write("Digite um valor para o primeiro lado: ");
    l1 = float.Parse(Console.ReadLine());
} while (l1 <= 0);
do
{
    Console.Write("Digite um valor para o segundo lado: ");
    l2 = float.Parse(Console.ReadLine());
} while (l2 <= 0);

do
{
    Console.Write("Digite um valor para o terceiro lado: ");
    l3 = float.Parse(Console.ReadLine());
} while (l3 <= 0);

//Verificando se o triangulo existe
if (l1 < (l2 + l3) && l2 < (l1 + l3) && l3 < (l1 + l2))
{
    if (l1 == l2 && l1 == l3)
    {
        Console.WriteLine("O triangulo é Equilatero");
    }else if ((l1 == l2 && l1 != l3) || l2 == l3 && l2 != l1){
        Console.WriteLine("O Triangulo é Isoceles");
    } else if (l1 != l2 && l1 != l3 && l2 != l3 && l3 != l1)
    {
        Console.WriteLine("O triangulo é Escaleno");
    }
}else
{
    Console.WriteLine("O valores fornecidos não obdecem a regra dos triangulo por tanto não podem formar triangulos");
}