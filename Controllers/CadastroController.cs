using Microsoft.AspNetCore.Mvc;



namespace Controllers
{

    //Para trazer como URL a página de cadastro
    [ Route("Cadastro") ]
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();

            //enviado para a View Cadastro
        }
    }
}