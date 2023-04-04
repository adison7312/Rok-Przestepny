using System.ComponentModel.DataAnnotations;

namespace LeapYear.Form
{
    public class YearForm
    {
        [Display(Name = "Year"), Required, Range(1899, 2022, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}.")]
        public int Year { get; set; }

        [Display(Name = "Name"), Required, StringLength(100, ErrorMessage = "Maksymalna długość to {0} znaków")]
        public string Name { get; set; }


        public string Result()
        {
            string result;
            if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0) result = "";
            else result = "nie";
            
            if (Name.EndsWith("a"))
                return Name + " urodziła się w " + Year + " roku. To " + result +" był rok przestępny"; 
            else
                return Name + " urodził się w " + Year + " roku. To " + result + " był rok przestępny";
        }
    }
}