using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectRegistration.DTOs;
using ProjectRegistration.Models;
using ProjectRegistration.Repositories.Interfaces;
using ProjectRegistration.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectRegistration.Controllers
{
    public class StartController : Controller
    {
        private UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly IProjectRepository _projects;

        public StartController(UserManager<User> userManager, IMapper mapper, IProjectRepository projects)
        {
            _userManager = userManager;
            _mapper = mapper;
            _projects = projects;
        }


        [Authorize]
        public async Task<IActionResult> Index()
        {
            User user = await _userManager.GetUserAsync(HttpContext.User);
            return View(user);
        }


        [Authorize]
        public IActionResult Project()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Project(ProjectDTO projectDTO)
        {
            User user = await _userManager.GetUserAsync(HttpContext.User);

            var existingProject = _projects.GetProjectByEmail(user.Email);

            if (existingProject == null)
            {
                var project = _mapper.Map<Project>(projectDTO);

                project.Email = user.Email;

                ApiService apiService = new ApiService();
                string generatedKey = user.Email + project.Name + project.CreationDate.ToString();
                project.Apikey = apiService.GetHash(generatedKey);

                await _projects.CreateProject(project);
                return View();
            } else
            {
                return Content("You already have a project!");
            }
        }


        [Authorize]
        public async Task<IActionResult> Apikey()
        {
            User user = await _userManager.GetUserAsync(HttpContext.User);
            var project = await _projects.GetProjectByEmail(user.Email);
            if (project == null)
            {
                return View((object)"You have not created a project.");
            } else {
                string api = project.Apikey;
                return View((object)api);
            }
        }
    }
}
