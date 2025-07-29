using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;

namespace ArquivoMorto.Pages
{
    public class homeModel : PageModel
    {
        public string codFilial { get; set; } 
        public string nome { get; set; }
        public string adm { get; set; }

        public IActionResult OnGet()
        {
            codFilial = HttpContext.Session.GetString("codFilial")!;
            nome = HttpContext.Session.GetString("nome")!;
            adm = HttpContext.Session.GetString("adm")!;

            if (codFilial.IsNullOrEmpty() || nome.IsNullOrEmpty() || adm.IsNullOrEmpty())
            {
                return RedirectToPage("/Index");
            }

            return Page();

        }


    }
}
