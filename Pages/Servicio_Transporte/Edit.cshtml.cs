using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Traslado_Seguro.Data;
using Traslado_Seguro.Models;

namespace Traslado_Seguro.Pages.Servicio_Transporte
{
    public class EditModel : PageModel
    {
		private readonly trasladoSeguroContext _context;
		public EditModel(trasladoSeguroContext context)
		{
			_context = context;
		}
		[BindProperty]
		public ServicioTransporte ServicioTransporte { get; set; } = default!;
		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null || _context.SevicioTransportes == null)
			{
				return NotFound();
			}
			var servicotrasporte = await _context.SevicioTransportes.FirstOrDefaultAsync(m => m.id == id);
			if (servicotrasporte == null)
			{
				return NotFound();
			}
			ServicioTransporte = servicotrasporte;
			return Page();

		}
		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}
			_context.Attach(ServicioTransporte).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!ServicioTransporteExists(ServicioTransporte.id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}

			}
			return RedirectToPage("./Index");
		}
		private bool ServicioTransporteExists(int id)
		{
			return (_context.SevicioTransportes?.Any(e => e.id == id)).GetValueOrDefault();
		}
	}
}
