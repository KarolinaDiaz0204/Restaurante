using System;

namespace Restaurante
{

    namespace Restaurante
    {
        public abstract class Producto
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }

            public Producto(string nombre, decimal precio)
            {
                Nombre = nombre;
                Precio = precio;
            }

            public override string ToString()
            {
                return $"{Nombre}: C${Precio}";
            }
        }
    }

}
