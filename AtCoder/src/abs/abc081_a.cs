using System;
using System.Linq;
partial class AtCoder
{   
    public void abc081_a() {
        var str = Console.ReadLine();
        var count = 0;
        foreach(char c in str) {
            // CやC#の場合""と''で意味が違う
            if(c == '1') {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}