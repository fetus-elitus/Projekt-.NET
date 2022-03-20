using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class FizzBuzz
    {
        [Required, Range(1, 100, ErrorMessage ="Podaj dobry zakres")]
        [Display(Name = "Podaj mi swój numerek")]
        public int? Number { get; set; }

        public string CheckRange()
        {
            if (this.Number is null)
                return "";
            else
            {
                if (this.Number % 15 == 0)
                    return "FizzBuzz";
                else if (this.Number % 5 == 0)
                    return "Buzz";
                else if (this.Number % 3 == 0)
                    return "Fizz";
                else
                    return "Zla liczba";
            }
        }
    }
}
