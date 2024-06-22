using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BinarytoDecimalConverter
{
    public static int BinaryToDecimal(string binaryString)
    {
        int decimalValue = 0;
        int baseValue = 1;
        for(int i = binaryString.Length - 1; i >= 0; i--)
        {
            if(binaryString[i] == '1')
            {
                decimalValue += baseValue;
            }
            baseValue *= 2;
        }
        return decimalValue;
    }
    public static void Main(string[] args)
    {
        string binaryString = "11100";
        int decimalValue = BinaryToDecimal(binaryString);
        Console.WriteLine("The decimal value of binary string {0} is: {1}" , binaryString,decimalValue);
    }
}