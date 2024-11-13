using System;

public class Mercancia
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }

    // Constructor para inicializar la mercancía
    public Mercancia(int id, string nombre, decimal precio, int stock)
    {
        Id = id;
        Nombre = nombre;
        Precio = precio;
        Stock = stock;
    }

    // Método para mostrar la información de la mercancía
    public void MostrarInformacion()
    {
        Console.WriteLine($"{Nombre} - Precio: RD${Precio}, Stock: {Stock}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        // Crear un arreglo de mercancías en pesos dominicanos
        Mercancia[] mercancias = new Mercancia[10];
        
        // Inicializar las mercancías en el arreglo con los precios en DOP
        mercancias[0] = new Mercancia(1, "Iphone 12 Pro Max", 14500m, 10);
        mercancias[1] = new Mercancia(3, "Tablet", 12900.99m, 7);
        mercancias[2] = new Mercancia(4, "Auriculares", 2500.99m, 20);
        mercancias[3] = new Mercancia(2, "Laptop Hp", 45899.99m, 5);
        mercancias[4] = new Mercancia(5, "Smartwatch", 10000m, 15);
        mercancias[5] = new Mercancia(6, "Teclado Mecánico", 5399.99m, 8);
        mercancias[6] = new Mercancia(7, "Monitor 24 pulgadas", 13795.99m, 6);
        mercancias[7] = new Mercancia(8, "Cámara Web HD", 4350.99m, 10);
        mercancias[8] = new Mercancia(9, "Cargador Inalámbrico", 1199.99m, 5);
        mercancias[9] = new Mercancia(10, "Disco Duro Externo 1TB", 4299.99m, 5);

        // Mostrar todos las mercancías disponibles con precios en DOP
        Console.WriteLine("Lista de mercancías disponibles:");
        for (int i = 0; i < mercancias.Length; i++)
        {
            mercancias[i].MostrarInformacion();
        }
    }
}

