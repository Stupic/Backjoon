﻿using System;
using System.Threading;

public class Solution
{
    public void P2292()
    {
        int N = Convert.ToInt32(Console.ReadLine()) - 1;
        int range = 1;


        while (N > 0)
        {
            N = N - range * 6;
            range++;
        }


        Console.WriteLine(range);
    }
    public void P1712()
    {
        String[] ABC = new String[3];
        ABC = Console.ReadLine().Split(" ");
        int A = Convert.ToInt32(ABC[0]);
        int BC = Convert.ToInt32(ABC[2]) - Convert.ToInt32(ABC[1]); //이윤
        int count = 1;

        if (BC <= 0)
        {
            Console.WriteLine("-1");
            return;
        }

        count = A / BC + 1;
        Console.WriteLine(count);

    }
    public void P1316()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        int i, j;
        for (i = 0; i < n; i++)
        {
            String group = "";
            char target = ' ';
            Boolean check = true;
            String arg = Console.ReadLine();
            for (j = 0; j < arg.Length; j++)
            {


                if (target.Equals(' '))
                {
                    target = arg[j];
                }
                else if (!target.Equals(arg[j]))
                {
                    group += target;

                    if (group.IndexOf(arg[j]) != -1)
                    {
                        check = false;
                        break;
                    }
                    else
                    {

                        target = arg[j];
                    }
                }


            }


            if (check == true)
                count++;
        }
        Console.WriteLine(count);
    }
    public void P2941()
    {
        String arg = Console.ReadLine();
        String[] args;
        String[] excep = new string[] { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
        int Acount = 0;
        int count = 0;

        for (int i = 0; i < excep.Length; i++)
        {
            args = arg.Split(excep[i]);
            count += args.Length - 1;
            arg = "";
            for (int j = 0; j < args.Length; j++)
            {
                arg += args[j];
                arg += "@";
                Acount++;
            }
        }  //nljj

        count += arg.Length;

        Console.WriteLine(count - Acount);

    }
    public void P5622()
    {
        String arg = Console.ReadLine();
        int sum = 0;
        for (int i = 0; i < arg.Length; i++)
        {
            int num = arg[i] - 65;

            if (num < 15)
                sum += (num / 3) + 3;
            else if (num < 19)
                sum += 8;
            else if (num < 22)
                sum += 9;
            else
                sum += 10;
        }
        Console.WriteLine(sum);
    }
    public void P2908()
    {
        String asb = Console.ReadLine();
        String[] arg = asb.Split(" ");

        int a = int.Parse(arg[0]);
        int b = int.Parse(arg[1]);

        int n = 0;
        int before = a;
        do
        {
            n = n + before % 10;
            before = before / 10;
            n = n * 10;
        } while (before / 10 > 0);
        n = n + before;
        a = n;

        n = 0;
        before = b;
        do
        {
            n = n + before % 10;
            before = before / 10;
            n = n * 10;
        } while (before / 10 > 0);
        n = n + before;
        b = n;

        if (a > b)
            Console.WriteLine(a);

        else
            Console.WriteLine(b);


    }
    public void P1152()
    {
        int countnull = 0;
        String args = Console.ReadLine();
        String[] splitargs = args.Split(" ");
        for (int i = 0; i < splitargs.Length; i++)
        {
            if (splitargs[i].Equals(""))
                countnull++;
        }

        Console.WriteLine(splitargs.Length - countnull);
    }
    public void P1157()
    {
        int[] site = new int[26] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
                                   -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
                                   -1, -1, -1, -1, -1, -1 };

        String args = Console.ReadLine();

        for (int i = 0; i < args.Length; i++)
        {
            int asc;
            if (Convert.ToInt32(args[i]) > 96)
                asc = Convert.ToInt32(args[i]) - 97;
            else
                asc = Convert.ToInt32(args[i]) - 65;

            site[asc]++;
        }

        int count = -1;
        int c = 65;
        int check = 1;

        for (int i = 0; i < site.Length; i++)
        {
            if (site[i] > count)
            {
                count = site[i];
                c = i + 65;
                check = 0;
            }
            else if (site[i] == count)
            {
                check = 1;
            }

        }

        if (check == 1)
            Console.WriteLine("?");
        else
            Console.WriteLine(Convert.ToChar(c));

    }
    public void P2675()
    {
        int T = Convert.ToInt32(Console.ReadLine());

        for (int k = 0; k < T; k++)
        {
            String args = Console.ReadLine();
            String[] splitargs = args.Split(" ");
            int R = Convert.ToInt32(splitargs[0]);

            for (int i = 0; i < splitargs[1].Length; i++)
            {
                for (int j = 0; j < R; j++)
                {
                    Console.Write(splitargs[1][i]);
                }
            }
            Console.WriteLine();
        }
    }
    public void P10809()
    {
        int[] site = new int[26] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
                                   -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
                                   -1, -1, -1, -1, -1, -1 };

        String args = Console.ReadLine();

        for (int i = 0; i < args.Length; i++)
        {
            int asc = Convert.ToInt32(args[i]) - 97;
            if (asc >= 0 && asc <= 26 && site[asc] == -1)
            {
                site[asc] = i;
            }
        }

        for (int i = 0; i < site.Length - 1; i++)
        {
            Console.Write(site[i] + " ");
        }
        Console.WriteLine(site[site.Length - 1]);
    }
    public void P4673()
    {
        int[] notSelf = new int[10001];

        void Selcheck(int n)
        {
            if (notSelf[n] != 1)
                Console.WriteLine(n);

            int nextN = split(n);

            if (nextN < 10001 && notSelf[nextN] != 1)
            {
                notSelf[nextN] = 1;
                Selcheck(nextN);
            }

        }
        int split(int n)
        {
            int nextN = n;

            while (n / 10 != 0)
            {
                nextN += n % 10;
                n = n / 10;
            }

            nextN = nextN + n;

            return nextN;

        }

        for (int i = 1; i < 10001; i++)
        {
            Selcheck(i);
        }
    }
    public void P1065()
    {

        static Boolean hansu(int a)
        {
            int n = a; // 남은 수  
            int x;  // 이전 수
            int dif = 10; //등차  10이 나올수 없음

            if (n <= 99)   // n 이 100 미만이면 한수
            {
                return true;
            }


            x = n % 10; // 1의자리수 ;

            while (n / 10 != 0) // 몫이  없다는 건 한자리 뿐
            {
                n = n / 10;
                if (dif == 10) //등차가 설정되지 않았을 경우
                {             //설정하면서 넘어감
                    dif = x - n % 10;
                    x = n % 10;
                }
                else
                {
                    if (x - (n % 10) != dif) // 이전 수 , 다음수의 차이가 전과 다르다면
                        return false;
                    else
                    {
                        x = n % 10;

                    }
                }
            }
            return true;
        }

        int a;
        int count = 0;
        a = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= a; i++)
        {
            if (hansu(i) == true)
                count++;
        }

        Console.WriteLine(count);


    }
    public void P11654()
    {
        int a;
        a = Convert.ToInt32(Console.Read());

        Console.WriteLine(a);
    }
    public void P8958()
    {
        int Score;
        int n;
        int i;
        int j;
        String Answer;
        int Case = Convert.ToInt32(Console.ReadLine());

        for (i = 0; i < Case; i++)
        {
            Answer = Console.ReadLine();
            Score = 0;
            n = 0;
            for (j = 0; j < Answer.Length; j++)
            {
                if (Answer[j] == 'O')
                    n++;
                else
                    n = 0;

                Score += n;
            }
            Console.WriteLine(Score);
        }

    }
    public void P3052()
    {

        int i;
        int n = 0; ;
        int[] arry = new int[42];
        for (i = 0; i < 10; i++)
        {
            arry[Convert.ToInt32(Console.ReadLine()) % 42] = 1;
        }

        for (i = 0; i < arry.Length; i++)
        {
            if (arry[i] != 0)
                n++;
        }

        Console.WriteLine(n);
    }
    public void P2577()
    {

        int i; int N = 1;
        int[] arry = new int[10];
        String list;
        int n;
        for (i = 0; i < 3; i++)
        {
            N = N * Convert.ToInt32(Console.ReadLine());
        }

        list = Convert.ToString(N);

        for (i = 0; i < list.Length; i++)
        {
            n = Convert.ToInt32(list[i]) - 48;
            arry[n]++;
        }

        for (i = 0; i < arry.Length; i++)
        {
            Console.WriteLine(arry[i]);
        }
    }
    public void P2562()
    {

        int rank = 0;
        int i;
        int[] score = new int[9];

        for (i = 0; i < 9; i++)
        {
            score[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 1; i < 9; i++)
        {
            if (score[i] > score[rank])
                rank = i;
        }

        Console.WriteLine(score[rank]);
        Console.WriteLine(rank + 1);
    }
    public void P10818()
    {

        int max = -1000000;
        int min = 1000000;
        int i;
        int n = Convert.ToInt32(Console.ReadLine());

        String[] arry = Console.ReadLine().Split(' ');

        for (i = 0; i < n; i++)
        {
            if (Convert.ToInt32(arry[i]) > max)
                max = Convert.ToInt32(arry[i]);

            if (Convert.ToInt32(arry[i]) < min)
                min = Convert.ToInt32(arry[i]);
        }

        Console.WriteLine(min + " " + max);

    }
    public void P10996()
    {

        int n;
        int i, j;

        n = Convert.ToInt32(Console.ReadLine());

        if (n == 1)
        {
            Console.Write("*");
            return;
        }

        for (i = 1; i <= 2 * n; i++)
        {
            for (j = 1; j <= n; j++)
            {
                if (i % 2 == j % 2)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }

            Console.WriteLine();
        }

    }
    public void P2446()
    {

        int n;
        int i, j;
        int count = 0;

        n = Convert.ToInt32(Console.ReadLine());

        for (i = 1; i <= 2 * n - 1; i++)
        {
            for (j = 1; j <= 2 * n - 1; j++)
            {
                if (j < n - Math.Abs(i - n))
                    Console.Write(" ");
                else
                    Console.Write("*");

                if (j == 2 * n - 1 - (n - Math.Abs(i - n)) + 1)
                    break;

            }

            Console.WriteLine();
        }

    }
    public void P2523()
    {

        int n;
        int i, j;

        n = Convert.ToInt32(Console.ReadLine());

        for (i = 1; i <= 2 * n - 1; i++)
        {
            for (j = 0; j < n - Math.Abs(i - n); j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

    }
    public void P5543()
    {

        int[] buger = new int[3];
        int[] drink = new int[2];
        string sarg;
        int i = 0;
        int set = 99999;

        while ((sarg = Console.ReadLine()) != null)
        {
            if (i < 3)
                buger[i] = Convert.ToInt32(sarg);
            else
                drink[i - 3] = Convert.ToInt32(sarg);


            i++;

            if (i == 5)
                break;
        }

        for (i = 0; i < 3; i++)
        {
            if (set > buger[i])
                set = buger[i];
        }

        if (drink[0] > drink[1])
            set += drink[1];
        else
            set += drink[0];

        Console.WriteLine(set - 50);




    }
    public void P10039()
    {

        string sarg;
        int avg = 0;
        int count = 0;
        while ((sarg = Console.ReadLine()) != null)
        {

            if (Convert.ToInt32(sarg) >= 40)
                avg = avg + Convert.ToInt32(sarg);

            else
                avg = avg + 40;
            count++;
            if (count >= 5)
                break;
        }


        Console.WriteLine(avg / 5);
    }
    public void P10951()
    {

        string sarg;


        while ((sarg = Console.ReadLine()) != null)
        {


            string[] sparg = sarg.Split(" ");


            if (int.Parse(sparg[0]) >= 10 || int.Parse(sparg[0]) <= 0)
                break;
            if (int.Parse(sparg[1]) >= 10 || int.Parse(sparg[1]) <= 0)
                break;


            Console.WriteLine("{0}", (int.Parse(sparg[0]) + int.Parse(sparg[1])));


        }

    }
    public void P10952()
    {

        string sarg;


        while (true)
        {
            sarg = Console.ReadLine();
            string[] sparg = sarg.Split(" ");
            if (sparg[0] == "0" && sparg[1] == "0")
                break;

            Console.WriteLine("{0}", (int.Parse(sparg[0]) + int.Parse(sparg[1])));


        }

    }
    public void P11022()
    {

        string sarg;
        int e;
        e = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < e; i++)
        {
            sarg = Console.ReadLine();
            string[] sparg = sarg.Split(" ");
            Console.WriteLine("Case #{0}: {1} + {2} = {3}", i + 1, sparg[0], sparg[1], (int.Parse(sparg[0]) + int.Parse(sparg[1])));

        }

    }
    public void P11021()
    {

        string sarg;
        int e;
        e = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < e; i++)
        {
            sarg = Console.ReadLine();
            string[] sparg = sarg.Split(" ");
            Console.WriteLine("Case #{0}: {1}", i + 1, (int.Parse(sparg[0]) + int.Parse(sparg[1])));

        }

    }
    public void P10950()
    {

        string sarg;
        int e;
        e = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < e; i++)
        {
            sarg = Console.ReadLine();
            string[] sparg = sarg.Split(" ");
            Console.WriteLine((int.Parse(sparg[0]) + int.Parse(sparg[1])));

        }

    }
    public void P2884()
    {


        int a, b;
        string sarg;

        sarg = Console.ReadLine();
        string[] spstring = sarg.Split(" ");

        a = Convert.ToInt32(spstring[0]);
        b = Convert.ToInt32(spstring[1]);

        if (b >= 45)
            b = b - 45;
        else
        {
            b = b - 45 + 60;
            a = a - 1;
        }

        if (a < 0)
            a = 23;

        Console.WriteLine(a + " " + b);

    }
    public void P14681()
    {

        int a, b;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());

        if (a * b > 0)
        {
            if (a > 0)
                Console.WriteLine(1);
            else
                Console.WriteLine(3);
        }
        else
        {
            if (a > 0)
                Console.WriteLine(4);

            else
                Console.WriteLine(2);

        }

    }
    public void P2753()
    {

        int a;
        a = Convert.ToInt32(Console.ReadLine());

        if (a % 4 == 0)
        {
            if (a % 100 != 0 || a % 400 == 0)
                Console.WriteLine("1");
            else
                Console.WriteLine(0);
        }
        else
            Console.WriteLine(0);
    }
    public void P1330()
    {

        int a, b;
        string arg;
        arg = Console.ReadLine();
        string[] spstring = arg.Split(" ");
        a = Convert.ToInt32(spstring[0]);
        b = Convert.ToInt32(spstring[1]);
        Console.WriteLine(a);
        Console.WriteLine(b);

        if (a > b)
            Console.WriteLine(">");
        if (a < b)
            Console.WriteLine("<");
        if (a == b)
            Console.WriteLine("==");
    }
    public void P2588()
    {

        int a, b;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("{0}", a * (b % 10));
        Console.WriteLine("{0}", a * ((b % 100) - (b % 10)) / 10);
        Console.WriteLine("{0}", a * (b - (b % 100)) / 100);
        Console.WriteLine("{0}", a * b);

    }
    public void P10171()
    {

        Console.WriteLine("\\    /\\");
        Console.WriteLine(" )  ( ')");
        Console.WriteLine("(  /  )");
        Console.WriteLine(" \\(__)|");

    }




}
