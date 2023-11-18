using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Traslado_Seguro.Data;
using Traslado_Seguro.Models;

namespace Traslado_Seguro.Pages.Clientes
{
    public class DeleteModel : PageModel
    {
		private readonly trasladoSeguroContext _context;
		public DeleteModel(trasladoSeguroContext context)
		{
			_context = context;
		}
		[BindProperty]
		public Cliente Cliente { get; set; } = default!;
		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null || _context.Clientes == null)
			{
				return NotFound();

			}
			var cliente = await _context.Clientes.FirstOrDefaultAsync(m => m.Id == id);

			if (cliente == null)
			{
				return NotFound();
			}
			else
			{
				Cliente = cliente;
			}
			return Page();
		}
		public async Task<IActionResult> OnPostAsync(int? id)
		{
			if (id == null || _context.Clientes == null)
			{
				return NotFound();
			}
			var cliente = await _context.Clientes.FindAsync(id);

			if (cliente != null)
			{
				Cliente = cliente;
				_context.Clientes.Remove(Cliente);
				await _context.SaveChangesAsync();

			}
			return RedirectToPage("./Index");
		}
	}
}
