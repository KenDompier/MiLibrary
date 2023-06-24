using MediaModel;

namespace Test.MediaModel
{
    [TestClass]
    public class MediaListTests
    {
        // part A. test if media class works
        [TestMethod]
        public void CreateMedia_OneMovie_ReturnInputtedInformation()
        {
            //ARRANGE
            string movieTitle = "Forest Gump";
            string mediaType = "Movie";
            bool finishedMovie = true;
            DateTime startDate = new DateTime(2015, 12, 25, 10, 30, 45);
            DateTime finishDate = new DateTime(2015, 12, 26, 10, 30, 45);
            string movieRating = "9";

            //ACT

            Media actualMovie = new Media();
            actualMovie.MediaTitle = "Forest Gump";
            actualMovie.MediaType = "Movie";
            actualMovie.Finished = true;
            actualMovie.StartDate = new DateTime(2015, 12, 25, 10, 30, 45);
            actualMovie.FinishDate = new DateTime(2015, 12, 26, 10, 30, 45);
            actualMovie.Rating = "9";

            //ASSERT
            Assert.AreEqual(movieTitle, actualMovie.MediaTitle);
            Assert.AreEqual(mediaType, actualMovie.MediaType);
            Assert.AreEqual(finishedMovie, actualMovie.Finished);
            Assert.AreEqual(startDate, actualMovie.StartDate);
            Assert.AreEqual(finishDate, actualMovie.FinishDate);
            Assert.AreEqual(movieRating, actualMovie.Rating);
        }



        // part B. test if medialist adds media
        [TestMethod]
        public void CreateMediaList_AddTwoMedia_ReturnListCount()
        {
            //ARRANGE
            MediaList newList = new MediaList();

            int expectedAmount = 2;

            //ACT
            Media actualMovie = new Media();
            actualMovie.MediaTitle = "Forest Gump";
            actualMovie.MediaType = "Movie";
            actualMovie.Finished = true;
            actualMovie.StartDate = new DateTime(2015, 12, 25, 10, 30, 45);
            actualMovie.FinishDate = new DateTime(2015, 12, 26, 10, 30, 45);
            actualMovie.Rating = "9";
            newList.AddMedia(actualMovie);

            Media actualBook = new Media();
            actualBook.MediaTitle = "A Tale of Two Cities";
            actualBook.MediaType = "Book";
            actualBook.Finished = true;
            actualBook.StartDate = new DateTime(2019, 05, 14, 10, 30, 45);
            actualBook.FinishDate = new DateTime(2019, 06, 12, 10, 30, 45);
            actualBook.Rating = "6";
            newList.AddMedia(actualBook);

            int mediaCount = newList.CountMediaFromList();

            //ASSERT
            Assert.AreEqual(expectedAmount, mediaCount);
        }

        [TestMethod]
        public void CreateMediaList_AddFiveMedia_ReturnListCount()
        {
            //ARRANGE
            MediaList newList = new MediaList();

            int expectedAmount = 5;

            //ACT
            Media actualMovie = new Media();
            actualMovie.MediaTitle = "Forest Gump";
            actualMovie.MediaType = "Movie";
            actualMovie.Finished = true;
            actualMovie.StartDate = new DateTime(2015, 12, 25, 10, 30, 45);
            actualMovie.FinishDate = new DateTime(2015, 12, 26, 10, 30, 45);
            actualMovie.Rating = "9";
            newList.AddMedia(actualMovie);

            Media actualBook = new Media();
            actualBook.MediaTitle = "A Tale of Two Cities";
            actualBook.MediaType = "Book";
            actualBook.Finished = true;
            actualBook.StartDate = new DateTime(2019, 05, 14, 10, 30, 45);
            actualBook.FinishDate = new DateTime(2019, 06, 12, 10, 30, 45);
            actualBook.Rating = "6";
            newList.AddMedia(actualBook);

            Media actualVideoGame = new Media();
            actualVideoGame.MediaTitle = "Dark Souls";
            actualVideoGame.MediaType = "Video Game";
            actualVideoGame.Finished = true;
            actualVideoGame.StartDate = new DateTime(2020, 01, 04, 10, 30, 45);
            actualVideoGame.FinishDate = new DateTime(2020, 03, 25, 10, 30, 45);
            actualVideoGame.Rating = "10";
            newList.AddMedia(actualVideoGame);

            Media actualShow = new Media();
            actualVideoGame.MediaTitle = "Breaking Bad";
            actualVideoGame.MediaType = "TV Show";
            actualVideoGame.Finished = true;
            actualVideoGame.StartDate = new DateTime(2021, 06, 25, 10, 30, 45);
            actualVideoGame.FinishDate = new DateTime(2020, 08, 03, 10, 30, 45);
            actualVideoGame.Rating = "9";
            newList.AddMedia(actualShow);

            Media actualAnime = new Media();
            actualVideoGame.MediaTitle = "Attack On Titan: Seasom 1";
            actualVideoGame.MediaType = "Anime";
            actualVideoGame.Finished = true;
            actualVideoGame.StartDate = new DateTime(2022, 08, 04, 10, 30, 45);
            actualVideoGame.FinishDate = new DateTime(2020, 09, 15, 10, 30, 45);
            actualVideoGame.Rating = "7";
            newList.AddMedia(actualAnime);

            int mediaCount = newList.CountMediaFromList();

            //ASSERT
            Assert.AreEqual(expectedAmount, mediaCount);
        }

