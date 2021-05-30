using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectRegistration.Models;
using ProjectRegistration.Repositories.Interfaces;

namespace ProjectRegistration.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationContext _context;

        public ProjectRepository(ApplicationContext context)
        {
            _context = context;
        }


        public async Task<Project> CreateProject(Project project)
        {
            await _context.Projects.AddAsync(project);
            await _context.SaveChangesAsync();
            return project;
        }


        public async Task<Project> GetProjectByEmail(string email)
        {
            return await _context.Projects.FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}
