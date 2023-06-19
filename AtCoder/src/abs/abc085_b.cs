using System;
partial class AtCoder
{   
    public void abc085_b() {
        var n = int.Parse(Console.ReadLine());
        var li = new List<int>();
        for(int i = 0; i < n; i++) {
            li.Add(int.Parse(Console.ReadLine()));
        }
        var arr = li.ToArray().Distinct().ToArray();
        Console.WriteLine(arr.Length);
    }
}