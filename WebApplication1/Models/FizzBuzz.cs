using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class FizzBuzz
    {
        [Required, Range(1, 100, ErrorMessage ="Podaj dobry zakres")]
        [Display(Name = "Podaj mi swój numerek")]
        public int? Number { get; set; }

        public string CheckRange(int? number)
        {
            if (number is null)
                return "Liczba nie spełnia parametru";
            else
            {
                if (number % 15 == 0)
                    return "FizzBuzz";
                else if (number % 5 == 0)
                    return "Buzz";
                else if (number % 3 == 0)
                    return "Fizz";
                else
                    return "Zła liczba";
            }
        }
    }
}
