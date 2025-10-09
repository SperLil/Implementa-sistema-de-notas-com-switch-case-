using System;

namespace GradeClassifier;
    class Program
{
    public static void Main()
    {
      
        Console.WriteLine("==Desempenho Escolar==");
        Console.WriteLine("Digite sua nota: ");
        int score = Convert.ToInt32(Console.ReadLine());

        switch (score)
        {
            case 10:
            case 9:
                Console.WriteLine("ótimo");
                break;
            case 8:
            case 7:
                Console.WriteLine("Bom");
                break;
            case 6:
                Console.WriteLine("Regular");
                break;
            case 5:
                Console.WriteLine("Estude mais");
                break;
                 
            default:
                Console.WriteLine("Péssimo");
                break;
        }
    }
}
