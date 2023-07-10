using MediaModel;
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
using System.Windows.Shapes;

namespace MediaLibraryGraphicalDesktopApplication
{

    public partial class EditMediaWindow : Window
    {
        public AddMediaViewModel ViewModel => (AddMediaViewModel)this.DataContext;

        public MainViewModel MainViewModelHolder { get; set; }

        public int SelectedIndex { get; set; }


        public EditMediaWindow()
        {
            InitializeComponent();
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            MainViewModelHolder.EditMedia(SelectedIndex);
            // resets for next time window is opened
            ViewModel.MediaTitle = string.Empty;
            ViewModel.MediaType = string.Empty;
            ViewModel.StartDate = DateTime.Now;
            ViewModel.FinishDate = DateTime.Now;
            ViewModel.Finished = false;
            Close();
        }

    }
}
