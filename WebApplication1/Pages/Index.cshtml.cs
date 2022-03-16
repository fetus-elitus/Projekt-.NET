using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }
        [BindProperty(SupportsGet =true)]
        public string Name { get; set; }

        private IndexModel()
        {

        }
        public IndexModel(ILogger<IndexModel> logger):this()
        {
            _logger = logger;
            FizzBuzz = new FizzBuzz();
        }

        public void OnGet()
        {
            /*if(Name is null)
            {
                Name = "Byku";
            }*/
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return RedirectToPage("./Privacy");
        }

    }
}