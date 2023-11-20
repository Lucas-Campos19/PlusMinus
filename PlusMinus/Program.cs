using System.Globalization;
class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int tamanhoArray = arr.Count;
        double positivo = 0, negativo = 0, zero = 0, retornaPositivo = 0, retornaNegativo = 0, retornaZero = 0;
        CultureInfo cultureInfo = new CultureInfo("en-US");
        for (int i = 0; i < tamanhoArray; i++)
        {
            if (arr[i] > 0)
            {
                positivo++;
            }
            else if (arr[i] < 0)
            {
                negativo++;
            }
            else
            {
                zero++;
            }
        }
        retornaPositivo = positivo / tamanhoArray;
        retornaNegativo = negativo / tamanhoArray;
        retornaZero = zero / tamanhoArray;

        Console.WriteLine(retornaPositivo.ToString("0.000000", cultureInfo));
        Console.WriteLine(retornaNegativo.ToString("0.000000", cultureInfo));
        Console.WriteLine(retornaZero.ToString("0.000000", cultureInfo));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
