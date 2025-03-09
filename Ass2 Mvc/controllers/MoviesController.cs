using Microsoft.AspNetCore.Mvc;

namespace Ass2_Mvc.controllers
{
    public class MoviesController:Controller
    {
        public  ContentResult Index() {
            ContentResult result = new ContentResult();
            result.Content = "Eman";
            result.ContentType = "text/html";
            return result;
        
        }

        public RedirectResult home()
        {
            RedirectResult result=new RedirectResult("http://localhost:19177/Movies/Index");
            return result;
        }


        //**return multiple type of request
        // public IActionResult  index() { }


        //*** Helper method
        //public IActionResult Eman()
        //{
        //    return Content("eman");
        //}
        //




        // order of Action Parameter


        public IActionResult GetMovie( int id,string name,Employee employee) //1)Html form 2)segment  3) Query string  4)file
        {
            return Content($"Movie with id:{id}::: with name{name}");
        }


    }
}
