public class SayaTubeVideo
{
    int id;
    string title;
    int playCount;


    public SayaTubeVideo()
    {
        Random generate = new Random();
        this.id = generate.Next(0, 100000);
        this.playCount = 0;
    }

    public void IncreaseplayCount(int angka)
    {
        playCount = playCount + angka;
    }

    public int GetPlaycount()
    {
        return playCount;
    }

    public string GetTitle()
    {
        return title;
    }

    public void printVideoDetails()
    {
        Console.WriteLine("title: " + title);
        Console.WriteLine("id: " + id);
        Console.WriteLine("playCount:" + playCount);
    }


}


public class SayaTubeUser
{
    int id;
    List<SayaTubeVideo> uploadedVideo;
    string Username;

    public SayaTubeUser(string profile)
    {
        this.Username = profile;
        Random generate = new Random();
        this.id = generate.Next(0, 100000);
        uploadedVideo = new List<SayaTubeVideo>();

    }

    public void GetTotalVideoplayCount()
    {
        int dataplayCount = 0;
        foreach (SayaTubeVideo video in uploadedVideo)
        {
            dataplayCount = dataplayCount + video.GetPlaycount();
        }
    }

    public void addVideo(SayaTubeVideo data)
    {
        uploadedVideo.Add(data);
    }


    public void printAllvideoplayCount()
    {

        for (int i = 0; i < uploadedVideo.Count; i++)
        {
            Console.WriteLine("user:" + Username);
            Console.WriteLine("Video 1 judul:" + (i + 1) + ":" + uploadedVideo[i]);
        }

    }

    Debug.Assert(username <= int.MaxValue && username >= int.MinValue);
        {

        }
         

}