using System.Security.Cryptography.X509Certificates;
using System;

class Program
{
    public static void ArrayReverse(int[] arr)
    {
        int[] arr2 = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {

            arr2[arr.Length - i - 1] = arr[i];
        }
        Console.WriteLine($"El nuevo array es: " + string.Join(", ", arr2));
    }
    public static void FindNumPrimo(int numPrimo)
    {
        if (numPrimo <= 1)
        {
            Console.WriteLine($"El numero {numPrimo} no es primo");
        }

        bool esNumPrimo = true;
        for (int i = 2; i <= Math.Sqrt(numPrimo); i++)
        {
            if (numPrimo % i == 0)
            {
                esNumPrimo = false;
                break;
            }
        }
        if (esNumPrimo)
        {
            Console.WriteLine($"El número {numPrimo} es Primo");
        }
        else
        {
            Console.WriteLine($"El número {numPrimo} no es Primo");
        }


    }
    public static void FindMaxSecondNum(int[] arr)
    {
        int Maxnum = int.MinValue;
        int MaxSecondNum = int.MinValue;
        for (int i = 1; i < arr.Length; i++)
        {

            if (arr[i] > Maxnum)
            {
                MaxSecondNum = Maxnum;
                Maxnum = arr[i];

            }
            else if (arr[i] > MaxSecondNum && arr[i] < Maxnum)
            {
                MaxSecondNum = arr[i];
            }

        }
        Console.WriteLine($"El segundo mayor numero es {MaxSecondNum}");
    }
    public static void FindMax(int[] arr)
    {
        int Mayor = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > Mayor)
            {
                Mayor = arr[i];
            }
        }
        Console.WriteLine($"El numero mayor es {Mayor}");

    }

    public static void FindMin(int[] arr)
    {
        int menor = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < menor)
            {
                menor = arr[i];
            }
        }
        Console.WriteLine($"El numero menor es {menor}");

    }

    public static void SumarDigitos(int num)
    {

        string newNum = Convert.ToString(num);
        int sumDig = 0;
        foreach (char i in newNum)
        {
            int IntNum = i - '0';
            sumDig += IntNum;

        }
        Console.WriteLine($"La suma es {sumDig}");
    }

    public static void DetectarPalindromo(string palabra)
    {
        //string PalabraTratada = new string(palabra.ToLower().Where(char.IsLetterOrDigit).ToArray());
        string PalabraTratada = palabra.ToLower().Trim().Replace(" ", "");
        for (int i = 0, j = PalabraTratada.Length - 1; i < j; i++, j--)
        {
            if (PalabraTratada[i] != PalabraTratada[j])
            {
                Console.WriteLine($"La palabra {palabra} no es palindromo");
                return;
            }
        }
        Console.WriteLine($"La palabra {palabra} es palindromo");
    }

    public static void EncontrarNumArrBidimensional(int[,] arr, int num)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (num == arr[i, j])
                {
                    Console.WriteLine($"El numero {num} fue encontrado");
                    return;
                }
            }
        }
        Console.WriteLine($"El numero {num} no fue encontrado");
    }

    public static void EncontrarFactorial(int num)
    {
        if (num == 0 || num == 1)
        {
            Console.WriteLine($"el factorial del {num} es 1");
        }
        int resultado = 1;
        for (int i = 1; i <= num; i++)
        {
            resultado *= i;
        }
        Console.WriteLine($"El factorial de {num} es {resultado}");
    }

    public static void EncontrarFibonacci(int num)
    {
        if (num == 0)
        {
            Console.WriteLine($"El numero fibonnaci de {num} es {num}");
        }
        else if (num == 1)
        {
            Console.WriteLine($"El numero fibonnaci de {num} es {num}");
        }
        else
        {
            int a = 0, b = 1, resultado = 0;
            for(int i = 2;i <= num;i++)
            {
                resultado = a + b;
                a = b;
                b = resultado;
            }
            Console.WriteLine($"El numero aureo del numero {num} es {resultado}");
        }
    }

    public static void ContarVocales(string palabra)
    {
       string palabraN = palabra.ToLower().Trim().Replace(" ","");
        int contador = 0;
        for (int i = 0; i < palabraN.Length; i++)
        {
            if (palabraN[i] == 'a' || palabraN[i]=='e' || palabraN[i] == 'i' || palabraN[i]=='o' || palabraN[i] =='u' )
            {
                contador++;
            }
        }
        Console.WriteLine($"el numero de vocales en {palabra} es: {contador} ");
    }
    static void Main(string[] args)
    {
        int[,] arrBi = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
        int[] arr = [1, 2, 3, 4, 5, 12, 22];
        FindMax(arr);
        FindMin(arr);
        FindMaxSecondNum(arr);
        FindNumPrimo(4);
        ArrayReverse(arr);
        SumarDigitos(12);
        DetectarPalindromo("anita lava la tina");
        EncontrarNumArrBidimensional(arrBi, 12);
        EncontrarFactorial(4);
        EncontrarFibonacci(45);
        ContarVocales("tetaa");
    }
}
