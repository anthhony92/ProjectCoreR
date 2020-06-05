using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectCore.Logica.Models.ViewModel;

namespace ProjectCore.Controllers
{
    public class TasksController : Controller
    {
        

        public async Task<IActionResult> Index()
        {
           
            /*

            IdentityUser user = await _userManager.FindByIdAsync(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            Logica.BL.Tasks tasks = new Logica.BL.Tasks();
            var tenant = tasks.GetTask(id).FirstOrDefault();

            Logica.BL.Tasks tasks = new Logica.BL.Tasks();
            var result = await _userManager.IsInRoleAsync(user, "Admin") ?
                tasks.GetTask(null, projectId) :
                tasks.GetTask(null, id,projectId);

            var listTasks = result.Select(x => new Logica.Models.ViewModel.TasksIndexViewModel
            {

                Id = x.Id,
                Title = x.Title,
                Details = x.Details,
                ExpirationDate = x.ExpirationDate,
                IsCompleted = x.IsCompleted,
                Effort = x.Effort,
                RemainingWork = x.RemainingWork,
                StateName = x.StateId
                

            });

        listTasks:
            listProjects.Take(1).ToList();

            */
            return View();

        }


        public IActionResult Calendar(int? projectId)
        {
            Logica.BL.Projects projects = new Logica.BL.Projects();
            var project = projects.GetProjects(projectId, null).FirstOrDefault();

            ViewBag.Project = project;
            return View();

        }


    
        public IActionResult GetTasksCalendar(int? projectId)
        {

            try
            {

            Logica.BL.Tasks tasks = new Logica.BL.Tasks();

          var result =  tasks.GetTask(projectId,null);
        


            var listTasks = result.Select(x => new Logica.Models.ViewModel.TasksGetTasksCalendarViewModel
            {

                Id = x.Id,
                Start = x.ExpirationDate.Value.AddDays(Convert.ToDouble(-x.RemainingWork)).ToString("yyyy-MM-dd HH:mm:ss"),
                End = x.ExpirationDate.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                Title = x.Title,
                Color = "#FFFF00",
                Allday = true,
                TextColor = "#000000"

            }).ToList();

                return Json(new
                { 
                    Data = listTasks,
                    IsSuccessful = true
                });
            
            }
            catch (Exception e)
            {
                return Json(new ProjectCore.Logica.Models.ViewModel.ResponseViewModel
                {

                    IsSuccessful = false,
                    Errors = new List<string> { e.Message }

                });


            }
          //  return View();

        }




    }
}