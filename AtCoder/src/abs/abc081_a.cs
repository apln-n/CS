using System;
using System.Linq;
partial class AtCoder
{   
    public void abc081_a() {
        var str = Console.ReadLine();
        var count = 0;
        foreach(char c in str) {
            // C��C#�̏ꍇ""��''�ňӖ����Ⴄ
            if(c == '1') {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}