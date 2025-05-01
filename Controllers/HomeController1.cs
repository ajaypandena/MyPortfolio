using Microsoft.AspNetCore.Mvc;
using AjayPandenaPortfolio.Models;
using System.Collections.Generic;

namespace AjayPandenaPortfolio.Controllers
{
    public class AjayPandenaPortfolioController : Controller
    {
        public IActionResult Index()
        {
            var model = new PortfolioModel
            {
                Name = "Ajay",
                Surname = "Pandena",
                Bio = "I am a .NET (C#) full-stack developer passionate about building web apps.",
                Email = "ajaypandena799@gmail.com", 
                MobileNumber = 8500664243,
                Skills = new List<string> { "C#","ASP.NET MVC Core","Entity Framework","SQL","JavaScript" },
                GitHub = "https://github.com/ajaypandena",
                Linkedin = "https://www.linkedin.com/in/ajay-pandena-907013302/",
                Projects = new List<ProjectModel>
                {
                    new ProjectModel
                    {
                        Title = "Task Monitor",
                        Description = "A task manager built in ASP.NET.",
                        Url = "https://github.com/your/project1"
                    },
                    new ProjectModel
                    {
                        Title = "Portfolio",
                        Description = "Portfolio website.",
                        Url = "https://github.com/your/project2"
                    },
                    new ProjectModel
                    {
                        Title = "More To Come",
                        Description = "Be With Patience"
                    }
                }
            };

            return View(model);
        }
    }
}
