using System;
partial class AtCoder
{   
    public void abc081_b() {
        var n = int.Parse(Console.ReadLine());
        // �W�����͂��畡���̐��l���󂯎��A�w��(���l)�̌^�ŕۑ�����
        // �������var��double�ɂ��Ă���
        var nums = Console.ReadLine().Split(' ').Select(i => double.Parse(i)).ToArray();
        var count = 0;
        bool flag = true;
        while (flag) {
            for (int i = 0; i < nums.Length; i++) {
                nums[i] /= 2;
                if (nums[i] != (int)nums[i]) {
                    flag = false;
                    break;
                }
            }
            if (flag) {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}