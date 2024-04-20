double cateto1 = 0, cateto2 = 0, hipotenusa = 0;

do
{
    Console.WriteLine("Digite o primeiro cateto: ");
    cateto1 = float.Parse(Console.ReadLine());
} while (cateto1 <= 0);

do
{
    Console.WriteLine("Digite o segundo cateto: ");
    cateto2 = float.Parse(Console.ReadLine());
} while (cateto2 <= 0);


if((cateto1 * cateto1) + (cateto2 * cateto2) <= 0)
{
    Console.WriteLine("Valores invalidos nos catetos");
}
else
{
    hipotenusa = Math.Sqrt((cateto1 * cateto1) + (cateto2 * cateto2));
    Console.WriteLine($"A hipotenusa é {hipotenusa}");


}
