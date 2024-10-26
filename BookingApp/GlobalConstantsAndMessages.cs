namespace TourAgency
{
    public static class GlobalConstantsAndMessages
    {
        // Tour Name
        public const int TourNameMaxLenght = 60;
        public const string TourNameMaxLenghtErrorMsg = "Tour name must be less than 60 characters";
        public const int TourNameMinLenght = 3;
        public const string TourNameMinLenghtErrorMsg = "Tour name must be more than 3 characters";

        // Tour Description
        public const int TourDescMaxLenght = 500;
        public const string TourDescMaxLenghtErrorMsg = "Tour Description Must be less than 500 characters";
        public const int TourDescMinLenght = 1;
        public const string TourDescMinLenghtErrorMsg = "Tour Description is required";

        // Tour Price
        public const double PriceMinAmount = 1.00;
        public const double PriceMaxAmount = 9999.00;
        public const string PriceInvalidAmountMsg = "The price of the Tour should be between 1.00 and 9999.00";

        // Tour Destination

        public const int TourDestinationMaxLenght = 100;
        public const string TourDestinationMaxLenghtErrorMsg = "Destination must be less than 100 characters";
        public const int TourDestinationMinLenght = 3;
        public const string TourDestinationMinLenghtErrorMsg = "Destination must be more than 3 characters";

        // Tour StartDate 

        public const string DateTimeFormat = "dd-MM-yyyy";
        public const string StartDateNullMsg = "Start Date is required";
        public const string EndDateNullMsg = "End Date is required";



    }
}
