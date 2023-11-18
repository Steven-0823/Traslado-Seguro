namespace Traslado_Seguro.Models
{
	public class Cliente
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Telefono { get; set; }
		public string Direccion { get; set; }
		public string ServicioTran { get; set; }

		public int ServicioTranId { get; set; }
		public SevicioTransporte SevicioTransporte { get; set; }
	}
}
