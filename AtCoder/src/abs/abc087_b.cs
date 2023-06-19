using System;
partial class AtCoder
{   
    public void abc087_b() {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());
        var x = int.Parse(Console.ReadLine());
        var count = 0;
        for(int i = 0; i <= a; i++) {
            for(int j = 0; j <= b; j++) {
                for(int k = 0; k <= c; k++) {
                    if(i*500+j*100+k*50 == x) {
                        count++;
                        break;
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
}