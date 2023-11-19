using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lazar_Jusztina_Laborator2.Data;
using Lazar_Jusztina_Laborator2.Models;
using Lazar_Jusztina_Laborator2.Models.ViewModels;

namespace Lazar_Jusztina_Laborator2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Lazar_Jusztina_Laborator2.Data.Lazar_Jusztina_Laborator2Context _context;

        public IndexModel(Lazar_Jusztina_Laborator2.Data.Lazar_Jusztina_Laborator2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get; set; } = default!;
        public PublisherIndexData PublisherData { get; set; }
        public int PublisherID { get; set; }
        public int BookID { get; set; }
        public async Task OnGetAsync(int? id, int? bookID)
        {
            PublisherData = new PublisherIndexData();
            PublisherData.Publishers = await _context.Publisher
           .Include(i => i.Books)
           .ThenInclude(c => c.Author)
           .OrderBy(i => i.PublisherName)
           .ToListAsync();
            if (id != null)
            {
               PublisherID = id.Value _
               Publisher publisher = PublisherData.Publishers
               .Where(i => i.ID == id.Value).Single();
                PublisherData.Books = publisher.books;
            }
        }

        }
}
