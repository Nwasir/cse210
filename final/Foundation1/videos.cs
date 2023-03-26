using System;


class Video {
    public string _title;
    public string _author;
    public int _lengthSeconds;
    public List<Comment> Comments;

    public Video(string title, string author, int lengthSeconds) {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        Comments = new List<Comment>();
    }

    public int NumComments() {
        return Comments.Count;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLengthSeconds()
    {
        return _lengthSeconds;
    }
}