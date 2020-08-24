using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

public class Solution
{
    public void P2751()
    {
        int size = Convert.ToInt32(Console.ReadLine());
        int temp;
        int[] list = new int[size];
        for (int i = 0; i < size; i++)
        {
            list[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        for (int i = 1; i < size; i++)
        {
            int child = i;   //자식

            do
            {
                int root = (child - 1) / 2;
                if (list[child] > list[root])
                {
                    temp = list[child];
                    list[child] = list[root];
                    list[root] = temp;
                }
                child = root;
            }
            while (child > 0);

        }

        for (int i = size - 1; i > 0; i--)
        {
            int root = 0;
            temp = list[i];
            list[i] = list[root];
            list[root] = temp;

            int child;

            do
            {
                child = root * 2 + 1;

                if (child < i - 1 && list[child] < list[child + 1])  // 자식 왼쪽, 오른쪽
                    child++;

                if (child < i && list[root] < list[child])  // 부모  자식,작은 자식 교환
                {
                    temp = list[child];
                    list[child] = list[root];
                    list[root] = temp;
                }
                root = child;
            }
            while (child < i);

        }


        /*for(int i = 0; i<N; i++)
        {
            int son = i;

            while (son >=1)
            {
                int root = (son - 1) / 2;

                if(ary[root] < ary[son])
                {
                    temp = ary[root];
                    ary[root] = ary[son];
                    ary[son] = temp;
                }
                son = root;
            }
        }

        for(int i = N-1; i>0; i--)
        {
            int root = 0;
            temp = ary[root];
            ary[root] = ary[i];
            ary[i] = temp;
            
            while(root<i)
            {
                int son = root * 2 + 1;

                if (son < i - 1 && ary[son] < ary[son + 1])
                    son++;
                if (son < i &&ary[son] > ary[root]  )
                {
                    temp = ary[root];
                    ary[root] = ary[son];
                    ary[son] = temp;
                }
                root = son;
            }
        }*/


        for (int i = 0; i < size; i++)
        {
            Console.Write(list[i] + "  ");
        }


    }
    public void P2750()
    {
        int temp;
        int N = Convert.ToInt32(Console.ReadLine());
        int[] ary = new int[N];
        for(int i = 0; i<N; i++)
        {
            ary[i] = Convert.ToInt32(Console.ReadLine());
        }

        for(int i = 0; i<N; i++)
        {
            for(int j = i; j<N; j++)
            {
                if (ary[i] > ary[j])
                {
                    temp = ary[i];
                    ary[i] = ary[j];
                    ary[j] = temp;
                }
            }
        }


        for(int i = 0; i<N; i++)
        {
            Console.WriteLine(ary[i]);
        }
    }
    public void P1436()
    {
        int i = 665;
        int N = Convert.ToInt32(Console.ReadLine());
        int Count = 0;
        String Dend = "666";

        while (N != Count)
        {
            i++;
            String temp = i.ToString();

            if (temp.Contains(Dend)) { 
                Count++;
                Console.WriteLine(i);
            }



        }

        Console.WriteLine(i);
        
    }
    public void P1018()
    {
        String arg = Console.ReadLine();
        String[] xy = arg.Split(" ");
        int col = Convert.ToInt32(xy[0]);
        int row = Convert.ToInt32(xy[1]);
        String[] Board = new string[col];
        
        String[] WB = new string[] { "W", "B" };
        int first = 0;
        int second = 1;

        for(int i = 0; i<col; i++)
        {
            Board[i] = Console.ReadLine();
        }
        int Count1 = 0;
        int Count2 = 0;
        int Min = 32 ;
        

        for (int x = 0 ; x <=col-8; x++)
        {
            for(int y = 0; y<= row- 8; y++)
            {
                for (int i = x; i < x + 8; i++)
                {
                   
                    for(int j = y; j < y+8; j++)
                    {
                        if (WB[(first + i + j) % 2].Contains(Board[i][j]))
                            Count1++;
                        if (WB[(second + i + j) % 2].Contains(Board[i][j]))
                            Count2++;
                    }
                    

                }


                if (Min > Count1)
                    Min = Count1;

                if (Min > Count2)
                    Min = Count2;

                Count1 = 0;
                Count2 = 0;
            }
          
        }
        Console.WriteLine(Min);

    }
    public void P7568()
    {
        int N = Convert.ToInt32(Console.ReadLine());
        List<int[]> humen = new List<int[]> { }; 
        for(int i = 0; i<N; i ++)
        {
            String n = Console.ReadLine();
            String[] wh = n.Split(' ');
            int[] temp = new int[2]  ;
            temp[0] = Convert.ToInt32(wh[0]);
            temp[1] = Convert.ToInt32(wh[1]);
            humen.Add(temp);
        }

        for(int i = 0; i< N; i++)
        {
            int site = 1;
            for(int j = 0; j< N; j++)
            {
                 if(humen[i][0] < humen[j][0])
                 {
                    if (humen[i][1] < humen[j][1])
                        site++;
                 }
            }
            Console.Write(site);
            if (i != N - 1)
                Console.Write(" ");
        }
      
    }
    public void P2231()
    {
        int N = Convert.ToInt32(Console.ReadLine());
        
        for( int  i = 1; i<=N; i++)
        {
            int Sum = i;
            int j = i;
            while (j != 0)
            {
                Sum += j % 10;
                j /= 10;
            }
            if (Sum == N)
            {
                Console.WriteLine(i);
                break;
            }
            if(i == N)
            {
                Console.WriteLine("0");
            }
              
        }
       
    }
    public void P2798()
    {
        int N, M;
        String arg = Console.ReadLine();
        String[] NM = arg.Split(" ");
        N = Convert.ToInt32(NM[0]);
        M = Convert.ToInt32(NM[1]);

        arg = Console.ReadLine();
        String[] Card = arg.Split(" ");
        
        int Approx= 0;
        for (int k = 0; k < N - 2; k++)
        {
            for (int i = k+1; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    int temp = Convert.ToInt32(Card[k]) + Convert.ToInt32(Card[i]) + Convert.ToInt32(Card[j]);
                    
                    Console.WriteLine(k+" "+i+" "+j+" "+temp);

                    if (temp <= M && temp > Approx)
                        Approx = temp;
                }
            }
        }
       
        Console.WriteLine(Approx);
    }
    public void P11729()
    {

        int N = Convert.ToInt32(Console.ReadLine());
  
        List<int[]> history = new List<int[]> { };
        var arg = new StringBuilder();

        void hanoi(int n, int start, int end, int middle, List<int[]> history)
        {
            if (n == 1)
            {
                int[] temp= new int[2] ;
                temp[0] = start;
                temp[1] = end;
                history.Add(temp);
                
            }
            else
            {
                
                hanoi(n - 1, start, middle, end, history);
                int[] temp = new int[2];
                temp[0] = start;
                temp[1] = end;
                history.Add(temp);
                hanoi(n - 1, middle, end, start, history);
            }
        }

        hanoi(N, 1, 3, 2, history);


        Console.WriteLine(history.Count);
        foreach(int[] item in history)
        {
            arg.Append(item[0] + " " + item[1] + "\n");
            Console.WriteLine(item[0] + " " + item[1]);
        }


        Console.WriteLine(arg);

    }
    
    public void P2447()
    {
        
        
        int star(int X , int Y,int K)
        {

            if (K == 0)
            {
               return 0;
            }

            if (X / K == 1 && Y / K == 1)
            {
                return 1;
            }


            if (star(X, Y, K / 3) == 1)
            {
                return 1;
            }
            else if(star(X%K, Y%K, K / 3) == 1)
            {
                return 1;
            }

            return 0;


        }
        int N = Convert.ToInt32(Console.ReadLine());

        
        var result = new StringBuilder();
        for (int i = 0; i<N; i++) 
         {
            for(int j = 0; j<N; j++)
            {
                int k = star(i, j,N / 3);

                if (k == 1)
                    result.Append(" ");
                else
                    result.Append("*");
            }
            result.Append("\n");
        }


        Console.Write(result);

    }
    public void P10870()
    {
        int Fivonaci(int n)
        {
            if (n < 2)
            {
                return n;
            }
            return Fivonaci(n - 1) + Fivonaci(n - 2);
        }

        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fivonaci(n));
        
    }
    public void P10872()
    {
       
        int Pectorial(int N)
        {
            if (N == 1)
                return 1;


            return N * Pectorial(N - 1);
        }
        int N = Convert.ToInt32(Console.ReadLine());

        if(N==0)
            Console.WriteLine(1);
        else
            Console.WriteLine(Pectorial(N));


    }

