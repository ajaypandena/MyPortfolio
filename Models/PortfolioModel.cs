using System.Collections.Generic;

namespace AjayPandenaPortfolio.Models
{
    public class PortfolioModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public List<string> Skills { get; set; }
        public List<ProjectModel> Projects { get; set; }
        public long MobileNumber { get; set; }

        public string Linkedin {  get; set; }
        public string GitHub {  get; set; }
    }

    public class ProjectModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}
