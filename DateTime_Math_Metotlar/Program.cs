using System;
namespace DateTime_Math_Metotlar
{
    class Program
    {
        static void Main(string[]args)
        {
          Console.WriteLine(DateTime.Now); //Günün tarhihini ve saatini getirir.
          Console.WriteLine(DateTime.Now.Date);  //günün tarihini getirir.
          Console.WriteLine(DateTime.Now.Day);  //gün
          Console.WriteLine(DateTime.Now.Month); //ay
          Console.WriteLine(DateTime.Now.Year); //yıl
          Console.WriteLine(DateTime.Now.Hour); //saat
          Console.WriteLine(DateTime.Now.Minute); //dakika
          Console.WriteLine(DateTime.Now.Second); //saniye

          Console.WriteLine(DateTime.Now.DayOfWeek); //haftanın hangi günü
          Console.WriteLine(DateTime.Now.DayOfYear); //yılın kaçıncı günü

          Console.WriteLine(DateTime.Now.ToLongDateString()); //28 Ocak 2022 Cuma
          Console.WriteLine(DateTime.Now.ToShortDateString());  //28.01.2022
          Console.WriteLine(DateTime.Now.ToLongTimeString()); // 20:46:11
          Console.WriteLine(DateTime.Now.ToShortTimeString()); // 20:46

          Console.WriteLine(DateTime.Now.AddDays(2));  //ekleme işlemleri
          Console.WriteLine(DateTime.Now.AddHours(3));
          Console.WriteLine(DateTime.Now.AddSeconds(30));
          Console.WriteLine(DateTime.Now.AddMonths(4));
          Console.WriteLine(DateTime.Now.AddYears(6));
          Console.WriteLine(DateTime.Now.AddMilliseconds(50));
         
         //DateTime Format
          Console.WriteLine(DateTime.Now.ToString("dd")); //28
          Console.WriteLine(DateTime.Now.ToString("ddd")); //Fri
          Console.WriteLine(DateTime.Now.ToString("dddd")); //Friday

          Console.WriteLine(DateTime.Now.ToString("MM")); //01
          Console.WriteLine(DateTime.Now.ToString("MMM")); //Jan
          Console.WriteLine(DateTime.Now.ToString("MMMM")); //January

          Console.WriteLine(DateTime.Now.ToString("yy")); //22
          Console.WriteLine(DateTime.Now.ToString("yyyy")); //2022

          //Math Kütüphanesi
          Console.WriteLine(Math.Abs(-7)); //Mutlak değer alır 
          Console.WriteLine(Math.Sin(30));
          Console.WriteLine(Math.Cos(30));
          Console.WriteLine(Math.Tan(30)); 
          Console.WriteLine(Math.Ceiling(30.3)); //Bu sayıdan sonraki en küçük tamsayıyı getirir  31
          Console.WriteLine(Math.Round(30.3));   //Sayıya en yakın tam sayıyı getirir           30
          Console.WriteLine(Math.Floor(30.7));   //bu sayıdan küçük en büyük sayıyı getirir.   30
          
          Console.WriteLine(Math.Max(2,6));
          Console.WriteLine(Math.Min(2,6));

          Console.WriteLine(Math.Pow(2,3)); //üs alma işlemi 2^3=8
          Console.WriteLine(Math.Sqrt(9));  //karakök alma işlemi 3
          Console.WriteLine(Math.Log(9)); //9 un e tabanındaki log akrşılığını getirir.
          Console.WriteLine(Math.Exp(3)); //e^3 ü verir.
          Console.WriteLine(Math.Log10(10)); //10 sayısının log10 tabanındaki karşılığını verir.
        }
    }
}
