using System.Globalization;

namespace session4
{


    //1.Class            -> Function
    //2.Struct           -> Function
    //3.InterFaces       -> Function
    //4.ENUM


    //class NewData
    //{
    //    public int Sum;
    //    public int Mul;

    //}
    internal class Program
    {

        //// static void PrintShape()
        ////{
        ////    //Body 
        ////    for (int i = 0; i <10; i++)
        ////    {
        ////        Console.WriteLine("^_^");
        ////    }
        ////}

        ////static void PrintShape(int Count)
        ////{
        ////    //Body 
        ////    for (int i = 0; i <= Count; i++)
        ////    {
        ////        Console.WriteLine("^_^");
        ////    }
        ////}
        //static void PrintShape(int Count , String Pattern)
        //{
        //    //Body 
        //    for (int i = 0; i < Count; i++)
        //    {
        //        Console.WriteLine(Pattern);
        //    }
        //}


        //static int SumNumbers(int Number01, int Number02)

        //{
        //    return Number01 + Number02;
        //}

        //static void SWAP(int X , int Y)
        //{   
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //static void SWAP(ref int X,ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //// Entry Point 


        //static int SumArray(int[] Arr)
        //{
        //    Arr[0] = 100;
        //    int Sum = 0;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }
        //    return Sum;
        //}
        //static int SumArray( ref int[] Arr)
        //{
        //    Arr[0] = 100;
        //    int Sum = 0;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }
        //    return Sum;
        //}


        //static NewData SumMul(int X, int Y)
        //{
        //   NewData data = new NewData();
        //    data.Sum = X + Y;
        //    data.Mul = X * Y;
        //    return data;
        //}

        //static void SumMul(int X, int Y ,out  int Sum ,out int Mul)
        //{
        //    Sum = X + Y;
        //    Mul = X * Y;
        //}

        //static int SumArray(params int[] Arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        sum += Arr[i];
        //    }

        //    return sum;
        //}
        static void Main(string[] args)
        {

            Console.WriteLine("V01");
            #region One D Array
            //int[] Numbers;
            //Declare For Reference(Pointer) From Type Arrray Of Integers
            //Numbers : Can Refer To Object From Type 'Array Of Integers '
            //Numbers: Refer To Null
            // 8 Byyes Will Be Allocated At Stack For The Referance 'Numbers'
            // 8 Byyes Will Be Allocated At Heap

            //Numbers = new int[Size];
            //Numbers = new int[5];
            //New
            //1.Alloacate The Numbers Of Required Bytes For The Object At HEAP(4 Bytes * 5  ) 20 Bytes
            //2.Initialized The Allocated Bytes Whith The Default Value Of The Datatype
            //3.Call User - Defined Constructor If Exist
            //4.Assign  The Object To The Reference 'Numbers'
            //Numbers[0] = 12;
            //Numbers[1] = 15;
            //Numbers[2] = 20;
            //Numbers[3] = 30;
            //Numbers[4] = 50;
            //Numbers[5] = 60; //  Out Of Range
            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);
            //Console.WriteLine(Numbers[3]);
            //int[] Numbers = { 1, 2, 3, 4, 5 };
            //int[] Numbers02 = new int[5] { 1, 2, 3, 4, 5 };
            //int[] Numbers03 = new int[] { 1, 2, 3, 4, 5 };
            ///
            //int[] Numbers;
            //Numbers = new int[5];
            //for (int i = 0; i < Numbers.Length; i++)
            //{

            //    Console.Write($"Enter Numbers[{i}]:");
            //    Numbers[i] = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("============================");
            //for (int i = 0; i < Numbers.Length; i++)
            //{

            //    Console.Write($"{Numbers[i]} ");

            //}

            //One D Array

            //Console.WriteLine(Numbers.Length); // Size
            //Console.WriteLine(Numbers.Rank); // Dimension  
            #endregion

            Console.WriteLine("V02");

            #region Two D Array


            //Two D Array
            // int[,] Marks = new int[3, 3];
            //Marks[0,0] = 99;
            //Marks[0, 1] = 98;
            //Marks[0, 2] = 97;

            //Marks[1, 0] = 96;
            //Marks[1, 1] = 95;
            //Marks[1, 2] = 94;

            //Marks[2, 0] = 93;
            //Marks[2, 1] = 92;
            //Marks[2, 2] = 91;
            //Console.WriteLine(Marks[0, 0]);
            //Console.WriteLine(Marks[0, 1]);
            //Console.WriteLine(Marks[0, 2]);

