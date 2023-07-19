using DesignPatternChainOfResponsibility.ChainOfResponsibility;
using DesignPatternChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternChainOfResponsibility.Controllers
{
    public class DefaultController : DemoController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasurer = new Treasurer();
            Employee managerAsistant = new ManagerAsistant();
            Employee manager = new Manager();
            Employee regionManager = new RegionManager();

            treasurer.SetNextApprover(managerAsistant);
            managerAsistant.SetNextApprover(manager);
            manager.SetNextApprover(regionManager);

            treasurer.ProcessRequest(model);
            return View();
        }
    }
}
