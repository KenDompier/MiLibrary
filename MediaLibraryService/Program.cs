using MediaModel;
using System;
using System.IO;
using System.Text.Json;

namespace MediaLibraryServices
{
    public class MediaLibraryDataService
    {
        private readonly string _saveFilePath;

        public MediaLibraryDataService()
        {
            string storageFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Storage");
            if (!Directory.Exists(storageFolderPath))
            {
                Directory.CreateDirectory(storageFolderPath);
            }
            _saveFilePath = Path.Combine(storageFolderPath, "data.json");
        }

        public void SaveMediaToList(MediaList data)
        {
            string json = JsonSerializer.Serialize<MediaList>(data);
            File.WriteAllText(_saveFilePath, json);
        }

        public MediaList LoadMediaList()
        {
            if (File.Exists(_saveFilePath))
            {
                string fileContents = File.ReadAllText(_saveFilePath);
                MediaList mList = JsonSerializer.Deserialize<MediaList>(fileContents);
                return mList;
            }
            else
            {
                MediaList mList = new MediaList();
                return mList;
            }
        }
    }
}
