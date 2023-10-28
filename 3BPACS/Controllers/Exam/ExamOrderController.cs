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
            return RedirectToAction("Index", new { id = examOrderDto.Id });
        }

        public IActionResult Details(int id)
        {
            return View();
        }

        public IActionResult Index()
        {
            // Implementar a lógica para obter detalhes do pedido de exame
            List<ExamOrderViewModel> examOrdersViewModel = _examOrderAppService.GetAllExamOrders();
            return View(examOrdersViewModel);
        }
    }
}
