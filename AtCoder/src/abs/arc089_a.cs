using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

class Data {
    public int t, x, y;
    public Data(int t, int x, int y) {
        set(t, x, y);
    }
    public void set(int t, int x, int y) {
        this.t = t;
        this.x = x;
        this.y = y;
    }
}

partial class AtCoder
{
    public void arc089_a() {
        var n = int.Parse(Console.ReadLine());
        var li = new List<Data>();
        var now = new Data(0, 0, 0);
        for(int i = 0; i < n; i++) {
            var tmp = Console.ReadLine().Split(" ").Select(a => int.Parse(a)).ToArray();
            li.Add(new Data(tmp[0], tmp[1], tmp[2]));
        }
        var flag = false;
        for(int i = 0; i < n; i++) {
            var d = new Data(
                Math.Abs(li[i].t - now.t),
                Math.Abs(li[i].x - now.x),
                Math.Abs(li[i].y - now.y)
                );
            if((d.t-(d.x+d.y))%2 == 0 && d.t>=(d.x+d.y)) {
                now = li[i];
            }
            else {
                break;
            }
            if (i == n - 1) {
                flag = true;
                break;
            }
        }
        Console.WriteLine(flag ? "Yes" : "No");
    }
}

