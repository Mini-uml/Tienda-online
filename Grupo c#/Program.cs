/*using System;
using System.Collections.Generic;
using System.Linq;   

 }
}

public class CarritoDeCompras
{
    private List<Producto> productos = new List<Producto>();

    public void AgregarProducto(Producto producto)
    {
        productos.Add(producto);
    }

    public decimal CalcularTotal()
    {
        return productos.Sum(p => p.Precio);
    }

    public void MostrarCarrito()
    {
        Console.WriteLine("Productos en el carrito:");
        foreach (var producto in productos)
        {
            Console.WriteLine($"- {producto.Nombre} - ${producto.Precio}");
        }
        Console.WriteLine($"Total: ${CalcularTotal()}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        // Lista de productos disponibles en la tienda
        List<Producto> productos = new List<Producto>
        {
            new Producto(1, "Smartphone", 299.99m, 10),
            new Producto(2, "Laptop", 799.99m, 5),
            new Producto(3, "Tablet", 199.99m, 7),
            new Producto(4, "Auriculares", 49.99m, 20)
        };

        CarritoDeCompras carrito = new CarritoDeCompras();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nBienvenido a la tienda online de aparatos electrónicos");
            Console.WriteLine("1. Listar productos");
            Console.WriteLine("2. Agregar producto al carrito");
            Console.WriteLine("3. Ver carrito");
            Console.WriteLine("4. Salir");
            Console.Write("Selecciona una opción: ");
            
            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nLista de productos disponibles:");
                    foreach (var producto in productos)
                    {
                        producto.MostrarInformacion();
                    }
                    break;

                case 2:
                    Console.Write("\nIngresa el ID del producto para agregar al carrito: ");
                    int idProducto;
                    if (!int.TryParse(Console.ReadLine(), out idProducto))
                    {
                        Console.WriteLine("Por favor, ingresa un número válido.");
                        continue;
                    }

                    Producto productoSeleccionado = productos.Find(p => p.Id == idProducto);
                    if (productoSeleccionado != null)
                    {
                        if (productoSeleccionado.Stock > 0)
                        {
                            carrito.AgregarProducto(productoSeleccionado);
                            productoSeleccionado.Stock--; // Reduce el stock en 1
                            Console.WriteLine($"{productoSeleccionado.Nombre} agregado al carrito.");
                        }
                        else
                        {
                            Console.WriteLine("Lo sentimos, no hay stock disponible de este producto.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Producto no encontrado.");
                    }
                    break;

                case 3:
                    Console.WriteLine("\nCarrito de compras:");
                    carrito.MostrarCarrito();
                    break;

                case 4:
                    continuar = false;
                    Console.WriteLine("Gracias por visitar la tienda. ¡Hasta luego!");
                    break;

                default:
                    Console.WriteLine("Opción no válida, por favor intenta nuevamente.");
                    break;
            }
        }
    }
}*/



