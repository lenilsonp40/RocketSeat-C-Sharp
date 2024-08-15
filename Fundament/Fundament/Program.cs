//Parei aula F76

using System.Globalization;

namespace Fundament;

class Program
{
    static void Main()
    {
        DateOnly dia = new DateOnly(2023, 12, 2);

        string diaEmTexto = dia.ToString("dd/MMMM/yyyy", new CultureInfo("pt-BR"));

        DateTime hoje = DateTime.UtcNow;


        Console.WriteLine(hoje);



        for (int i = 3; i > 2; i++)
        {
            Console.WriteLine(i);
        }

    }
}
