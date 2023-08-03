using System.Collections;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Movie_DataAccess.Data;
using Movie_DataAccess.Repository.IRepository;
using Movie_Models;
using Movie_Models.ViewModels;
using Movie_Utility;

namespace Asp.Net_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = StaticDetails.Role_Admin)]

    public class CompanyController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CompanyController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //[Route("Categories")
        public IActionResult Index()
        {
            return View();
        }

        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<ApplicationUser> objUserList = _dbContext.ApplicationUsers.Include(u=>u.Company).ToList();
            return Json(new { data = objUserList });
        }
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}
