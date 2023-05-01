using System.ComponentModel.DataAnnotations;

namespace Recepcion.Models
{
	public class Ingreso
	{
		public int Id { get; set; }

		[Display(Name = "DNI")]
		[Required]
		[RegularExpression(@"^\d{7,9}$", ErrorMessage = "El DNI debe tener entre 7 y 8 dígitos")]
		public int ClienteDni { get; set; }

		[Display(Name = "Nombre del cliente")]
		[Required]
		[StringLength(255)]
		public string ClienteNombre { get; set; }


		[Display(Name = "Número de habitación")]
		[Required]
		public int RoomNumber { get; set; }

		[Display(Name = "Fecha de arribo")]
		[Required]
		public DateTime CheckInDate { get; set; }

		[Display(Name = "Fecha de partida")]
		[Required]
		public DateTime CheckOutDate { get; set; }
	}
}
