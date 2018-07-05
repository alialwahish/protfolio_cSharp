using Microsoft.AspNetCore.Mvc;

namespace firstASP.Controllers
{
    public class controller : Controller
    {


        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "This is my Index";
        }
            
        [HttpGet]
        [Route("projects")]
        public string projects()
        {
            return "These are my projects";
        }


        [HttpGet]
        [Route("contact")]
        public string contact()
        {
            return "This is my Contact";
        }
    }


}