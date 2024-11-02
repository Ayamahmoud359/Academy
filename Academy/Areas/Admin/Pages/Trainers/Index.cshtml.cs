using Academy.DTO;
using Academy.Models;
using CRM.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.Text.Encodings.Web;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Academy.Areas.Admin.Pages.Trainers
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public TrainerVM Trainer { get; set; }
        public List<Branch> Branches { get; set; }
        public List<Department> Departments { get; set; }

        private readonly AcademyContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public IndexModel(AcademyContext context, UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager)
        {
            Trainer = new TrainerVM();
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public void OnGet()
        {
            Branches = _context.Branches.ToList();
            Departments = _context.Departments.ToList();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var coach = new Trainer
                {
                    TrainerName = Trainer.TrainerName,
                    TrainerAddress = Trainer.TrainerAddress,
                    TrainerEmail = Trainer.Email,
                    TrainerPhone = Trainer.TrainerPhone,
                    BranchId = Trainer.BranchId,
                    DepartmentId = Trainer.DepartmentId,
                    IsActive = true,
                    
                };
                try
                {
                    _context.Trainers.Add(coach);
                    await _context.SaveChangesAsync();
                }
                catch(Exception exc)
                {
                    ModelState.AddModelError(string.Empty, exc.Message);
                    return Page();

                }
               

                var user = new ApplicationUser
                {
                    UserName = Trainer.Email,
                    Email = Trainer.Email,
                    
                    PhoneNumber = Trainer.TrainerPhone,
                    EntityId= coach.TrainerId,
                    EntityName= "Trainer"
                    
                };

                try
                {
                    var result = await _userManager.CreateAsync(user, Trainer.Password);

                    if (result.Succeeded)
                    {
                        Redirect("/Admin/Index");
                        
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    // If we got this far, something failed, redisplay form
                    return Page();
                }
                catch(Exception exc)
                {
                    ModelState.AddModelError(string.Empty, exc.Message);
                    
                }
               
            }
            return Page();


        }

    }
}
