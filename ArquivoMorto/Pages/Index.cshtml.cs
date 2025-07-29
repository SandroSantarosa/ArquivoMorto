using ArquivoMorto.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;

namespace ArquivoMorto.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _context;

        [BindProperty]
        public string Usuario { get; set; } = string.Empty;

        [BindProperty]
        public string Senha { get; set; } = string.Empty;

        public string Msg { get; set;}


        public IndexModel(ApplicationDBContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            var login = _context.Usuario.Where(u => u.Login.Equals(Usuario)).ToList();
            var user = login[0].Login;
            var pass = login[0].Senha;
            var filialId = login[0].FilialId;
            var adm = login[0].PerfilId;
            var nome = login[0].Nome;

            if (!Usuario.IsNullOrEmpty() && !Senha.IsNullOrEmpty() &&
                Usuario.ToUpper().Equals(user.ToUpper()) && Senha.Equals(pass))
            {
                HttpContext.Session.SetString("codFilial", filialId.ToString());
                HttpContext.Session.SetString("nome", nome);
                HttpContext.Session.SetString("adm", adm.ToString());

                return RedirectToPage("/Home");
            }
            else
            {
                Msg = "Login falhou!";
                return Page();
            }
        }

    }

}
