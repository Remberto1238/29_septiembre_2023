using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Datos del préstamo
        double prestamo = 3000; // Monto del préstamo
        int plazoMeses = 6; // Plazo en meses
        DateTime fechaInicio = DateTime.Today; // Fecha de inicio (hoy)

        // Calculamos la cuota mensual
        double cuotaMensual = prestamo / plazoMeses;

        // Mostramos la información
        Console.WriteLine("Detalles del préstamo:");
        Console.WriteLine($"Monto del préstamo: ${prestamo}");
        Console.WriteLine($"Plazo: {plazoMeses} meses");
        Console.WriteLine($"Cuota mensual: ${cuotaMensual}");

        // Calculamos las fechas de pago futuras
        for (int i = 1; i <= plazoMeses; i++)
        {
            DateTime fechaPago = fechaInicio.AddMonths(i);
            Console.WriteLine($"Cuota {i}: {fechaPago.ToString("dd/MM/yyyy")}, Monto: ${cuotaMensual}");
        }
    }
}


