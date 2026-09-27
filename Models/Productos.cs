namespace Farmacia.Models;

public class Producto
{
    public int id { get; set; }
    public string codigo { get; set; } = "";
    public string nombre { get; set; } = "";
    public string categoria { get; set; } = "";
    public string principioActivo { get; set; } = "";
    public string concentracion { get; set; } = "";
    public string presentacion { get; set; } = "";
    public string laboratorio { get; set; } = "";
    public double precio { get; set; }
    public int stock { get; set; }
    public string fechaVencimiento { get; set; } = "";
    public double descuento { get; set; }
    public string imagen { get; set; } = "";
    public string descripcion { get; set; } = "";
}