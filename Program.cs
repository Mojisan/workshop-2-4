using System;
class Program {
    static void Main(string[] args)
    {
        //compare();
        //morethen();
        //MaxResult();
        //High();
        //even();
        //arrange();
        tictactoe();
    }

    static void compare() {
        int x1, x2, x3, y1, y2, y3, result; 
        Console.Write("Input x1 : ");
        x1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input y1 : ");
        y1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input x2 : ");
        x2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input y2 : ");
        y2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input x3 : ");
        x3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input y3 : ");
        y3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Result 1 : {0}", Max(x1, y1));
        Console.WriteLine("Result 1 : {0}", Max(x2, y2));
        Console.WriteLine("Result 1 : {0}", Max(x3, y3));
    }

    static int Max(int x, int y) {
        if (x > y) return x;
        else return y;
    }

    static void morethen() {
        int x = 2;
        int y = 7;
        x = more(x,y);
        y = 1;
        x = more(x,y);
        y = 3;
        x = more(x,y);
        y = 6;
        x = more(x,y);
        y = 8;
        x = more(x,y);
        y = 1;
        x = more(x,y);
        y = 2;
        Console.WriteLine("Max : {0}", more(x,y));

    }

    static int more( int x, int y) {
        if ( x > y ) return x;
        else return y;
    }

    static int Max2( int a, int b) {
        if (a > b) return a;
        else return b;
    }

    static int Max4( int a, int b, int c, int d) {
        int result1 = Max2 (a, b);
        int result2 = Max2 (c, d);
        return Max2 (result1, result2);
    }
    static void MaxResult() {
        int result1 = Max4(2, 7, 1, 3);
        int result2 = Max4(6, 8, 1, 2);
        int finalresult = Max2 (result1, result2);
        Console.WriteLine("Result : {0}", finalresult);
    }
    static void High() {
        int[] num = new int[15];
        for (int i = 0; i <= 14; i++) {
            num[i] = int.Parse(Console.ReadLine());
        }
        while(true) {
            Console.Write("Input n : ");
            int s = int.Parse(Console.ReadLine());
            if (s > 0 && s <= 15) {
            Console.WriteLine(num[s-1]);
            }
            else {
                Console.WriteLine("Good bye");
                break;
            }
        }
    }
    static void even() {
        Console.Write("Input n : ");
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        for (int i = 0; i <= n-1; i++) {
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("*************************");
        for (int i = 0; i <= n-1; i++) {
            if(num[i] % 2 == 0) {
                Console.WriteLine(num[i]);
            }
        }
    }
    static void arrange() {
        Console.Write("Input n : ");
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        for (int i = 0; i <= n-1; i++) {
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("*************************");
        Array.Sort(num);
        Array.Reverse(num);

        foreach(int number in num) {
            Console.WriteLine(number);
        }
    }
    static void tictactoe() {
        //texttictactoe();
        machanicttt();
    }

    static void texttictactoe() {
        Console.WriteLine("Tic Tac Toe Game!!");
        Console.WriteLine();
        Console.WriteLine("___________________");
        Console.WriteLine("| [0] | [1] | [2] |");
        Console.WriteLine("|_____|_____|_____|");
        Console.WriteLine("| [3] | [4] | [5] |");
        Console.WriteLine("|_____|_____|_____|");
        Console.WriteLine("| [6] | [7] | [8] |");
        Console.WriteLine("|_____|_____|_____|");
        Console.WriteLine();
    }

    static void machanicttt() {
        string[] num = new string[9] {"-","-","-","-","-","-","-","-","-"};
        Console.WriteLine("Start!!");
        for(int i = 0; i <= 8; i++) {
                int n;
                if (i % 2 == 0) {
                    Console.Write("Turn X : Input position : ");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n >= 0 && n <= 8) {
                        num[n] = "X";
                    }
                    else {
                        Console.WriteLine("Please input number 0 - 8");
                        continue;
                    }
                }
                else {
                    Console.Write("Turn O : Input position : ");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n >= 0 && n <= 8) {
                        num[n] = "O";
                    }
                    else {
                        Console.WriteLine("Please input number 0 - 8");
                        continue;
                    }
                }
                Console.WriteLine(" {0}  {1}  {2} ", num[0], num[1], num[2]);
                Console.WriteLine(" {0}  {1}  {2} ", num[3], num[4], num[5]);
                Console.WriteLine(" {0}  {1}  {2} ", num[6], num[7], num[8]);
        }
    }

    static void turn (int p, int r) {
        string[] num = new string[9];
        if (r % 2 == 0) {
            num[p] = "X";
        }
        else {
            num[p] = "O";
        }

        Console.WriteLine(" {0}  {1}  {2}", num[0], num[1], num[2]);
        Console.WriteLine(" {0}  {1}  {2}", num[3], num[4], num[5]);
        Console.WriteLine(" {0}  {1}  {2}", num[6], num[7], num[8]);
    }
}