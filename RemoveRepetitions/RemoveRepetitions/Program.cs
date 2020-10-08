using System;
using System.Linq;
using System.Text;

public class RemoveRepetitions
{
    public static string Transform(string input)
    {

        var sb = new StringBuilder();
        foreach (var b in input.ToCharArray().Distinct()) { sb.Append(b); }



        return sb.ToString();
    }

    public static string TransformProx(string input)
    {

        var str = new StringBuilder();
        var arr = input.ToCharArray();
        foreach (var c in arr)
        {
            if (str.Length == 0)
            {
                str.Append(c);
            }
            else
            {
                if (str[^1] != c)
                {
                    str.Append(c);
                }
            }
        }
        return str.ToString();
    }

    public static string TransformX(string input)
    {
        StringBuilder transformed = new StringBuilder();
        transformed.Append(input[0]);
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i - 1] != input[i])
                transformed.Append(input[i]);
        }
        return transformed.ToString();
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(RemoveRepetitions.TransformProx("abbcbbb")); // dará um retorno de abcb
        Console.WriteLine(RemoveRepetitions.Transform("abbcbbb")); // dará um retorno de abc
        Console.WriteLine(RemoveRepetitions.TransformX("abbcbbb")); // dará um retorno de abcb
    }
}