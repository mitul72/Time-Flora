using System.ComponentModel;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Time_Flora_1_.ViewModels;

namespace Time_Flora_1_.Views
{

    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        MainWindowViewModel viewModel = new MainWindowViewModel();


        public MainWindow()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void Angular_bracket_left_OnClick(object? sender, RoutedEventArgs e)
        {
            // throw new System.NotImplementedException();
            // viewModel.updateBinding();
            if (ViewModels.MainWindowViewModel.minutes == 5)
            {
                return;
            }

            ViewModels.MainWindowViewModel.minutes -= 5;
            TimerButton.Content = $"{MainWindowViewModel.minutes}:{MainWindowViewModel.seconds.ToString("00")}";

        }

        private void Angular_bracket_right_OnClick(object? sender, RoutedEventArgs e)
        {
            // throw new System.NotImplementedException();
            if (ViewModels.MainWindowViewModel.minutes == 120)
            {
                return;
            }

            ViewModels.MainWindowViewModel.minutes += 5;
            TimerButton.Content = $"{MainWindowViewModel.minutes}:{MainWindowViewModel.seconds.ToString("00")}";
        }
    }
}