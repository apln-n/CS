using System;
partial class AtCoder
{   
    public void abc083_b() {
        var tmp = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
        (int n, int a, int b) = (tmp[0], tmp[1], tmp[2]);
        int somesum = 0;
        for(int i = 1; i <= n; i++) {
            var num = i;
            var sum = 0;
            var p = (int)(Math.Pow(10, (int)(Math.Log10(num))));
            while (p != 0) {
                sum += num / p;
                num %= p;
                p /= 10;
            }
            if(a<=sum && sum <= b) {
                somesum += i;
            }
        }
        
        Console.WriteLine(somesum);
    }
}