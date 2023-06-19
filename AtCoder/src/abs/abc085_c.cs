using System;
partial class AtCoder
{   
    public void abc085_c() {
        var tmp = Console.ReadLine().Split(" ").Select(i => int.Parse(i)).ToArray();
        (int n, int y) = (tmp[0], tmp[1]);
        var result = new List<List<int>>();

        for (int i = 0; i <= n; i++) {
            for (int j = 0; j <= n - i; j++) {
                for (int k = 0; k <= n - (i + j); k++) {
                    if (10000 * i + 5000 * j + 1000 * k == y) {
                        result.Add(new List<int> {i,j,k});
                        break;
                    }
                }
            }
        }
        if (result.Count != 0) {
            foreach(List<int> li in result) {
                Console.WriteLine(string.Join(" ",li));
            }
        }
        else {
            Console.WriteLine("-1, -1, -1");
        }
        
    }
}