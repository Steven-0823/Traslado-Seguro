using Microsoft.EntityFrameworkCore;
using Traslado_Seguro.Models;

namespace Traslado_Seguro.Data
{
	public class trasladoSeguroContext : DbContext
	{
		public trasladoSeguroContext(DbContextOptions options) : base(options)
		{
		}
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<ServicioTransporte> SevicioTransportes { get; set; }
	}
}