            //Console.WriteLine(Marks[1, 0]);
            //Console.WriteLine(Marks[1, 1]);
            //Console.WriteLine(Marks[1, 2]);

            //Console.WriteLine(Marks[2, 0]);
            //Console.WriteLine(Marks[2, 1]);
            //Console.WriteLine(Marks[2, 2]);



            //for (int i = 0; i < 3; i++ )
            //{

            //for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Enter Marks[{i},{j}]:");
            //        Marks[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine();

            //for (int i = 0; i < 3; i++)
            //{

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{Marks[i,j]}:");
            //    }
            //    Console.WriteLine();
            //}







            #endregion
            Console.WriteLine("V03");

            #region Two D Array Juddge
            //int[][] Marks = new int[3][];
            //Marks[0] = new int[] {1,2,3,4, 5 };
            //Marks[1] = new int[] {1,2 };
            //Marks[2] = new int[] {1,2,3,4  };

            //int[][] Marks = new int[3][];
            //Marks[0] = new int[] { 1, 2, 3, 4, 5 };
            //Marks[1] = new int[] { 1, 2 };
            //Marks[2] = new int[] { 1, 2, 3, 4 };


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.Write($"Marks[{i}][{j}] ");
            //        Marks[i][j] = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.WriteLine($"{Marks[i][j]}");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion
            Console.WriteLine("V04");


            #region Function Prototype
            //Function  : Block Of Code That Have Name If U Need To Execute  This Code 
            // U Need To Call The Function  By the Name 
            // DRY  

            // Function Prototype
            // 1. Signature
            //  1.1 Name
            //  1.2 Return Type
            //  1.3 Parameters(Inputs)
            // 2. Body (Code)

            //Callinf For The Function 

            // PrintShape(3, "Fahd");//Passin By Order 
            // PrintShape( Pattern: "Fahd" , Count: 5);//Passin By NAme 

            // PrintShape( )

            //Methods 
            //1. Class Member Method (Static Methods)
            //2. Object Member Method(Non Static Methods)
            //   Console.WriteLine(SumNumbers(2, 3));
            #endregion

            #region Passing Parameter Value Type

            //Passing By Value 





            // //Passing Parsmeter Value Type 
            ////Passing  By Value
            //int A  = 4 , B = 5;
            // Console.WriteLine($"A:{A}");
            // Console.WriteLine($"B:{B}");

            // Console.WriteLine($"---------After Swap------");
            // SWAP(A,B); // Passing By Value

            // Console.WriteLine($"A:{A}");
            // Console.WriteLine($"B:{B}");

            //// //Passing  By Rev
            //int A = 4, B = 5;
            //Console.WriteLine($"A:{A}");
            //Console.WriteLine($"B:{B}");

            //Console.WriteLine($"---------After Swap------");
            //SWAP(ref A,ref B); // Passing By Value

            //Console.WriteLine($"A:{A}");
            //Console.WriteLine($"B:{B}");

            #endregion
            #region  Passing Parameter Reference Type
            ////Passing Parameter Reference Type
            ////1. Passing By Value
            ////int[ ] Numbers = new int[] { 1, 2, 3, 4, 5 };
            ////int Result =    SumArray(Numbers); // Passing By Value
            ////Console.WriteLine(Result);
            ////Console.WriteLine(Numbers[0]);


            ////2. Passing By Reference
            //int[] Numbers = new int[] { 1, 2, 3, 4, 5 };
            //int Result = SumArray(ref Numbers); // Passing By Ref
            ////The Address Of The Numbers 
            //Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]);


            #endregion

            #region Passing By Out


            //int A = 3, B = 4;
            //int[] Result = SumMul(A, B);
            //Console.WriteLine(Result);


            //int A = 3, B = 4;
            //NewData Result = SumMul(A, B);
            //Console.WriteLine(Result.Mul);
            //Console.WriteLine(Result.Sum);

            //OutPut Parameter 
            //Passing By Out 


            //int A = 4, B = 5;
            //SumMul(A, B,out Sum , out Mul); 
            #endregion

            #region Params
            ////Params
            //int[] Numbers = { 1, 2, 3, 4,5,6,7 };

            //Console.WriteLine(SumArray(1, 2, 3, 4, 5, 6, 7)); 
            #endregion




        }

    }
}
