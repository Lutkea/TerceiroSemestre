using System;


namespace ExercicioUm

{
    class CalculaMedia
    {
        static public String Media(){

        double media = 0;

        Console.WriteLine("Programa Média de Três Números");
        Console.WriteLine("Digite o primeiro número");
        media += Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo número");
        media += Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o terceiro número");
        media += Convert.ToDouble(Console.ReadLine());

        media /= 3;

        return ("A média dos três números é " + media);

    }
}
    
    class CalculaArea
    {
        static public String Area(){

        double resultado = 0;

        Console.WriteLine("Programa de Calculo de Área");
        Console.WriteLine("Digite o primeiro número");
        resultado += Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo número");
        resultado += Convert.ToDouble(Console.ReadLine());

        resultado /= 2;

        return ("A area é " + resultado);

        }
    }

    class CalculaVolume
    {
    static public String Volume(){
    
        double volume = 0;

        Console.WriteLine("Programa de Calculo de Volume");
        Console.WriteLine("Digite a largura");
        volume *= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a profundidade");
        volume *= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a altura");
        volume *= Convert.ToDouble(Console.ReadLine());

        volume = 3;

        return ("O volume é " + volume);

    }
}

    class MaiorOuMenorQueODobro
    {
        static public String MaiorOuMenorQueDobro(){
        
        int valor1 = 5;
        int valor2 = 35;

        String resultado = (valor1 > ( valor2 * 2)) ? "É maior" : "Não é maior";
        return("O número é maior que o outro valor? ------------->" + resultado);

        
    }
}
    class Bhaskara
    {  
    static public String calcularbhaskara(){
      int a = 10;
      int b = 2;
      int c = 5;

       int deltaValue = ((b * b) + (4 * a * c));

       double x = (-b + Math.Sqrt(deltaValue)) / (2 * a);
       double xLine = (-b - Math.Sqrt(deltaValue)) / (2 * a);

       return ("O valor do delta é: " + deltaValue);
       return ("O valor de x é: " + x);
       return ("O valor de x linha é:" + xLine);
        
    }
        
}
    class KmPorHora
    {   
        static public String kmPorHr(){

        int km = 500;
        int hora = 3;
        int resultado;
        
        resultado = km / hora;

        return ("Você está andando à " + resultado + "km por hora");


        }
    }

    class fatura
    {   
        static public String FaturaporImposto(){
            
        double fatura = 600;
        double imposto = 7.5;
        double resultado;

        resultado = fatura / imposto;

        return("o valor da sua fatura é " + resultado);

    }
}
}

