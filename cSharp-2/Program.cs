using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_2
{
    class Program
    {
        // 12. ARRAY AS ARGUMENTS OR RETURN VALUES
        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
        }
        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }
        static void PassAndReceiveArrays()
        {
            Console.WriteLine("Arrays as params and return values");
            // Pass array as parameter.
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);
            // Get array as return value.
            string[] strs = GetStringArray();
            foreach (string s in strs)
                Console.WriteLine(s);
            Console.WriteLine();
        }

        // 11. JAGGED ARRAY * * 
        //static void JaggedMultidimensionalArray()
        //{
        //    Console.WriteLine("Jagged multidimensional array");
        //    // Here we have an array of 5 different arrays.
        //    int[][] myJagArray = new int[5][];
        //    // Create the jagged array.
        //    for (int i = 0; i < myJagArray.Length; i++)
        //        myJagArray[i] = new int[i + 7];
        //    // Print each row (remember, each element is defaulted to zero!)
        //    for (int i = 0; i < 5; i++)
        //    {
        //        for (int j = 0; j < myJagArray[i].Length; j++)
        //            Console.Write(myJagArray[i][j] + " ");
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine();
        //}

        // 10. MULTIDIMENSIONAL ARRAYS * * 
        //static void RectMultidimensionalArray()
        //{
        //    Console.WriteLine("Rectangular Multidimensional Array");
        //    int[,] myMatrix;
        //    myMatrix = new int[6, 6];
        //    // 6 x 6
        //    for (int i = 0; i < 6; i++)
        //        for (int j = 0; j < 6; j++)
        //            myMatrix[i, j] = i * j;

        //    for (int i = 0; i < 6; i++)
        //    {
        //        for (int j = 0; j < 6; j++)
        //            Console.Write(myMatrix[i, j] + "\t");
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine();
        //}

        // 9. DEFINING AN ARRAY OF OBJECTS * * 
        // static void ArrayOfObject()
        //{
        //    Console.WriteLine("Array of Objects");

        //    object[] myObject = new object[4];
        //    myObject[0] = 10;
        //    myObject[1] = false;
        //    myObject[2] = new DateTime(2018, 08, 02);
        //    myObject[3] = "Form";

        //    foreach (object obj in myObject)
        //    {
        //        Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
        //    }
        //    Console.WriteLine();
        //}

        // 8. IMPLICITLY TYPED LOCAL ARRAYS * *
        //static void DeclareImplicitArrays()
        //{
        //    Console.WriteLine("Implicit Array Initialization");
        //    // a is really int[].
        //    var a = new[] { 1, 10, 100, 1000 };
        //    Console.WriteLine("a is a: {0}", a.ToString());
        //    // b is really double[].
        //    var b = new[] { 1, 1.5, 2, 2.5 };
        //    Console.WriteLine("b is a: {0}", b.ToString());
        //    // c is really string[].
        //    var c = new[] { "hello", null, "world" };
        //    Console.WriteLine("c is a: {0}", c.ToString());
        //    Console.WriteLine();
        //}

        // 7. ARRAY INITIALIZATION * * 
        //static void ArrayInitialization()
        //{
        //    Console.WriteLine("Array Initialization");
        //    // Array initialization syntax using the new keyword.
        //    string[] stringArray = new string[]
        //    { "one", "two", "three" };
        //    Console.WriteLine("stringArray has {0} elements", stringArray.Length);
        //    // Array initialization syntax without using the new keyword.
        //    bool[] boolArray = { false, false, true };
        //    Console.WriteLine("boolArray has {0} elements", boolArray.Length);
        //    // Array initialization with new keyword and size.
        //    int[] intArray = new int[4] { 20, 22, 23, 0 };
        //    Console.WriteLine("intArray has {0} elements", intArray.Length);
        //    Console.WriteLine();
        //}

        // 6. ARRAYS * *
        //static void SimpleArrays()
        //{
        //    Console.WriteLine("SIMPLE ARRAY");
        //    int[] MyInts = new int[3];
        //    MyInts[0] = 100;
        //    MyInts[1] = 200;
        //    MyInts[2] = 300;

        //    foreach (int i in MyInts)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    Console.WriteLine();
        //}

        // 5. INVOKING METHODS USING NAMED PARAMETERS* *
        //static void DisplayFancyMessage(ConsoleColor textColor,ConsoleColor backgroundColor, string message)
        //{
        //    //Store old colors to restore once message is printed.
        //    ConsoleColor oldTextColor = Console.ForegroundColor;
        //    ConsoleColor oldbackgroundColor = Console.BackgroundColor;

        //    //Set new colors and print message.
        //    Console.ForegroundColor = textColor;
        //    Console.BackgroundColor = backgroundColor;
        //    Console.WriteLine(message);

        //    //Restore previous colors.
        //    Console.ForegroundColor = oldTextColor;
        //    Console.BackgroundColor = oldbackgroundColor;
        //}

        // 4. THE PARAMS MODIFIER * * 
        //static double CalculateAverage(params double[] values)
        //{
        //    Console.WriteLine("You sent me {0} doubles.", values.Length);
        //    double sum = 0;
        //    if (values.Length == 0)
        //        return sum;
        //    for (int i = 0; i < values.Length; i++)
        //        sum += values[i];
        //        return (sum / values.Length);
        //}

        // 3. THE REF MODIFIER * * 
        //public static void SwapStrings(ref string s1, ref string s2)
        //{
        //    string tempStr = s1;
        //    s1 = s2;
        //    s2 = tempStr;
        //}

        // 2. THE OUT MODIFIER * *
        //static void Add (int x, int y, out int ans)
        //{
        //    ans = x + y;
        //}

        //static void FillTheseValues(out int a, out string b, out bool c)
        //{
        //    a = 9;
        //    b = "Enjoy your string.";
        //    c = true;
        //}

        // 1. CREATE METHOD * *
        //static int Add(int x,int y)
        //{
        //    int Answer = x + y;
        //    x = 1000;
        //    y = 8888;
        //    return Answer;
        //}
        static void Main(string[] args)
        {
            // 1. CREATE METHOD * * 
            //Console.WriteLine("CREATE A METHOD");
            //int x = 9, y = 10;
            //Console.WriteLine("Before call X: {0}, Y: {1}",x,y);
            //Console.WriteLine("Answer is: {0}",Add(x,y));
            //Console.WriteLine("After call X: {0}, Y: {1}",x,y);
            //Console.ReadLine();

            // 2. THE OUT MODIFIER * *
            //Console.WriteLine("CREATE THE OUT MODIFIER");
            //int ans;
            //Add(90, 90, out ans);
            //Console.WriteLine("90 + 90 = {0}",ans);
            //int i; string str; bool b;
            //FillTheseValues(out i, out str, out b);
            //Console.WriteLine("Int is: {0}", i);
            //Console.WriteLine("String is: {0}", str);
            //Console.WriteLine("Boolean is: {0}", b);
            //Console.ReadLine();

            // 3. THE REF MODIFIER * * 
            //Console.WriteLine("REF MODIFIER");
            //string s1 = "Flip";
            //string s2 = "Flop";
            //Console.WriteLine("Before: {0}, {1} ", s1, s2);
            //SwapStrings(ref s1, ref s2);
            //Console.WriteLine("After: {0}, {1} ", s1, s2);
            //Console.ReadLine();

            // 4. THE PARAMS MODIFIER * * 
            //Console.WriteLine("PARAMS MODIFIER");
            //// Pass in a comma-delimited list of doubles...
            //double average;
            //average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            //Console.WriteLine("Average of data is: {0}", average);
            //// ...or pass an array of doubles.
            //double[] data = { 4.0, 3.2, 5.7 };
            //average = CalculateAverage(data);
            //Console.WriteLine("Average of data is: {0}", average);
            //// Average of 0 is 0!
            //Console.WriteLine("Average of data is: {0}", CalculateAverage());
            //Console.ReadLine();

            // 5. INVOKING METHODS USING NAMED PARAMETERS
            //DisplayFancyMessage(message: "Wow! Very Fancy indeed",textColor:ConsoleColor.DarkRed,backgroundColor: ConsoleColor.White);
            //DisplayFancyMessage(backgroundColor: ConsoleColor.Green, message: "Testing...", textColor: ConsoleColor.DarkBlue);
            //Console.ReadLine();

            // 6. ARRAYS * *
            //SimpleArrays();
            //Console.ReadLine();

            // 7. ARRAY INITIALIZATION * * 
            //ArrayInitialization();
            //Console.ReadLine();

            // 8. IMPLICITLY TYPED LOCAL ARRAYS * *
            //DeclareImplicitArrays();
            //Console.ReadLine();

            // 9. DEFINING AN ARRAY OF OBJECTS * * 
            //ArrayOfObject();
            //Console.ReadLine();

            // 10. MULTIDIMENSIONAL ARRAYS * * 
            //RectMultidimensionalArray();
            //Console.ReadLine();

            // 11. JAGGED ARRAY * *
            //JaggedMultidimensionalArray();
            //Console.ReadLine();

            // 12. ARRAY AS ARGUMENTS OR RETURN VALUES
            PassAndReceiveArrays();
            Console.ReadLine();
        }
    }
}
