

var papitas = new Venta(12);

class Venta
{
    // Por convencion las Total con amyuscula
    public decimal Total { get; set; }


    // Los CONSTRUCTORES tiene el mismo nombre que la clase
    public Venta ( decimal valorDeVenta )
    {
        this.Total = valorDeVenta;
    }  
}

