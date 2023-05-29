namespace Time_Flora_1_.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string AngularBrackLeft => "<";
        public string AngularBrackRight => ">";
        public int progress { get; set; } = 100;
        public int minutes { get; set; } = 20;
        public int seconds { get; set; } = 0;
        public int hours { get; set; } = 0;
        public int days { get; set; } = 0;
        public int months { get; set; } = 0;
        public int years { get; set; } = 0;
        public string minuteSeconds { get; set; } = "20:00";
    }
}

