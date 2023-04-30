﻿using System;
class Program {
    static void Main(string[] args)
    {
        //compare();
        //morethen();
        //MaxResult();
        //High();
        //even();
        //arrange();
        //tictactoe();
        hangman();
        //testScore();
        //lineFormation();
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
        texttictactoe();
        machanicttt();
    }

    static void texttictactoe() {
        Console.WriteLine("Tic Tac Toe Game!!");
        Console.WriteLine();
        Console.WriteLine("___________________");
        Console.WriteLine("| [1] | [2] | [3] |");
        Console.WriteLine("|_____|_____|_____|");
        Console.WriteLine("| [4] | [5] | [6] |");
        Console.WriteLine("|_____|_____|_____|");
        Console.WriteLine("| [7] | [8] | [9] |");
        Console.WriteLine("|_____|_____|_____|");
        Console.WriteLine();
    }

    static void machanicttt() {
        string[] num = new string[9] {"1","2","3","4","5","6","7","8","9"};
        int i = 0;
        bool check = true;
        Console.WriteLine("Start!!");
            while(i <= 8 && check == true) {
                int n;
                if (i % 2 == 0) {
                    Console.Write("Turn X : Input position : ");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n >= 0 && n <= 8) {
                        num[n-1] = "X";
                        i++;
                    }
                    else {
                        Console.WriteLine("Please input number 0 - 8");
                    }
                }
                else {
                    Console.Write("Turn O : Input position : ");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n >= 0 && n <= 8) {
                        num[n-1] = "O";
                        i++;
                    }
                    else {
                        Console.WriteLine("Please input number 0 - 8");
                    }
                }
                if(beforeCheck(num[0], num[1], num[2])) {
                    check = false;
                }
                else if(beforeCheck(num[3], num[4], num[5])) {
                    check = false;
                }
                else if(beforeCheck(num[6], num[7], num[8])) {
                    check = false;
                }
                else if(beforeCheck(num[0], num[3], num[6])) {
                    check = false;
                }
                else if(beforeCheck(num[1], num[4], num[7])) {
                    check = false;
                }
                else if(beforeCheck(num[2], num[5], num[8])) {
                    check = false;
                }
                else if(beforeCheck(num[0], num[4], num[8])) {
                    check = false;
                }
                else if(beforeCheck(num[2], num[4], num[6])) {
                    check = false;
                }
                else {
                    check = true;
                }
                Console.WriteLine(" {0}  {1}  {2} ", num[0], num[1], num[2]);
                Console.WriteLine(" {0}  {1}  {2} ", num[3], num[4], num[5]);
                Console.WriteLine(" {0}  {1}  {2} ", num[6], num[7], num[8]);
            }
        if (i % 2 == 0) {
            Console.WriteLine("O is Winner!!");
        }
        else {
            Console.WriteLine("X is Winner!!");
        }
    }

    static bool beforeCheck(string x, string y, string z) {
        if (x == y && y == z) {
            return true;
        }
        return false;
    }

    static void hangman() {
        string word = "thanapa";
        char input;
        bool check = true;
        string[] answer = new string[word.Length];
        Console.WriteLine("Welcome to Hangman!!!");
        for (int i = 0; i <= word.Length - 1; i++) {
                answer[i] = "*";
                Console.Write("{0}", answer[i]);
            }
        Console.WriteLine();
        while(check) {
            input = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i <= word.Length - 1; i++) {
                int a = 0;
                for (int t = 0; t <= word.Length - 1; t++) {
                    if (checkHangman(answer[t])) {
                        a++;
                    }
                }
                if (word.Length - 1 == a && input == word[i]) {
                    answer[i] = Convert.ToString(input);
                    Console.Write("{0}", answer[i]);
                    check = false;
                }
                else if (input == word[i]) {
                    answer[i] = Convert.ToString(input);
                    Console.Write("{0}", answer[i]);
                }
                else {
                    Console.Write("{0}", answer[i]);
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("You Win!!");
    }
    

    static bool checkHangman(string x) {
        if (x == "*") return false;
        return true;
    }

    static void testScore() {
        float[ , ] score = new float[150,5];
        for (int row = 0; row < 150; row++) {
            for (int col = 0; col < 5; col++) {
                Console.Write("Input score {0} : ",col);
                score[row,col] = float.Parse(Console.ReadLine());
            }
            float sum = 0;
            for (int col = 0; col < 5; col++) {
                sum += score[row,col];
            }
            Console.WriteLine(sum);
        }
        /* for (int row = 0; row < 150; row++) {
            float sum = 0;
            for (int col = 0; col < 5; col++) {
                sum += score[row,col];
            }
            Console.WriteLine(sum);
        } */
    }

    static void lineFormation() {
        Console.Write("Input number of people : ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Input number of rows in front of the board : ");
        int numC = int.Parse(Console.ReadLine());
        int numR = (num / numC) + 1;
        string[ , ] name = new string [numR, numC];
        for (int row = 0; row < numR; row++) {
            for (int col = 0; col < numC; col++) {
                Console.Write("Input name {0} : ",col + 1);
                name[row,col] = Console.ReadLine();
            }
        }
        Console.Write("Input col : ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Input row : ");
        int r = int.Parse(Console.ReadLine());
        /* Console.WriteLine(Getname(name[r, c], c, r, "No one is there.")); */
    }

    static string Getname(string[,] name, int col, int row, string defaultName) {
        if (col < name.GetLength(0) && row < name.GetLength(1)) {
            return name[col, row];
        }
        return defaultName;
    }

    struct Employee {
        public string name;
        public string surname;
        public string address;
        public float salary;
        public Employee(string name, string surname, string address, float salary) {
            this.name = name;
            this.surname = surname;
            this.address = address;
            this.salary =salary;
        }
    }

    static void employeeTest() {
        Employee employee = new Employee("Jiramet", "Angkuthanyarot", "Bangkok", 30000000.0f);
        employee.salary = 700.0f;

    }
}