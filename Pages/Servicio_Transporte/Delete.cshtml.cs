using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Traslado_Seguro.Data;
using Traslado_Seguro.Models;

namespace Traslado_Seguro.Pages.Servicio_Transporte
{
    public class DeleteModel : PageModel
    {

		private readonly trasladoSeguroContext _context;
		public DeleteModel(trasladoSeguroContext context)
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
			var sevicioTransporte = await _context.SevicioTransportes.FirstOrDefaultAsync(m => m.Id == id);

			if (sevicioTransporte == null)
			{
				return NotFound();
			}
			else
			{
				ServicioTransporte = sevicioTransporte;
			}
			return Page();
		}
		public async Task<IActionResult> OnPostAsync(int? id)
		{
			if (id == null || _context.SevicioTransportes == null)
			{
				return NotFound();
			}
			var sevicioTransporte = await _context.SevicioTransportes.FindAsync(id);

			if (sevicioTransporte != null)
			{
				ServicioTransporte = sevicioTransporte;
				_context.SevicioTransportes.Remove(ServicioTransporte);
				await _context.SaveChangesAsync();

			}
			return RedirectToPage("./Index");
		}
	}
}
