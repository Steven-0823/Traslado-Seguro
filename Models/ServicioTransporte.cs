using System.ComponentModel.DataAnnotations.Schema;

namespace Traslado_Seguro.Models
{
	public class ServicioTransporte
	{
		public string id { get; set; }
		public string conductor { get; set; }
		public string fecha { get; set; }
		public string Origen { get; set; }

		public string Destino { get; set; }
		public string? Descripcion { get; set; }

		[Column(TypeName = "decimal (6,2)")]
		public int Costo { get; set; }
		public int ClienteId { get; set; }
		public Cliente Cliente { get; set; }

	}
}