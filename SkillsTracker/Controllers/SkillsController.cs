using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            string html = "<h1> Skills Tracker </h1>" +
                "<h2> Coding skills to learn: </h2>" +
                "<ol>" +
                "<li> C# </li>" +
                "<li> JavaScript </li>" +
                "<li> Python </li>" +
                "</ol>";

            return Content(html, "text/html");
        }

        [HttpGet]
       public IActionResult Form()
        {
            string html = "<form method='post' action='/Form'>" +
                                "<label for= 'start'> Start date:</label>" +
                                    "<input type = 'date' id = 'start' name = 'date' value = '2020-03-29'  min = '2020-01-01' max = '2021-12-31'>" +
                                " <br> <label for= 'C'> C#:</label>" +
                                     "<select name = 'cValue'>  " +
                                             "<option value = ': Learning Basics' > Learning Basics </option> " +
                                             "<option value = ': Getting a decent grasp' > Getting a decent grasp </option>" +
                                             "<option value = ': Amazing at this stuff' > Amazing at this stuff </option>" +
                                             "<option value = ': As good as Moe' > As good as Moe </option>" +                                             
                                     "</select>" +
                                     " <br> <label for= 'javaScript'> JavaScript:</label>" +
                                     "<select name = 'jValue'>  " +
                                            "<option value = ': Learning Basics' > Learning Basics </option> " +
                                             "<option value = ': Getting a decent grasp' > Getting a decent grasp </option>" +
                                             "<option value = ': Amazing at this stuff' > Amazing at this stuff </option>" +
                                             "<option value = ': As good as Moe' > As good as Moe </option>" +
                                     "</select>" +
                                     "<br> <label for= 'python'> Python:</label>" +
                                     "<select name = 'pValue'>  " +
                                             "<option value = ': Learning Basics' > Learning Basics </option> " +
                                             "<option value = ': Getting a decent grasp' > Getting a decent grasp </option>" +
                                             "<option value = ': Amazing at this stuff' > Amazing at this stuff </option>" +
                                             "<option value = ': As good as Moe' > As good as Moe </option>" +
                                     "</select>" +
                                 "<input type='submit' value='Submit'/>" +
                            "</form>";

            return Content(html, "text/html");
        }

        [HttpPost("/Form")]
        [HttpGet("/Result")]
        [HttpGet("/Results")]
        public IActionResult Result(string date, string cValue, string jValue, string pValue)
            {
              string html = "<h1>" + date + "</h1>" +
                    "<h2>  </h2>" +
                    "<ol>" +
                    "<li> C#" + cValue + " </li>" +
                    "<li> JavaScript" + jValue + "</li>" +
                    "<li> Python" + pValue + "</li>" +
                    "</ol>";

                return Content(html, "text/html");
            }

        
    }
}
