using MediaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
using LiveCharts;
using LiveCharts.Wpf;

namespace MediaLibraryGraphicalDesktopApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainViewModel ViewModel => (MainViewModel)this.DataContext;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddMediaWindow mediaWindow = new AddMediaWindow();
            mediaWindow.MainViewModelHolder = ViewModel;
            mediaWindow.DataContext = ViewModel.AddMediaViewModel;
            mediaWindow.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = new MainViewModel();
        }


        private void Remove_Button(object sender, RoutedEventArgs e)
        {
            ViewModel.RemoveMedia(MediaList.SelectedIndex);
            ViewModel.SimpleMediaList.RemoveAt(MediaList.SelectedIndex);
            ViewModel.SaveMedia();
        }

        private void Compare_Media_Button(object sender, RoutedEventArgs e)
        {
            var chartWindow = new Window();
            chartWindow.Title = "Comparing Media Types";

            var chart = new LiveCharts.Wpf.PieChart();

            var mediaTypeCounts = ViewModel.SimpleMediaList
                .GroupBy(m => m.MediaType)
                .Select(g => new { MediaType = g.Key, Count = g.Count() })
                .ToArray();

            foreach (var mediaTypeCount in mediaTypeCounts)
            {
                var series = new LiveCharts.Wpf.PieSeries();
                series.Title = mediaTypeCount.MediaType.ToString();
                series.Values = new LiveCharts.ChartValues<int>(new[] { mediaTypeCount.Count });
                series.DataLabels = true;
                series.LabelPoint = point => $"{mediaTypeCount.MediaType}: {point.Y}";
                chart.Series.Add(series);
            }

            chartWindow.Content = chart;

            chartWindow.Show();
        }

        private void Compare_Rating_Button(object sender, RoutedEventArgs e)
        {
            var chartWindow = new Window();
            chartWindow.Title = "Comparing Ratings";

            var chart = new LiveCharts.Wpf.PieChart();

            var ratingCounts = ViewModel.SimpleMediaList
                .GroupBy(m => m.Rating)
                .Select(g => new { Rating = g.Key, Count = g.Count() })
                .ToArray();

            foreach (var ratingCount in ratingCounts)
            {
                var series = new LiveCharts.Wpf.PieSeries();
                series.Title = ratingCount.Rating.ToString();
                series.Values = new LiveCharts.ChartValues<int>(new[] { ratingCount.Count });
                series.DataLabels = true;
                series.LabelPoint = point => $"{ratingCount.Rating}: {point.Y}";
                chart.Series.Add(series);
            }

            chartWindow.Content = chart;

            chartWindow.Show();
        }


    }
}

