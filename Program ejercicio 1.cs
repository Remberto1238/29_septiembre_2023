using System;

class Program
{
    static void Main()
    {
        int[] years = new int[] { 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020 };

        foreach (int year in years)
        {
            if (EsBisiesto(year))
            {
                Console.WriteLine($"{year} es un año bisiesto");
            }
            else
            {
                Console.WriteLine($"{year} no es un año bisiesto");
            }
        }
    }

    static bool EsBisiesto(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}