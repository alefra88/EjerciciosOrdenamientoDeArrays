using System.Security.Cryptography.X509Certificates;
using System;

class Program
{
    public static void ArrayReverse(int[] arr)
    {
            int[] arr2 = new int[arr.Length];
        for(int i = 0;i< arr.Length;i++)
        {

            arr2[arr.Length -i -1] = arr[i];
        }
        Console.WriteLine($"El nuevo array es: "+ string.Join(", ",arr2));
    }
    public static void FindNumPrimo(int numPrimo)
    {
        if(numPrimo <= 1)
        {
            Console.WriteLine($"El numero {numPrimo} no es primo");
        }

        bool esNumPrimo = true;
        for (int i = 2; i <= Math.Sqrt(numPrimo); i++)
        {
            if(numPrimo % i ==0)
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
            else if (arr[i] > MaxSecondNum && arr[i]< Maxnum)
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
        foreach(char i in newNum)
        {
            int IntNum = i - '0';
            sumDig += IntNum;

        }
        Console.WriteLine($"La suma es {sumDig}");
    }
    static void Main( string[] args )
    {
        int[] arr = [1,2,3,4,5,12,22];
        FindMax(arr);
        FindMin(arr);
        FindMaxSecondNum(arr);
        FindNumPrimo(4);
        ArrayReverse(arr);
        SumarDigitos(12);
    }
}