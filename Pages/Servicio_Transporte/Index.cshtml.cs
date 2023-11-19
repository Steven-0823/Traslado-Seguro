using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Traslado_Seguro.Data;
using Traslado_Seguro.Models;

namespace Traslado_Seguro.Pages.Servicio_Transporte
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly trasladoSeguroContext _context;
        public IndexModel(trasladoSeguroContext context)
        {
            _context = context;
        }
        public IList<ServicioTransporte> ServicioTransportes { get; set; } = default!;
        public async Task OnGetAsync()
        {
            if (_context.SevicioTransportes != null)
            {
                ServicioTransportes = await _context.SevicioTransportes.ToListAsync();

            }
        }
    }
}
