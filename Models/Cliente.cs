namespace Traslado_Seguro.Models
{
	public class Cliente
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Telefono { get; set; }
		public string Direccion { get; set; }
		public string ServicioTran { get; set; }

		public ICollection<ServicioTransporte>? ServicioTransportes { get; set; } = default!;
	}
}
