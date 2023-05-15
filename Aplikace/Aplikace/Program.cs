using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Vítejte v kalkulačce!");

        while (true)
        {
            Console.WriteLine("Zadejte první číslo:");
            double cislo1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Zadejte operátor (+, -, *, /):");
            char operatorSymbol = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Zadejte druhé číslo:");
            double cislo2 = Convert.ToDouble(Console.ReadLine());

            double vysledek = 0;

            switch (operatorSymbol)
            {
                case '+':
                    vysledek = cislo1 + cislo2;
                    break;
                case '-':
                    vysledek = cislo1 - cislo2;
                    break;
                case '*':
                    vysledek = cislo1 * cislo2;
                    break;
                case '/':
                    if (cislo2 != 0)
                    {
                        vysledek = cislo1 / cislo2;
                    }
                    else
                    {
                        Console.WriteLine("Chyba: Nelze dělit nulou!");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Chyba: Neplatný operátor!");
                    continue;
            }

            Console.WriteLine("Výsledek: " + vysledek);

            Console.WriteLine("Chcete pokračovat? (ano/ne)");
            string odpoved = Console.ReadLine();

            if (odpoved.ToLower() != "ano")
            {
                break;
            }
        }
        Console.WriteLine("Děkujeme, že jste použili kalkulačku!");
    }
}