        // part C. test if removing media works.
        [TestMethod]
        public void CreateMediaList_AddOneMedia_RemoveFromMediaList()
        {
            //ARRANGE
            MediaList newList = new MediaList();
            int expectedAmount = 0;

            //ACT
            Media actualMovie = new Media();
            actualMovie.MediaTitle = "Forest Gump";
            actualMovie.MediaType = "Movie";
            actualMovie.Finished = true;
            actualMovie.StartDate = new DateTime(2015, 12, 25, 10, 30, 45);
            actualMovie.FinishDate = new DateTime(2015, 12, 26, 10, 30, 45);
            actualMovie.Rating = "9";
            newList.AddMedia(actualMovie);

            // just making it 0 for the sake of the test. in the actual program, you can select the media in the listbox.
            newList.RemoveMediaFromList(0);

            int mediaCount = newList.CountMediaFromList();

            //ASSERT
            Assert.AreEqual(expectedAmount, mediaCount);

        }

        [TestMethod]
        public void CreateMediaList_AddTwoMedia_RemoveOneFromMediaList()
        {
            //ARRANGE
            MediaList newList = new MediaList();
            int expectedAmount = 1;

            //ACT
            Media actualMovie = new Media();
            actualMovie.MediaTitle = "Forest Gump";
            actualMovie.MediaType = "Movie";
            actualMovie.Finished = true;
            actualMovie.StartDate = new DateTime(2015, 12, 25, 10, 30, 45);
            actualMovie.FinishDate = new DateTime(2015, 12, 26, 10, 30, 45);
            actualMovie.Rating = "9";
            newList.AddMedia(actualMovie);

            Media actualBook = new Media();
            actualBook.MediaTitle = "A Tale of Two Cities";
            actualBook.MediaType = "Book";
            actualBook.Finished = true;
            actualBook.StartDate = new DateTime(2019, 05, 14, 10, 30, 45);
            actualBook.FinishDate = new DateTime(2019, 06, 12, 10, 30, 45);
            actualBook.Rating = "6";
            newList.AddMedia(actualBook);

            // just making it 0 for the sake of the test. in the actual program, you can select the media in the listbox.
            newList.RemoveMediaFromList(0);

            int mediaCount = newList.CountMediaFromList();

            //ASSERT
            Assert.AreEqual(expectedAmount, mediaCount);
        }

        [TestMethod]
        public void CreateMediaList_AddTwoMedia_RemoveBothFromMediaList()
        {
            //ARRANGE
            MediaList newList = new MediaList();
            int expectedAmount = 0;

            //ACT
            Media actualMovie = new Media();
            actualMovie.MediaTitle = "Forest Gump";
            actualMovie.MediaType = "Movie";
            actualMovie.Finished = true;
            actualMovie.StartDate = new DateTime(2015, 12, 25, 10, 30, 45);
            actualMovie.FinishDate = new DateTime(2015, 12, 26, 10, 30, 45);
            actualMovie.Rating = "9";
            newList.AddMedia(actualMovie);

            Media actualBook = new Media();
            actualBook.MediaTitle = "A Tale of Two Cities";
            actualBook.MediaType = "Book";
            actualBook.Finished = true;
            actualBook.StartDate = new DateTime(2019, 05, 14, 10, 30, 45);
            actualBook.FinishDate = new DateTime(2019, 06, 12, 10, 30, 45);
            actualBook.Rating = "6";
            newList.AddMedia(actualBook);

            // just making it 0 for the sake of the test. in the actual program, you can select the media in the listbox.
            newList.RemoveMediaFromList(1);
            newList.RemoveMediaFromList(0);


            int mediaCount = newList.CountMediaFromList();

            //ASSERT
            Assert.AreEqual(expectedAmount, mediaCount);
        }
    }
}