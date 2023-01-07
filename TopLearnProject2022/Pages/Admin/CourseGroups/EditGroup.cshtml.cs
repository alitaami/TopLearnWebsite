using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.Security;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearnProject2022.Pages.Admin.CourseGroups
{
    [PermissionChecker(18)]
    public class EditGroupModel : PageModel
    {
        public ICourseService _course;
        public EditGroupModel(ICourseService c)
        {
            _course = c;
        }
        [BindProperty]
        public CourseGroup CourseGroups { get; set; }

        public void OnGet(int id)
        {
            CourseGroups = _course.GetById(id);
           

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _course.UpdateGroup(CourseGroups);
            return RedirectToPage("Index");

        }
    }
}
