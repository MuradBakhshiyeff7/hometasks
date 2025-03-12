using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Program
    {
        const double PI = 3.14;
        static double Area(double radius)
        {
            return PI * radius * radius;
        }

       
        static double Area(double width, double length)
        {
            return width * length;
        }

        
        static double Area(double width, double length, double height)
        {
            return 2 * (width * length + width * height + length * height);
        }

       
        static double Area(double a, double b, double c, bool isIncircle)
        {
            double p = (a + b + c) / 2; 
            double r = ((p - a) * (p - b) * (p - c) / p);
            if (r < 0) r = -r; 
            for (double y = 1.0; y * y <= r; y += 0.00001)
            {
                r = y;
            }
            return PI * r * r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dairenin sahesi: " + Area(5));
            Console.WriteLine("Duzbucaqlinin sahesi: " + Area(4, 6));
            Console.WriteLine("Duzbucaqli paralelpipedin tam sethi: " + Area(3, 4, 5));
            Console.WriteLine("Ucbucagin daxiline cekilmis cevrenin sahesi: " + Area(3, 4, 5, true));

           


            //Console.Write("ededi daxil edin: "); task - 1
            //int number = Convert.ToInt32(Console.ReadLine());
            //int sum = 1;

            //if (number < 0)
            //    number *= -1;

            //while (number > 0)
            //{
            //    sum *= number % 10;
            //    number /= 10;
            //}

            //Console.WriteLine("reqemlerin cemi budur: " + sum);











            //Console.Write("Ededi daxil edin: "); task - 2
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number < 2)
            //{
            //    Console.WriteLine("Murekkeb eded deyil");
            //    return;
            //}

            //bool isPrime = true;

            //for (int i = 2; i * i <= number; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        isPrime = false;
            //        break;
            //    }
            //}

            //if (isPrime)
            //    Console.Write('0');
            //Console.WriteLine("Sade ededdir");
            //else
            //    Console.WriteLine("Murekkeb ededdir");


            //string[] words = { "alma", "armud", "banan", "qarpız", "şaftalı" }; task-3

            //ReverseArray(words);

            //foreach (var word in words)
            //{
            //    Console.Write(word + " ");
            //}


            //static void ReverseArray(string[] arr)
            //{
            //    int n = arr.Length;

            //    for (int i = 0; i < n / 2; i++)
            //    {

            //        string temp = arr[i];
            //        arr[i] = arr[n - i - 1];
            //        arr[n - i - 1] = temp;
            //    }
            //}

            //int[] arr = { 3, 5, 2, 8, 3, 9, 2 }; task-4

            //FindDuplicates(arr);


            //static void FindDuplicates(int[] arr)
            //{
            //    int n = arr.Length;

            //    for (int i = 0; i < n; i++)
            //    {
            //        bool isDuplicate = false;

            //        for (int j = 0; j < i; j++)
            //        {
            //            if (arr[i] == arr[j]) 
            //            {
            //                isDuplicate = true;
            //                Console.WriteLine(arr[i]);
            //                break;
            //            }
            //        }

            //if (!isDuplicate) 
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            Console.WriteLine(arr[i]); 
            //            break;
            //        }
            //    }
            //}



            //int[] array = { 5, 12, 8, 15, 3, 9 };


            //Console.Write("Bir ədəd daxil edin: ");
            //int n = int.Parse(Console.ReadLine());


            //bool result = IsGreaterThanAnyElement(array, n);


            //Console.WriteLine(result);

            //static bool IsGreaterThanAnyElement(int[] array, int n)
            //{

            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (n > array[i])
            //        {
            //            return true;
            //        }
            //    }

            //    return false;
            //}




            //Console.Write("Bir ədəd daxil edin: "); task-6
            //int n = int.Parse(Console.ReadLine()); 


            //int a = 0;
            //int b = 1;


            //Console.WriteLine("Fibonacci ardıcıllığı:");

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(a + " "); 


            //    int next = a + b;
            //    a = b;
            //    b = next;
            //}


            //int[] numbers = { 7, 2, 9, 4, 1, 5 }; task-1
            //Console.WriteLine("En kicik element: " + Min(numbers));


            //string text = "SalamCodeAcademy"; task-3
            //Console.WriteLine("Deyismis metn: " + BosluqlariSil(text));


            //string text = "Salam Azerbaycan olkesi"; task-2
            //IlkHerf(text);
        }


        //static void IlkHerf(string str)
        //{
        //    bool isStart = true;
        //    char[] chars = str.ToCharArray();

        //    for (int i = 0; i < chars.Length; i++)
        //    {
        //        if (isStart && chars[i] != ' ')
        //        {
        //            Console.Write(chars[i]);
        //            isStart = false;
        //        }

        //        if (chars[i] == ' ')
        //        {
        //            isStart = true;
        //        }
        //    }

        //    Console.WriteLine();
        //}
        //task-2


        //static string BosluqlariSil(string input) task-3
        //{
        //    char[] chars = input.ToCharArray();
        //    char[] result = new char[chars.Length];
        //    int index = 0;

        //    for (int i = 0; i < chars.Length; i++)
        //    {
        //        if (chars[i] != ' ')
        //        {
        //            result[index] = chars[i];
        //            index++;
        //        }
        //    }


        //    return new string(result, 0, index);
        //}


        //public static int Min(int[] arr) task-1
        //{
        //    if (arr.Length == 0)
        //    {
        //        Console.WriteLine("Yanlisa yol verdiniz");
        //    }

        //    int minValue = arr[0]; 

        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] < minValue)
        //        {
        //            minValue = arr[i]; 
        //        }
        //    }

        //    return minValue;
        //}


    }
}
