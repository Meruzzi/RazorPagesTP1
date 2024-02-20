using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesTP1.Model;

namespace RazorPagesTP1.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Model.Usuario Usuario { get; set; }

        public string Saudacoes {  get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!string.IsNullOrEmpty(Usuario.Nome))
            {
                Saudacoes = $"Seja bem vindo {Usuario.Nome}!";
            } else
            {
                Saudacoes = "Insira um nome.";
            }
        }
    }
}
