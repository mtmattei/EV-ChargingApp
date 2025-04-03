
namespace ChargingPort.Models
{
    public class ChargingStation
    {
        public string Name { get; set; }
        public double PricePerKwh { get; set; }
        public double Distance { get; set; }
        public int EstimatedTimeMinutes { get; set; }
        public int AvailableSlots { get; set; }
        public bool IsAvailabilityGood { get; set; }

        // Helper properties for binding
        public string PriceFormatted => $"${PricePerKwh:F2}";
        public string DistanceFormatted => $"{Distance:F1} mi";
        public string TimeFormatted => $"~{EstimatedTimeMinutes} min";
        public string AvailabilityText => $"{AvailableSlots} available";
        
        public string AvailabilityBackgroundKey => IsAvailabilityGood
            ? "PrimaryContainerColor"
            : "SecondaryContainerColor";

        public bool ShouldUseActiveNavigateButton => IsAvailabilityGood || AvailableSlots >= 3;
    }
}
