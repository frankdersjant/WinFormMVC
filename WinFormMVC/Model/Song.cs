namespace WinFormMVC.Model
{
    public class Song
    {
        public int SongId { get; private set; }
        public string Title { get; private set; }
        public string Artists { get; private set; }


        public Song(int songId, string title, string artists)
        {
            SongId = songId;
            Title = title;
            Artists = artists;
        }
    }
}
