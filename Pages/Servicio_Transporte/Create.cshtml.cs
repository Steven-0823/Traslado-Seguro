using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Traslado_Seguro.Data;
using Traslado_Seguro.Models;

namespace Traslado_Seguro.Pages.Servicio_Transporte
{
    public class CreateModel : PageModel
    {
		private readonly trasladoSeguroContext _context;
		public CreateModel(trasladoSeguroContext context)
		{
			_context = context;
		}
		public IActionResult OnGet()
		{
			return Page();
		}

		[BindProperty]
		public ServicioTransporte ServicioTransportes { get; set; } = default!;

		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid || _context.SevicioTransportes == null || ServicioTransportes == null)
			{
				return Page();

			}
			_context.SevicioTransportes.Add(ServicioTransportes);
			await _context.SaveChangesAsync();
			return RedirectToPage("./Index");
		}
	}
}
