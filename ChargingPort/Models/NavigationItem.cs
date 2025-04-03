namespace ChargingPort.Models
{
    public class NavigationItem
    {
        public string Label { get; set; }
        public string Glyph { get; set; }
        public bool IsSelected { get; set; }
        public int Index { get; set; }
        
        public NavigationItem(string label, string glyph, bool isSelected = false, int index = 0)
        {
            Label = label;
            Glyph = glyph;
            IsSelected = isSelected;
            Index = index;
        }
    }
}
