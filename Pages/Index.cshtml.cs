using ExamenMITE_Empresa_Lider.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamenMITE_Empresa_Lider.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
       
        [BindProperty]
        public Triangulo Triangulo { get; set; } = new Triangulo();

        public string Resultado { get; set; }

        public void OnPost()
        {
            double area = Triangulo.CalcularArea();

            if (double.IsNaN(area))
            {
                Resultado = "Los lados ingresados no forman un triángulo válido.";
            }
            else
            {
                Resultado = $"Perímetro: {Triangulo.CalcularPerimetro():F2} - Área: {area:F2}";
            }
        }
        public void OnGet()
        {

        }
    }
}
