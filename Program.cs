// Faça um programa que permita converter os números de 1 a 3999 em romanos.

while (true)
{

    string[] units = { "", "I", "II", "III", "IV", "IV", "VI", "VII", "VIII", "IX" };
    string[] dec = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
    string[] cent = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
    string[] milh = { "", "M", "MM", "MMM" };

    var value = Console.ReadLine();

    if (string.IsNullOrEmpty(value))
    {
        return;
    }

    var numero = int.Parse(value);

    if (numero <= 0 || numero >= 3999)
    {
        Console.WriteLine("Número ");
        return;
    }

    int milhar = numero / 1000;
    int resto = numero % 1000;

    int centena = resto / 100;
    resto = resto % 100;

    int dezena = resto / 10;
    resto = resto % 10;

    int unidade = resto;

    Console.WriteLine(milh.ElementAtOrDefault(milhar) + cent.ElementAtOrDefault(centena) +
    dec.ElementAtOrDefault(dezena) + units.ElementAtOrDefault(unidade));
}