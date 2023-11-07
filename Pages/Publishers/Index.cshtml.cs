using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lazar_Jusztina_Laborator2.Data;
using Lazar_Jusztina_Laborator2.Models;

namespace Lazar_Jusztina_Laborator2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Lazar_Jusztina_Laborator2.Data.Lazar_Jusztina_Laborator2Context _context;

        public IndexModel(Lazar_Jusztina_Laborator2.Data.Lazar_Jusztina_Laborator2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
