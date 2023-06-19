using System;
partial class AtCoder
{   
    public void abc088_b() {
        var n = int.Parse(Console.ReadLine());
        var arr = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
        Array.Sort(arr);
        Array.Reverse(arr);
        var alice = 0;
        var bob = 0;
        for(int i = 0; i < arr.Length; i++) {
            if (i % 2 == 0) {
                alice += arr[i];
            }
            else {
                bob += arr[i];
            }
        }
        Console.WriteLine(alice-bob);
    }
}