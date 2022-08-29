using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnEFCodeFirst_Demo2.Entities;
namespace HandsOnEFCodeFirst_Demo2
{
    internal class ProjectRepository
    {
        private readonly SMS516DBContext db;
        public ProjectRepository()
        {
            this.db=new SMS516DBContext();
        }
        public void AddProject(Project project)
        {
            db.Projects.Add(project);
            db.SaveChanges();
        }
        public List<Project> GetProjects()
        {
            return db.Projects.ToList();
        }
    }
    class Test_Project
    {
        static void Main()
        {
            ProjectRepository repository=new ProjectRepository();
            repository.AddProject(new Project() { ProjectId = "P0001", ProjectName = "SMS" });
            foreach(var item in repository.GetProjects())
            {
                Console.WriteLine("{0} {1}", item.ProjectId, item.ProjectName);
            }
        }
    }
}
