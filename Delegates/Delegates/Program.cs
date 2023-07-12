using System;

namespace Delegates
{
    
    public delegate void Calculation(int a, int b);

    public delegate void Show_Delegate();  //delegate without perameter

    public delegate void Calculation2(int x);
    class Person
    {
        public static void Square(int x)
        {
            int square = x * x;
            Console.WriteLine("Square of {0} is {1}", x ,square);
        }

        public static void Cube(int x)
        {
            int cube = x * x *x;
            Console.WriteLine("Cube of {0} is {1}", x, cube);
        }
        public static void Show()
        {
            Console.WriteLine("This is the Show method !!");
        }
       public static void Addition(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("Addition result is: {0}",c);
        }
        public static void Substraction(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("Substraction result is: {0}", c);
        }
        public static void Multiplication(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Multipliction result is: {0}", c);
        }
        public static void Devision(int a, int b)
        {
            int c = a/b;
            Console.WriteLine("Devision result is: {0}", c);
        }
        static void Main(string[] args)
        {
            //Calculation obj = new Calculation(Addition);
            //obj.Invoke(45, 55);
            ////obj(45,55)
            //obj = Substraction;
            //obj(45, 33);
            //obj = Multiplication;
            //obj(5, 10);
            //obj = Devision;
            //obj(5, 10);
            Console.WriteLine("_______________");
            //Multicasting
            Calculation obj = new Calculation(Addition);
            obj +=Substraction;
            obj += Multiplication;
            obj -= Devision;
            obj(30, 20);
            Console.WriteLine("_______________");
            //we also can create different objects for different methods
            Calculation obj1 = new Calculation(Person.Substraction);
            obj1.Invoke(34, 23);
            Calculation obj2 = new Calculation(Person.Multiplication);
            obj2(3, 5);
            Calculation obj3 = new Calculation(Person.Devision);
            obj3(10, 2);
            Console.WriteLine("____________");
            Show_Delegate obj4 = new Show_Delegate(Show);
            obj4();
            Console.WriteLine("____________");
            Calculation2 obj5 = new Calculation2(Square);
            obj5(5);
            Console.WriteLine("____________");
            Calculation2 obj6 = new Calculation2(Cube);
            obj6(5);

            //Array
            Console.WriteLine("____________");
            Console.WriteLine("ARRAY");
            int[] my_array = new int[3];
            my_array[0] = 34;
            my_array[1] = 55;
            my_array[2] = 56;

            int[] my_array2 = new int[] { 23, 44, 56, 78, 34 };
            int[] my_array3 = { 23, 44, 56, 78, 34 };
            string[] my_array4 = { "kvi", "anu", "soniya", "Divya", "Sunita" };

            //for loop in array
            int i;
            for (i = 0; i < my_array3.Length; i++)
            {
                Console.WriteLine(my_array3[i]);
            }

            //foreEach loop
            foreach (string s in my_array4)
            {
                Console.WriteLine(s);
            }

            //MultiDimentional Array

            int[,] my_array5 = new int[3, 4]
                {
                {34,56,31,43},
                { 43,67,89,98},
                {21,23,78,90 },
            };
            for (int j = 0; j < my_array5.GetLength(0); j++)
            {
                for (int k = 0; k < my_array5.GetLength(1); k++)
                {
                    Console.Write(my_array5[j, k] + " ");
                }
                Console.WriteLine();
            }
            foreach (var item in my_array5)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("________________");
            //Jagged array
            int[][] my_array6 = new int[3][];
            my_array6[0] = new[] { 34, 45, 78, 9, 98 };
            my_array6[1] = new[] { 12, 13, 14, 15 };
            my_array6[2] = new[] { 78, 90, 89, 91, 95, 67, 78 };
            //Console.WriteLine(new_array6[2][5]);
            for (int m = 0; m < my_array6.GetLength(0); m++)
            {
                for (int n = 0; n < my_array6[m].Length; n++)
                {
                    Console.Write(my_array6[m][n] + " ");
                }
                Console.WriteLine();
            }
            //foreach loop in jagged array
            foreach (int[] num in my_array6)
            {
                foreach (int l in num)
                {
                    Console.WriteLine(l+" ");
                }
            }

            Console.WriteLine(my_array5[1, 3]);
            Console.WriteLine(my_array5.GetLength(0)); //length of row
            Console.WriteLine(my_array5.GetLength(0)); //length of column
            Console.WriteLine(my_array5.Rank); //dimention of array
            Console.WriteLine(my_array[0]);
            Console.WriteLine(my_array2[1]);
            Console.WriteLine(my_array3[3]);
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
