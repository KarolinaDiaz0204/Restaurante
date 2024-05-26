using Restaurante.Restaurante;
using Restaurante;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista de productos
        List<Producto> productos = new List<Producto>
        {
            new Quesillo("Quesillo sencillo", 10m),
            new Quesillo("Quesillo trenza sencilla", 15m),
            new Quesillo("Quesillo doble redondo", 20m),
            new Quesillo("Quesillo doble de trenza", 30m),
            new Quesillo("Quesillo Mixto", 25m),
            new Quesillo("Cosa de hornos", 25m),
            new Quesillo("Caramelos rayados", 20m),
            new Quesillo("Paletas redondas", 30m),
            new Quesillo("Tortilla", 3m),
            new Quesillo("Libra de trenza", 150m),
            new Quesillo("Libra de redondo", 160m),
            new Quesillo("Queso ahumados", 140m),
            new Bebida("Botella de Agua Pura de 1000ml", 30m),
            new Bebida("Gaseosa negra", 35m),
            new Bebida("Juguitos en caja", 25m),
            new Bebida("Raptor", 40m),
            new Fresco("Melón", 20m),
            new Fresco("Remolacha", 25m),
            new Fresco("Papaya", 20m),
            new Fresco("Limonada", 15m),
            new Fresco("Cacao", 25m),
            new Fresco("Tiste", 20m)
        };

        Console.WriteLine("Bienvenido a Quesillos Bone");
        Console.WriteLine("Nuestros productos y precios son los siguientes:");

        // Mostrar los productos y precios
        foreach (var producto in productos)
        {
            Console.WriteLine(producto.ToString());
        }

        List<Producto> orden = new List<Producto>();
        string entrada;
        bool pedirOtroProducto = true;

        // Pedir la orden al cliente
        while (pedirOtroProducto)
        {
            Console.WriteLine("Por favor, escriba el nombre del producto que desea pedir:");
            entrada = Console.ReadLine();

            Producto productoSeleccionado = productos.Find(p => p.Nombre.Equals(entrada, StringComparison.OrdinalIgnoreCase));

            if (productoSeleccionado != null)
            {
                orden.Add(productoSeleccionado);
                Console.WriteLine($"{productoSeleccionado.Nombre} ha sido añadido a su orden.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado. Por favor, intente de nuevo.");
            }

            Console.WriteLine("¿Desea pedir otro producto? (s/n)");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta != "s")
            {
                pedirOtroProducto = false;
            }
        }

        // Generar la factura
        Console.WriteLine("\nFactura:");
        decimal total = 0;
        foreach (var item in orden)
        {
            Console.WriteLine(item.ToString());
            total += item.Precio;
        }

        Console.WriteLine($"\nTotal a pagar: C${total}");
        Console.WriteLine("Gracias por su compra en Quesillos Bone. ¡Que tenga un buen día!");
    }
}