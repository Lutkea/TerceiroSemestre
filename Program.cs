using System;

namespace ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            
            Console.WriteLine("1 - Calculo de Média de três Números");
            Console.WriteLine("2 - Calculo de Área");
            Console.WriteLine("3 - Calculo de Volume");
            Console.WriteLine("4 - Descubra se o valor é maior que o dobro");
            Console.WriteLine("5 - Calculando Bhaskára");
            Console.WriteLine("6 - Calculando Bhaskára");
            Console.WriteLine("7 - Calculando KM/Hr");
            Console.WriteLine("8 - Calculando Fatura com Imposto");

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:

                Console.WriteLine(ExercicioUm.CalculaMedia.Media());

                break;

                case 2:

                Console.WriteLine(ExercicioUm.CalculaArea.Area());

                break;

                case 3:

                Console.WriteLine(ExercicioUm.CalculaVolume.Volume());

                break;

                case 4:

                Console.WriteLine(ExercicioUm.MaiorOuMenorQueODobro.MaiorOuMenorQueDobro());

                break;

                case 5:

                Console.WriteLine(ExercicioUm.Bhaskara.calcularbhaskara());

                break;

                case 6:

                Console.WriteLine(ExercicioUm.Bhaskara.calcularbhaskara());

                break;

                case 7:

                Console.WriteLine(ExercicioUm.KmPorHora.kmPorHr());

                break;

                case 8:

                Console.WriteLine(ExercicioUm.fatura.FaturaporImposto());

                break;
            }
            
        }
    }
}
