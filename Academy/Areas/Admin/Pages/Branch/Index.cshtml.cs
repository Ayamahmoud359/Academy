using Academy.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Academy.Areas.Admin.Pages.Branch
{
    public class IndexModel : PageModel
    {
        public BranchVM BranchVM { get; set; }
        public void OnGet()
        {
        }
    }
}
