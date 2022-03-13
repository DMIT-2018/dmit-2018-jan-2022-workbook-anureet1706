using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.SamplePages
{
    public class ControlsModel : PageModel
    {
        [TempData]
        public string Feedback { get; set; }
        [BindProperty]
        public string EmailText { get; set; }
        [BindProperty]
        public string PasswordText { get; set; }
        [BindProperty]
        public string DateTimeText { get; set; }

        [BindProperty]
        public string RadioMeal { get; set; }
        public string[] RadioMeals = new[] { "breakfast", "lunch", "dinner/supper", "snacks" };

        [BindProperty]
        public bool AcceptanceBox { get; set; }

        [BindProperty]
        public string MessageBody { get; set; }

        [BindProperty]
        public int MyRide { get; set; }
        //pretend the collection is coming from the database
        //eac row of the collection has two values: selection value; selection text
        //the class selectionList will be used as the datatype for the collection
        public List<SelectionList> Rides { get; set; }

        [BindProperty]
        public string VacationSpot { get; set; }
        public List<string> VacationSpotList { get; set; }

        [BindProperty]
        public int RangeValue { get; set; }

        public void OnGet()
        {
            PopulateLists();
        }

        public void PopulateLists()
        {
            //pretending that this data comes from database
            Rides = new List<SelectionList>();
            Rides.Add(new SelectionList() { valueId = 3, DisplayText = "Bike" });
            Rides.Add(new SelectionList() { valueId = 5, DisplayText = "Board" });
            Rides.Add(new SelectionList() { valueId = 2, DisplayText = "Bus" });
            Rides.Add(new SelectionList() { valueId = 1, DisplayText = "Car" });
            Rides.Add(new SelectionList() { valueId = 4, DisplayText = "Motorcycle" });
            

            VacationSpotList = new List<string>();
            VacationSpotList.Add("California");
            VacationSpotList.Add("Caribbean");
            VacationSpotList.Add("Cruising");
            VacationSpotList.Add("Europe");
            VacationSpotList.Add("Florida");
            VacationSpotList.Add("Mexico");
        }

        public IActionResult onPostText()
        {
            //this method is tied to the specific button on the form via the asp-page handler attribute.
            //the form of the method name is OnPost then concatenate the value given to the handler attribute

            Feedback = $"Email {EmailText}; Password {PasswordText}; Date {DateTimeText}";
            return Page();
        }

        public IActionResult OnPostRadioCheckArea()
        {
            Feedback = $"Meal {RadioMeal}; Acceptance {AcceptanceBox}; Message {MessageBody}";
            
            return Page();
        }

        public IActionResult OnPostListSlider()
        {
            Feedback = $"Ride {MyRide}; Vacation {VacationSpot}; Range {RangeValue}";
            PopulateLists();
            return Page();
        }
    }

    

    public class SelectionList
    {
        public int valueId { get; set; }
        public string DisplayText { get; set; }
    }
}
