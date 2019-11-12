using System.Collections.Generic;
using System.Threading.Tasks;
using App.Aplication.Client;
using App.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.Pages
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _dbContext { get; set; }
        public IndexModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [BindProperty]
        public App.Aplication.Client.ClientViewModel Client { get; set; }
        // [BindProperty]
        public IEnumerable<App.Aplication.Client.ClientViewModel> Clients { get; set; }


        public async Task<IActionResult> OnPost()
        {
            await new CreateClient(_dbContext).Do(Client);
            return RedirectToPage("Index");
        }







        /*
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        */
        public void OnGet()
        {
            Clients = new GetClients(_dbContext).Do();

        }
    }
}
