using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.SamplePages
{
    public class BasicsModel : PageModel
    {
        //basically this is in object, treat it as such

        //data fields
        public string MyName;

        //the annotation TempData stores data until it's read in another request
        //
        //Two method within TempData are [Keep(string) and [Peek(string)]
        //kept in a dictionary (named/value pair)
        //useful to redirection when data is required for more than a single request
        //Implemented by TempData providers using either cookies or session state
        //TempData is not bound to any particular control like BindProperty

        [TempData]
        public string FeedBack { get; set; }

        //properties
        //the annotation BindProperty ties a property in the PageModel class directly to a cntrol on the Content page
        //data is transferred beween the two automatically
        //on the Content page the control to use this property will have a helper tag called asp-for
        //to reain a value in the control tied to this property AND retained via the @page used the SupportGet attribute
        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }

        //constructors

        //behaviours (aka methods)
        public void OnGet()
        {
            //executes in response to a Get request from the browser
            //when the page is first accessed, it issues a Get requested
            // when the page is refreshed, WITHOUT a Post, it issues a Get request
            // when the page is retrived in response to a form POST using RedirectToPage()
            //If NO RedirectToPage() is used on the POST, there is No GET request

            Random rnd = new Random();
            int oddeven = rnd.Next(0, 25);
            if (oddeven % 2 == 0)
            {
                MyName = $"Anureet is even ({oddeven})";
            }
            else
            {
                MyName = null;
            }
        }

        //processing in response to a request from a form
        //thsi request is reffered to as a post
        //
        //General Post
        //a general post occurs whrn a page-handler is NOT used
        // the return database can be void however you will normal encounter the datatype IActionResult
        //the IActionResult requires some type of request action on return statement
        //typical actions:
        // Page()
        // :does NOT issue a OnGet request
        // :remains on the current page
        // : a good actions for form processing involving validation and with the catch of a try/catch
        // RedirectToPage
        // :DOES issue a OnGet request
        // :its used in retaining input values the @page on the Content page

        public IActionResult OnPost()
        {
            //this line of code is used to cause a delay in processing
            // so we can see on the network activity some type simulated processing
            Thread.Sleep(2000);

            //retreive data via the Request object
            string buttonvalue = Request.Form["theButton"];
            FeedBack = $"Button press use {buttonvalue} with numeric input of {id}";
            return RedirectToPage(new {id = id}); //request for value to be retained
        }
    }
}
