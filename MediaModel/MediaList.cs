using System.Net;

namespace MediaModel
{
    public class MediaList
    {

        public MediaList()
        {
            MediaAddList = new List<Media>();
        }

        public List<Media> MediaAddList { get; set; } = new List<Media>();

        public List<Media> AddMedia(Media mediaAttributes)
        {
            MediaAddList.Add(mediaAttributes);

            return MediaAddList;
        }

        public int AddMedia(List<Media> addedMedia)
        {
            int mediaCounter = 0;

            foreach (Media mediaAdded in MediaAddList)
            {
                MediaAddList.Add(mediaAdded);
                mediaCounter++;
            }

            return mediaCounter;
        }

        public List<Media> RemoveMediaFromList(int selectedItem)
        {
            MediaAddList.RemoveAt(selectedItem);
            return MediaAddList;
        }

        public int CountMediaFromList()
        {
            int mediaCount = MediaAddList.Count;
            return mediaCount;
        }
    }
}