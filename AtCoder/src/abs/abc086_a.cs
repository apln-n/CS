using System;
partial class AtCoder
{   
    public void abc086_a() {
        string[] str = Console.ReadLine().Split(" ");
        int a = int.Parse(str[0]);
        int b = int.Parse(str[1]);
        Console.WriteLine((a*b)%2==0? "Even": "Odd");
    }
}