namespace Recepcion.Models
{
  public class Ingreso
  {
    public int Id { get; set; }
    public int ClienteDni { get; set; }
    public string ClienteNombre { get; set; }
    public int RoomNumber { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
  }
}
