using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static TourAgency.GlobalConstantsAndMessages;
namespace TourAgency.Data.Models
{
    public class Tour
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TourNameMaxLenght, ErrorMessage = TourNameMaxLenghtErrorMsg)]
        [MinLength(TourNameMinLenght, ErrorMessage = TourNameMinLenghtErrorMsg)]
        [Comment("Tour Name")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(TourDescMaxLenght, ErrorMessage = TourDescMaxLenghtErrorMsg)]
        [MinLength(TourDescMinLenght, ErrorMessage = TourDescMinLenghtErrorMsg)]
        [Comment("Tour Description")]
        public string Description { get; set; } = null!;

        [Required]
        [Range(PriceMinAmount, PriceMaxAmount, ErrorMessage = PriceInvalidAmountMsg)]
        [Comment("The price of the tour")]
        public decimal Price { get; set; }


        [Required]
        [MaxLength(TourDestinationMaxLenght, ErrorMessage = TourDestinationMaxLenghtErrorMsg)]
        [MinLength(TourDestinationMinLenght, ErrorMessage = TourDestinationMinLenghtErrorMsg)]
        [Comment("Destination of the tour")]
        public string Destionation { get; set; } = null!;

        [Required(ErrorMessage = StartDateNullMsg)]
        [DataType(DataType.Date)]
        [Comment("Starting date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = EndDateNullMsg)]
        [DataType(DataType.Date)]
        [Comment("End date")]
        public DateTime EndDate { get; set; }

        [Required]
        [Comment("Shows if the tour is available")]
        public bool IsAvailable { get; set; } = true;
    }
}






