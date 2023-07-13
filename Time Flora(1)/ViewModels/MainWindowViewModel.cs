using System.ComponentModel;
using Avalonia.Interactivity;
using Avalonia.Rendering;

namespace Time_Flora_1_.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public string AngularBrackLeft => "<";
        public string AngularBrackRight => ">";
        public int progress { get; set; } = 100;
        public static int minutes { get; set; } = 20;
        public static int seconds { get; set; } = 0;
        public int hours { get; set; } = 0;
        public int days { get; set; } = 0;
        public int months { get; set; } = 0;
        public int years { get; set; } = 0;
        public string test;
        public string minuteSeconds { get; set; } = $"{minutes}:{seconds.ToString("00")}";

        public void updateBinding()
        {
            minutes -= 10;
            this.minuteSeconds = $"{minutes}:{seconds.ToString("00")}";
        }

    }
}