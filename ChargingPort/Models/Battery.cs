using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ChargingPort.Models;

public class Battery : INotifyPropertyChanged
{
    private int _percentage = 55;

    public int Percentage
    {
        get => _percentage;
        set
        {
            if (_percentage != value)
            {
                _percentage = value;
                OnPropertyChanged();
            }
        }
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
