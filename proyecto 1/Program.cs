using System;
using System.ComponentModel.Design;
class ventas
{
    static void Main()
    {

        Console.WriteLine("bienvenido al sistema de ventas del Ranchon");
        Console.WriteLine("Ingresa tu Nombre en nuestro sistema");
        string Nombre = Console.ReadLine();
         Console.WriteLine("Ingresa tu Edad en nuestro sistema");
        int Edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("1.Carne");
        Console.WriteLine("2.Lacteos");
        Console.WriteLine("3.Refrescos");
        string categoria = Console.ReadLine();

        if (categoria == "1")
        {

            Console.WriteLine(" En nuestras ventas tenemos los siguientes productos");
            Console.WriteLine("1.Carne porcina");
            Console.WriteLine("2.Carne de pollo");
            Console.WriteLine("3.Longaniza");
            Console.WriteLine("4.Carne de res");
            Console.WriteLine("5.Chuleta.");
            string Carne = Console.ReadLine();

            if (Carne == "1")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de carne porcina a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 25;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal1 * 0.30;
                        double total_D = subtotal1 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    
                    
                    Console.ReadKey();

                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de carne porcina a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 31;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal1 * 0.30;
                        double total_D = subtotal1 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de carne porcina a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 40;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal1 * 0.30;
                        double total_D = subtotal1 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }

            }
            if (Carne == "2")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Carne de pollo a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 30;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal1 * 0.30;
                        double total_D = subtotal1 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Carne de pollo a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 37;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal1 * 0.30;
                        double total_D = subtotal1 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Carne de pollo a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 48;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal1 * 0.30;
                        double total_D = subtotal1 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();

                }
            }
            if (Carne == "3")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Longaniza a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 35;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal1 * 0.30;
                        double total_D = subtotal1 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Longaniza a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 43;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal1 * 0.30;
                        double total_D = subtotal1 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Longaniza a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 55;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal1 * 0.30;
                        double total_D = subtotal1 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
            }
            if (Carne == "4")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de carne de res a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 40;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal1 * 0.30;
                        double total_D = subtotal1 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de carne de res a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 50;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal1 * 0.30;
                        double total_D = subtotal1 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de carne de res a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 65;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal1 * 0.30;
                        double total_D = subtotal1 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();

                }
            }
            if (Carne == "5")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de chuleta a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 90;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal1 * 0.30;
                        double total_D = subtotal1 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de chuleta a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 112;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal1 * 0.30;
                        double total_D = subtotal1 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de chuleta a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 145;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal1 * 0.30;
                        double total_D = subtotal1 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
            }
        }
        else if (categoria == "2")
        {
            Console.WriteLine("En nuestras ventas tenemos los siguientes productos");
            Console.WriteLine("1.Mantequilla");
            Console.WriteLine("2.Queso");
            Console.WriteLine("3.Mortadela");
            Console.WriteLine("4.Quesillo");
            Console.WriteLine("5.Copetines.");
            string lacteos = Console.ReadLine();
            if (lacteos == "1")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Mantequilla  a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 17;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal2 * 0.30;
                        double total_D = subtotal2 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Mantequilla a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 21;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal2 * 0.30;
                        double total_D = subtotal2 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Mantequilla a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 27;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal2 * 0.30;
                        double total_D = subtotal2 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }

            }
            if (lacteos == "2")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Queso  a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 22;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal2 * 0.30;
                        double total_D = subtotal2 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Queso a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 27;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal2 * 0.30;
                        double total_D = subtotal2 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Queso a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 35;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal2 * 0.30;
                        double total_D = subtotal2 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
            }
            if (lacteos == "3")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Mortadela  a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 16;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal2 * 0.30;
                        double total_D = subtotal2 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Mortadela a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 20;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal2 * 0.30;
                        double total_D = subtotal2 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Mortadela a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 26;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal2 * 0.30;
                        double total_D = subtotal2 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }

            }
            if (lacteos == "4")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Queso  a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 16;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal2 * 0.30;
                        double total_D = subtotal2 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Queso a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 20;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal2 * 0.30;
                        double total_D = subtotal2 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Queso a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 26;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal2 * 0.30;
                        double total_D = subtotal2 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }

            }
            if (lacteos == "5")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Copetines  a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 16;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal2 * 0.30;
                        double total_D = subtotal2 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Copetines a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 20;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal2 * 0.30;
                        double total_D = subtotal2 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Copetines a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 26;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal2 * 0.30;
                        double total_D = subtotal2 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }

            }
        }
        else if (categoria == "3")
        {
            Console.WriteLine("En nuestras ventas tenemos los siguientes productos");
            Console.WriteLine("1.Refresco Banana");
            Console.WriteLine("2.Refresco Uva");
            Console.WriteLine("3.Refresco Coca Cola");
            Console.WriteLine("4.Refresco sprite");
            Console.WriteLine("5.Refresco Fanta");
            string Refresco = Console.ReadLine();
            if (Refresco == "1")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Refresco Banana a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 20;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal3 * 0.30;
                        double total_D = subtotal3 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Refresco Banana a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 25;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal3 * 0.30;
                        double total_D = subtotal3 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Refresco Banana a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 32;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal3 * 0.30;
                        double total_D = subtotal3 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }

            }
            if (Refresco == "2")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Refresco Uva a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 19;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal3 * 0.30;
                        double total_D = subtotal3 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Refresco Uva a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 23;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal3 * 0.30;
                        double total_D = subtotal3 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Refresco Uva a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 30;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal3 * 0.30;
                        double total_D = subtotal3 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }

            }
            if (Refresco == "3")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Refresco Coca Cola a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 19;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal3 * 0.30;
                        double total_D = subtotal3 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Refresco Coca Cola a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 23;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal3 * 0.30;
                        double total_D = subtotal3 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Refresco Coca Cola a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 30;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal3 * 0.30;
                        double total_D = subtotal3 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }

            }
            if (Refresco == "4")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Refresco sprite a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 20;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal3 * 0.30;
                        double total_D = subtotal3 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Refresco sprite a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 25;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal3 * 0.30;
                        double total_D = subtotal3 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Refresco sprite a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 32;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal3 * 0.30;
                        double total_D = subtotal3 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
            }
            if (Refresco == "5")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Refresco Fanta a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 20;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal3 * 0.30;
                        double total_D = subtotal3 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Refresco Fanta a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 25;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal3 * 0.30;
                        double total_D = subtotal3 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Refresco Fanta a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 32;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {

                        double Descuento = subtotal3 * 0.30;
                        double total_D = subtotal3 - Descuento;
                        Console.WriteLine($"subtotal + descuento de tercera edad: {total_D:F2}");
                    }
                    Console.ReadKey();
                }

            }
        }

    }
}








    

            

    



           
   

