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
        for (int i = 0; i < arr.Length; i++)
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
            for (int i = 2; i <= num; i++)
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
        string palabraN = palabra.ToLower().Trim().Replace(" ", "");
        int contador = 0;
        for (int i = 0; i < palabraN.Length; i++)
        {
            if (palabraN[i] == 'a' || palabraN[i] == 'e' || palabraN[i] == 'i' || palabraN[i] == 'o' || palabraN[i] == 'u')
            {
                contador++;
            }
        }
        Console.WriteLine($"el numero de vocales en {palabra} es: {contador} ");
    }

    public static void InvertirPalabra(string palabra)
    {
        char[] arrInvertido = new char[palabra.Length];

        for (int i = 0; i < palabra.Length; i++)
        {
            arrInvertido[palabra.Length - i - 1] = palabra[i];
        }
        Console.WriteLine($"La palabra invertida es: {new string(arrInvertido)}");
    }

    public static void EncontrarNumPerfecto(int num)
    {
        int sumarDivisores = 0;
        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                sumarDivisores += i;
            }
            if (sumarDivisores == num)
            {
                Console.WriteLine($"El numero {num} es perfecto");
            }
        }
        Console.WriteLine($"El numero {num} no es perfecto");

    }

    public static void SumarNumerosNaturales(int num)
    {
        int sumNumNat = 0;
        for (int i = 1; i <= num; i++)
        {
            sumNumNat += i;
        }
        Console.WriteLine($"la suma es {sumNumNat}");

    }

    public static void NoDuplicados(int[] num)
    {
        HashSet<int> list = new HashSet<int>(num);
        Console.WriteLine("La nueva lista es: " + string.Join(",", list));
    }

    public static void NoDuplicadosSinHashSet(int[] num)
    {
        List<int> numSinRepetir = new List<int>();
        for (int i = 1; i < num.Length; i++)
        {
            if (!numSinRepetir.Contains(num[i]))
            {
                numSinRepetir.Add(num[i]);
            }
        }
        Console.WriteLine($"La nueva lista es: " + string.Join(", ", numSinRepetir));
    }

    public static void Sort(int[] num)
    {

        for (int i = 0; i < num.Length - 1; i++)
        {
            for (int j = 0; j < num.Length - 1 - i; j++)
            {
                if (num[j] > num[j + 1])
                {
                    int temp = num[j];
                    num[j] = num[j + 1];
                    num[j + 1] = temp;
                }

            }
        }
        Console.WriteLine($"la nueva lista burbuja es: " + string.Join(",", num));

    }

    public static void SortDesc(int[] num)
    {

        for (int i = 0; i < num.Length - 1; i++)
        {
            for (int j = 0; j < num.Length - 1 - i; j++)
            {
                if (num[j] < num[j + 1])
                {
                    int temp = num[j];
                    num[j] = num[j + 1];
                    num[j + 1] = temp;
                }

            }
        }
        Console.WriteLine($"la nueva lista burbuja es: " + string.Join(",", num));

    }


    public static void OrdenarEliminarNum(int[] num)
    {
        List<int> numUnico = new List<int>();
        foreach(int i in num)
        {
            if(!numUnico.Contains(i))
            {
                numUnico.Add(i);
            }
        }
        int numLen = numUnico.Count;
        for (int j = 0; j < numLen - 1; j++)
        {
            for (int k = 0; k < numLen - j -1; k++)
            {
                if (numUnico[k] > numUnico[k + 1])
                {
                    int temp = numUnico[k];
                    numUnico[k] = numUnico[k + 1];
                    numUnico[k + 1] = temp;
                }
            }
        }

        Console.WriteLine($"La lista generada es: " + string.Join(",", numUnico));
    }

    static void Main(string[] args)
    {
        int[,] arrBi = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
        int[] arr = [1, 2, 3, 4, 5, 12, 22];
        int[] arrEje = [100, 2, 7, 5, 12, 68, 22];

        int[] arrNumRep = [8, 8, 7, 7, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5];
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
        ContarVocales("eaa");
        InvertirPalabra("Hola chavos");
        EncontrarNumPerfecto(4);
        SumarNumerosNaturales(3);
        NoDuplicados(arrNumRep);
        NoDuplicadosSinHashSet(arrNumRep);
        Sort(arrEje);
        SortDesc(arrEje);
        OrdenarEliminarNum(arrNumRep);
    }
}
