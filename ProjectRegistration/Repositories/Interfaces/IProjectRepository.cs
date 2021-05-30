using System;
using System.Threading.Tasks;
using ProjectRegistration.Models;

namespace ProjectRegistration.Repositories.Interfaces
{
    public interface IProjectRepository
    {
        Task<Project> GetProjectByEmail(string email);
        Task<Project> CreateProject(Project project);
    }
}
