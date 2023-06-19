using System;
using System.Linq;
using System.Collections.Generic;

/*
partial class AtCoder
{
    static string s = Console.ReadLine().ToString();
    static bool flag = false;
    public void arc065_a() {
        check(0);
        Console.WriteLine("‚ ‚ ");
        Console.WriteLine(flag ? "YES" : "NO");
    }
    static void check(int k) {
        List<string> strs = new List<string>() { "dream", "dreamer", "erase", "eraser" };
        if (k >= s.Length - 1) {
            flag = true;
        }
        else {
            for (int i = 0; i < strs.Count; i++) {
                if (k + strs[i].Length <= s.Length) {
                    // Console.WriteLine($"k:{k}, sub:{s.Substring(k, strs[i].Length)}, s:{s.Substring(k)}");
                    if (s.Substring(k, strs[i].Length) == strs[i]) {
                        // Console.WriteLine($"s:{s.Substring(k, strs[i].Length)}");
                        check(k + strs[i].Length);
                    }
                }
            }
        }
    }
}
*/