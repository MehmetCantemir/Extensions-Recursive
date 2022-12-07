using System.Collections.Concurrent;

namespace recursive_extension_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recursive Functions
            //3^4=3*3*3*3

            int result = 1;
            for (int i = 1; i < 5; i++)
                result = result * 3;
            Console.WriteLine(result);

            Islemler islem = new Islemler();
            Console.WriteLine(islem.Expo(3,4));

            //Extension Methods
            string s1 = "Mehmet Cantemir";
            bool sonuc= s1.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
                Console.WriteLine(s1.RemoveWhiteSpaces());

            Console.WriteLine(s1.MakeUpperCase());
            Console.WriteLine(s1.MakeLowerCase());

            int[] array = { 9, 3, 6, 2, 1, 5, 0 };
            array.MakeSort();  
            array.EkranaYazdir();




        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us < 2)
                return sayi;
            return Expo(sayi, us - 1) * sayi;
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
           return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("*", dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower(); 
        }
        
        public static int[] MakeSort(this int[] param)
        {
            Array.Sort(param);
            return param;    
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach(var item in param)
            {
                Console.WriteLine(item);
            }
        }

      

    }
}