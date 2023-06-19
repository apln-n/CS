using System;
using System.Linq;
partial class AtCoder
{   
    public void abc081_a() {
        var str = Console.ReadLine();
        var count = 0;
        foreach(char c in str) {
            // CÇ‚C#ÇÃèÍçá""Ç∆''Ç≈à”ñ°Ç™à·Ç§
            if(c == '1') {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}