    public void P3053()
    {
        int r = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0:F6}", (r * r * Math.PI));
        Console.WriteLine("{0:F6}", (r * r * 2));
    }

    public void P4153()
    {
        String arg = Console.ReadLine();

        while (!arg.Equals("0 0 0"))
        {
            String[] ABC = arg.Split(" ");
            List<int> sort = new List<int> { };
            sort.Add(Convert.ToInt32(ABC[0]));
            sort.Add(Convert.ToInt32(ABC[1]));
            sort.Add(Convert.ToInt32(ABC[2]));
            sort.Sort();

            int A = sort[0];
            int B = sort[1];
            int C = sort[2];

            if (A * A + B * B == C * C)
                Console.WriteLine("right");
            else
                Console.WriteLine("wrong");

            arg = Console.ReadLine();
        }
    }

    public void P3009()
    {
        int[] XXX = new int[3];
        int[] YYY = new int[3];
        
        int xcheck = 0;
        int ycheck = 0;
        for (int i = 0; i < 3; i++)
        {
            String args = Console.ReadLine();
            String[] arg = args.Split();

            XXX[i] = Convert.ToInt32(arg[0]);
            YYY[i] = Convert.ToInt32(arg[1]);
        }

        for (int i = 1; i < 3; i++)
        {
            if (XXX[0] == XXX[i])
                xcheck = i;

            if (YYY[0] == YYY[i])
                ycheck = i;
        }

        if (xcheck != 0)
            Console.Write(XXX[3 - xcheck] + " ");
        else
            Console.Write(XXX[xcheck] + " ");

        if (ycheck != 0)
            Console.WriteLine(YYY[3 - ycheck]);
        else
            Console.WriteLine(YYY[ycheck]);
    }

    public void P1085()
    {
        String arg = Console.ReadLine();
        String[] xywh = arg.Split(" ");
        int x = Convert.ToInt32(xywh[0]);
        int y = Convert.ToInt32(xywh[1]);
        int w = Convert.ToInt32(xywh[2]);
        int h = Convert.ToInt32(xywh[3]);

        if (x > w - x)
            x = w - x;

        if (y > h - y)
            y = h - y;

        if (x > y)
            Console.WriteLine(y);
        else
            Console.WriteLine(x);
    }

    public void P9020()
    {
        int[] primecheck = new int[10001];
        primecheck[0] = 1;
        primecheck[1] = 1;
        primecheck[2] = 0;
        for (int i = 2; i <= 10000; i++)
        {
            if (primecheck[i] == 0)
            {
                for (int j = i; j <= 10000;)
                {
                    j += i;
                    if (j < 10001)
                        primecheck[j] = 1;
                }
            }
        }

        int T = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < T; i++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int bah = 2;
            for (int j = 2; j <= n / 2; j++)
            {
                if (primecheck[j] == 0 && primecheck[n - j] == 0)
                {
                    bah = j;
                }
            }
            Console.WriteLine(bah + " " + (n - bah));
        }
    }

    public void P4948()
    {
        int[] primecheck = new int[300001];
        primecheck[0] = 1;
        primecheck[1] = 1;
        primecheck[2] = 0;
        for (int i = 2; i <= 300000; i++)
        {
            if (primecheck[i] == 0)
            {
                for (int j = i; j <= 300000;)
                {
                    j += i;
                    if (j < 300001)
                        primecheck[j] = 1;
                }
            }
        }
        int n = 0;
        do
        {
            n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = n + 1; i <= 2 * n; i++)
            {
                if (primecheck[i] == 0)
                {
                    count++;
                }
            }
            if (count != 0)
                Console.WriteLine(count);
        } while (n > 0);
    }

    public void P1929()
    {
        int[] primecheck = new int[1000001];
        primecheck[0] = 1;
        primecheck[1] = 1;
        primecheck[2] = 0;
        String arg = Console.ReadLine();
        String[] MN = arg.Split(" ");
        int M = Convert.ToInt32(MN[0]);
        int N = Convert.ToInt32(MN[1]);
        var result = new StringBuilder();

        for (int i = 2; i <= N; i++)
        {
            if (primecheck[i] == 0)
            {
                if (i >= M)
                {
                    result.Append(i + "\n");
                }
                for (int j = i; j <= N;)
                {
                    j += i;
                    if (j < 1000001)
                        primecheck[j] = 1;
                }
            }
        }

        Console.WriteLine(result);
    }

    public void P2581()
    {
        int[] primecheck = new int[10001];
        primecheck[0] = 1;
        primecheck[1] = 1;
        primecheck[2] = 0;
        int M = Convert.ToInt32(Console.ReadLine());
        int N = Convert.ToInt32(Console.ReadLine());
        int sum = -1;
        int min = -1;
        List<int> n = new List<int> { };

        for (int i = 2; i <= N; i++)
        {
            if (primecheck[i] == 0)
            {
                for (int j = i; j <= N;)
                {
                    j += i;
                    if (j < 10001)
                        primecheck[j] = 1;
                }
            }
        }

        for (int i = M; i <= N; i++)
        {
            if (primecheck[i] == 0)
            {
                if (sum == -1)
                {
                    min = i;
                    sum = i;
                }
                else
                {
                    sum += i;
                }
            }
        }

        Console.WriteLine(sum);
        if (sum != -1)
        {
            Console.WriteLine(min);
        }
    }

    public void P1978()
    {
        int[] primecheck = new int[1000];
        primecheck[1] = 1;
        primecheck[2] = 0;
        List<int> n = new List<int> { };

        int count = 0;
        int t = Convert.ToInt32(Console.ReadLine());
        String args = Console.ReadLine();
        String[] arg = args.Split(" ");

        for (int i = 0; i < arg.Length; i++)
        {
            n.Add(Convert.ToInt32(arg[i]));
        }
        n.Sort();

        for (int i = 2; i <= n[n.Count - 1]; i++)
        {
            if (primecheck[i] == 0)
            {
                for (int j = i; j <= n[n.Count - 1];)
                {
                    j += i;
                    if (j < 1000)
                        primecheck[j] = 1;
                }
            }
        }
        for (int i = 0; i < t; i++)
        {
            if (primecheck[n[i]] == 0)
                count++;
        }

        Console.WriteLine(count);
    }

    public void P1011()
    {
        int T = Convert.ToInt32(Console.ReadLine());

        for (int j = 0; j < T; j++)
        {
            String arg = Console.ReadLine();
            String[] XY = arg.Split(" ");
            long X = Convert.ToInt64(XY[0]);
            long Y = Convert.ToInt64(XY[1]);
            int mod = 0; // 자리수 짝수= 0,홀수= 1  11 111 121 1211 1221 12121 12221 12321
            int add = 1;  // 증가값
            int move = 2;
            int i = 2;

            while (i < Y - X)
            {
                if (mod == 0)
                {
                    add++;
                    i = i + add;
                    mod = 1;
                    move++;
                }
                else if (mod == 1)
                {
                    i = i + add;
                    mod = 0;
                    move++;
                }
            }
            if (Y - X == 1)
                move = 1;

            Console.WriteLine(move);
        }
    }

    public void P2775()
    {
        // 버전차이로 컴파일 에러 , 메서드 안에 메서드 있어서 오류

        int number(int k, int n)
        {
            if (k == 0)
            {
                return n;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return number(k - 1, n) + number(k, n - 1);
            }
        }

        int T = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < T; i++)
        {
            int k = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int result = number(k, n);
            Console.WriteLine(result);
        }
    }

    public void P10250()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            String arg = Console.ReadLine();
            String result = "";

            String[] HWN = arg.Split(" ");

            int Ho = (Convert.ToInt32(HWN[2]) - 1) / Convert.ToInt32(HWN[0]);
            int Floor = Convert.ToInt32(HWN[2]) - Convert.ToInt32(HWN[0]) * Ho;

            result = Convert.ToString(Floor);

            if ((Ho + 1) < 10)
                result += "0";
            result += Convert.ToString(Ho + 1);

            Console.WriteLine(result);
        }
    }

    public void P2869()
    {
        String arg = Console.ReadLine();
        String[] ABV = arg.Split(" ");
        int day = 1;
        int A = Convert.ToInt32(ABV[0]);
        int B = Convert.ToInt32(ABV[1]);
        int V = Convert.ToInt32(ABV[2]);
        if (V <= A)
            Console.WriteLine("1");
        else
        {
            V = V - A - 1;
            day = day + V / (A - B) + 1;
            Console.WriteLine(day);
        }
    }

    public void P1193()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 1;

        while (n > i)
        {
            n -= i;
            i++;
        }

        if (i % 2 == 0)
            Console.WriteLine(n + "/" + (i - n + 1));
        else
            Console.WriteLine((i - n + 1) + "/" + n);
    }

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