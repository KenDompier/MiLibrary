namespace MediaModel
{
    public class Media
    {
        public string MediaTitle { get; set; }

        // could be movie, music, book, ect. 
        public string MediaType { get; set; }

        public DateTime StartDate { get; set; }

        public bool Finished { get; set; }

        public DateTime FinishDate { get; set; }

        public string Rating { get; set; }

    }
}
