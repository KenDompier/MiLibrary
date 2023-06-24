using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryGraphicalDesktopApplication
{
    public class AddMediaViewModel : ViewModelBase
    {
        public AddMediaViewModel()
        {
            MediaTitle = "";
            MediaType = "";
            StartDate = DateTime.Now;
            // if = true, then enable the finish date in the listbox
            Finished = false;
            FinishDate = DateTime.Now;
            Rating = "1";

        }

        private string _mediaTitle;
        public string MediaTitle
        {
            get { return _mediaTitle; }
            set { _mediaTitle = value; }
        }

        private string _mediaType;
        public string MediaType
        {
            get { return _mediaType; }
            set { _mediaType = value; }
        }

        private bool _finished;
        public bool Finished
        {
            get { return _finished; }
            set { _finished = value; }
        }

        private DateTime _startDate;
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }


        private DateTime _finishDate;
        public DateTime FinishDate
        {
            get { return _finishDate; }
            set { _finishDate = value; }
        }

        private string _rating;
        public string Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

    }
}
