namespace Farmacia.Models;

public class Promocion
{
    public int id { get; set; }
    public string nombre { get; set; } = "";
    public string descripcion { get; set; } = "";
    public double descuento { get; set; }
    public bool activa { get; set; }
}