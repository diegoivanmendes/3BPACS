using Microsoft.AspNetCore.Mvc;
using _3BPACS.Application;
using _3BPACS.Common.ViewModels;

namespace _3BPACS.Controllers.Exame
{
    public class ExamOrderController : Controller
    {

        private readonly ExamOrderAppService _examOrderAppService;

        public ExamOrderController(ExamOrderAppService examOrderAppService)
        {
            _examOrderAppService = examOrderAppService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ExamOrderViewModel examOrderViewModel)
        {
            var examOrderDto = _examOrderAppService.CreateExamOrder(examOrderViewModel);
            return RedirectToAction("Details", new { id = examOrderDto.Id });
        }

        public IActionResult Details(int id)
        {
            // Implementar a lógica para obter detalhes do pedido de exame
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
