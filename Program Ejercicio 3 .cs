using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Por favor, ingresa tu fecha de nacimiento (dd/mm/yyyy): ");
        string fechaNacimientoStr = Console.ReadLine();

        
        DateTime fechaNacimiento;
        if (!DateTime.TryParseExact(fechaNacimientoStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaNacimiento))
        {
            Console.WriteLine("La fecha ingresada no es válida.");
            return;
        }

        
        DateTime fechaActual = DateTime.Today;

        
        DateTime proximoCumpleaños = new DateTime(fechaActual.Year, fechaNacimiento.Month, fechaNacimiento.Day);
        if (proximoCumpleaños < fechaActual)
        {
            proximoCumpleaños = proximoCumpleaños.AddYears(1);
        }

        int diasRestantes = (int)(proximoCumpleaños - fechaActual).TotalDays;

        
        Console.WriteLine("Tu fecha de nacimiento es: " + fechaNacimiento.ToString("dd/MM/yyyy"));
        Console.WriteLine("Días restantes para tu próximo cumpleaños: " + diasRestantes);
    }
}