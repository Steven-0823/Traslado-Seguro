using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Traslado_Seguro.Data;
using Traslado_Seguro.Models;

namespace Traslado_Seguro.Pages.ServicioTransporte
{
    public class IndexModel : PageModel
    {
		private readonly trasladoSeguroContext _context;

		public IndexModel(trasladoSeguroContext context)
		{
			_context = context;
		}
		public IList<SevicioTransporte> SevicioTransportes { get; set; } = default!;
		public async Task OnGetAsync()
		{
			if (_context.SevicioTransportes != null)
			{
				SevicioTransportes = await _context.SevicioTransportes.ToListAsync();

			}
		}
	}
}
