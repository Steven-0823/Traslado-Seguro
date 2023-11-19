using System.ComponentModel.DataAnnotations.Schema;

namespace Traslado_Seguro.Models
{
	public class ServicioTransporte
	{
		public string id { get; set; }
		public string Conductor { get; set; }
		public string Fecha { get; set; }
		public string Origen { get; set; }

		public string Destino { get; set; }
		public string? Descripcion { get; set; }

		[Column(TypeName = "decimal (6,2)")]
		public decimal Costo { get; set; }
		public int ClienteId { get; set; }
		public Cliente Cliente { get; set; } = default!;

	}
}