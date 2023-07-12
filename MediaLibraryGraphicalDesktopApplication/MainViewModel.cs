using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MediaLibraryServices;
using MediaModel;

namespace MediaLibraryGraphicalDesktopApplication
{
    public class MainViewModel : ViewModelBase

    {
        private MediaLibraryDataService _dataService;
        private MediaList _medialist;

        public MainViewModel()
        {
            _dataService = new MediaLibraryDataService();
            _medialist = _dataService.LoadMediaList();
            SimpleMediaList = new ObservableCollection<Media>();
            LoadMedia();
            AddMediaViewModel = new AddMediaViewModel();
        }


        public ObservableCollection<Media> SimpleMediaList { get; set; }

        private AddMediaViewModel _addmediaviewmodel;
        public AddMediaViewModel AddMediaViewModel
        {
            get { return _addmediaviewmodel; }
            set
            {
                _addmediaviewmodel = value;
                OnPropertyChanged();
            }
        }

        private void LoadMedia()
        {
            SimpleMediaList.Clear();
            foreach (Media addMedia in _medialist.MediaAddList)
            {
                SimpleMediaList.Add(addMedia);
            }
        }
        internal void AddMedia()
        {
            Media mediaAttributes = new Media();
            mediaAttributes.MediaTitle = AddMediaViewModel.MediaTitle;
            mediaAttributes.MediaAuthor = AddMediaViewModel.MediaAuthor;
            mediaAttributes.MediaType = AddMediaViewModel.MediaType;
            mediaAttributes.Finished = AddMediaViewModel.Finished;
            mediaAttributes.StartDate = AddMediaViewModel.StartDate;
            mediaAttributes.FinishDate = AddMediaViewModel.FinishDate;
            mediaAttributes.Rating = AddMediaViewModel.Rating;


            _medialist.AddMedia(mediaAttributes);
            LoadMedia();
        }

        internal void SaveMedia()
        {
            _dataService.SaveMediaToList(_medialist);
        }

        internal void RemoveMedia(int removeItem)
        {
            _medialist.RemoveMediaFromList(removeItem);
        }

        internal void SelectMedia(int selectedMedia)
        {
            _dataService.SaveMediaToList(_medialist);
        }
        internal void EditMedia(int removeItem)
        {
            // removes old version of media
            _medialist.RemoveMediaFromList(removeItem);

            // adds new one
            Media mediaAttributes = new Media();
            mediaAttributes.MediaTitle = AddMediaViewModel.MediaTitle;
            mediaAttributes.MediaAuthor = AddMediaViewModel.MediaAuthor;
            mediaAttributes.MediaType = AddMediaViewModel.MediaType;
            mediaAttributes.Finished = AddMediaViewModel.Finished;
            mediaAttributes.StartDate = AddMediaViewModel.StartDate;
            mediaAttributes.FinishDate = AddMediaViewModel.FinishDate;
            mediaAttributes.Rating = AddMediaViewModel.Rating;


            _medialist.AddMedia(mediaAttributes);
            LoadMedia();
        }


    }
}
