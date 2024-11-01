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

namespace Academy.Areas.Admin.Pages.AddTrainer
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
                _context.Trainers.Add(coach);
                await _context.SaveChangesAsync();

                var user = new ApplicationUser
                {
                    UserName = Trainer.Email,
                    Email = Trainer.Email,
                    
                    PhoneNumber = Trainer.TrainerPhone,
                    EntityId= coach.TrainerId,
                    EntityName= "Trainer"
                    
                };

               
                var result = await _userManager.CreateAsync(user, Trainer.Password);

                if (result.Succeeded)
                {
                    Redirect ("/Admin/Index");
                    //var userId = await _userManager.GetUserIdAsync(user);
                    //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    //var callbackUrl = Url.Page(
                    //    "/Account/ConfirmEmail",
                    //    pageHandler: null,
                    //    values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                    //    protocol: Request.Scheme);

                    //await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                    //    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    //if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    //{
                    //    return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    //}
                    //else
                    //{
                    //    await _signInManager.SignInAsync(user, isPersistent: false);
                    //    return LocalRedirect(returnUrl);
                    //}
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

    }
}
