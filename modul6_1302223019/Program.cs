using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace modul6_1302223019
{
    public class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
            Random random = new Random();
            this.id = random.Next(10000, 100000);
            Debug.Assert(username.Length <= 5 && username != null, "title tidak dapat dimasukkan");
            this.username = checked(username);
            this.id = 0;
        }

        public int GetTotalVideoPlayCount()
        {
            int count = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                count += uploadedVideos[i].GetPlayCount();
            }
            return count;
        }

        public void AddVideo(SayaTubeVideo AddVideo)
        {
            this.uploadedVideos.Add(AddVideo);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("Informasi Video");
            Console.WriteLine("User         : " + this.username);
            Console.WriteLine("Video 1         : " + this.uploadedVideos);
            Console.WriteLine("Video 2         : " + this.uploadedVideos);
        }
    }
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random();
            this.id = random.Next(10000, 100000);
            Debug.Assert(title.Length <= 5 && title != null, "title tidak dapat dimasukkan");
            this.title = checked(title);
            this.playCount = 0;
        }
        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount < 10000000, "play count tidak dapat ditambahkan karena lebih dari 10.000.000");
            Debug.Assert(this.playCount + playCount < int.MaxValue, "jumlah play count melebihi batas");
            this.playCount = checked(this.playCount + playCount);
        }

        public void PrintVideoDetail()
        {
            Console.WriteLine("Informasi Video");
            Console.WriteLine("ID         : " + this.id);
            Console.WriteLine("Title      : " + this.title);
            Console.WriteLine("Play Count : " + this.playCount);
        }
        
        public int GetPlayCount()
        {
            return this.playCount;
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                SayaTubeUser username = new SayaTubeUser("Puri Lalita Anagata");
                SayaTubeUser video = new SayaTubeUser("Review Film" + username);
                SayaTubeVideo title = new SayaTubeVideo(" ");
            }
        }
    }
}
