using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ChargingPort.Models; 

namespace ChargingPort.Models 
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ChargingStation> ChargingStations { get; private set; } 
        public Battery BatteryStatus { get; } = new Battery();

        public MainViewModel()
        {
            InitializeChargingStations();
            
            BatteryStatus.Percentage = 60; 
        }

        private void InitializeChargingStations()
        {
            ChargingStations = new ObservableCollection<ChargingStation>
            {
                new ChargingStation
                {
                    Name = "SuperCharger Station",
                    PricePerKwh = 0.34,
                    Distance = 0.3,
                    EstimatedTimeMinutes = 25,
                    AvailableSlots = 4,
                    IsAvailabilityGood = true
                },
                new ChargingStation
                {
                    Name = "City Center Charging",
                    PricePerKwh = 0.64,
                    Distance = 0.7,
                    EstimatedTimeMinutes = 40,
                    AvailableSlots = 2,
                    IsAvailabilityGood = false
                },
                new ChargingStation
                {
                    Name = "Green Energy Hub",
                    PricePerKwh = 0.48,
                    Distance = 1.4,
                    EstimatedTimeMinutes = 55,
                    AvailableSlots = 4,
                    IsAvailabilityGood = true
                }
            };
            // Notify that the collection property itself has been set
            OnPropertyChanged(nameof(ChargingStations)); 
        }

        // INotifyPropertyChanged implementation (copied pattern from Battery.cs)
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
