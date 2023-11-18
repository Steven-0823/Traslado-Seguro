using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Traslado_Seguro.Data;
using Traslado_Seguro.Models;

namespace Traslado_Seguro.Pages.Clientes
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
		public Cliente Cliente { get; set; } = default!;
		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid || _context.Clientes == null || Cliente == null)
			{
				return Page();

			}
			_context.Clientes.Add(Cliente);
			await _context.SaveChangesAsync();
			return RedirectToPage("./Index");
		}
	}
}
