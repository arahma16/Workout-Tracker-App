using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WorkoutTrackerApp
{
    /// <summary>
    /// Interaction logic for WorkoutAppStartPage.xaml
    /// </summary>
    public partial class WorkoutAppStartPage : Page
    {
        public WorkoutAppStartPage()
        {
            InitializeComponent();

        }

        private void WorkoutClick(object sender, RoutedEventArgs e)
        {
            // Go to Workout Page
            workoutPage wPage = new workoutPage();
            this.NavigationService.Navigate(wPage);
        }

        private void DietClick(object sender, RoutedEventArgs e)
        {
            // Go to Workout Page
            workoutPage wPage = new workoutPage();
            this.NavigationService.Navigate(wPage);
        }

        private void ProgressClick(object sender, RoutedEventArgs e)
        {
            // Go to Workout Page
            workoutPage wPage = new workoutPage();
            this.NavigationService.Navigate(wPage);
        }

        private void HowToClick(object sender, RoutedEventArgs e)
        {
            // Go to Workout Page
            workoutPage wPage = new workoutPage();
            this.NavigationService.Navigate(wPage);
        }
    }
}
