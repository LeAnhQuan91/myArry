using System.Runtime.InteropServices;

class Program
    {
public static void Main(string[] args)
{
int [] myArry = {1, 2, 3, 4,5 ,6, 7, 8, 9,10} ;
int sum = 0 ;
for(int i = 0;i < myArry.Length; i++)
{
    sum+= myArry[i] ;
    //Console.Write($"Tong cua mang la:{sum+=i}");// in lien tuc
}
Console.Write($"Tong cua mang la:{sum}"); // in mot lan
            }
    }

