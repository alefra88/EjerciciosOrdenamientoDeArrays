using System.Security.Cryptography.X509Certificates;

class Program
{
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

    static void Main( string[] args )
    {
        int[] arr = [1,2,3,4,5];
        FindMax(arr);
        FindMin(arr);
        FindMaxSecondNum(arr);
    }
}