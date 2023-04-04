using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LeapYear.Form;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net;

namespace LeapYear.Pages
{
    public class ZapisaneModel : PageModel
    {
        public static List<YearForm> YearForm = new List<YearForm>();
        public YearForm YearNameForm { get; set; }

        public List<YearForm> GetYearNameForms()
        {
            return YearForm;
        }
        public void OnGet()
        {
            var Data = HttpContext.Session.GetString("Data");

            if (Data != null)
            {
                YearNameForm = JsonConvert.DeserializeObject<YearForm>(Data);
                YearForm.Add(YearNameForm);
            }

        }

        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
