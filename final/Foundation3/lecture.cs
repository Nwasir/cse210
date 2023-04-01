using System;

class Lecture : Event {
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime dateTime, Address address, string speaker, int capacity)
        : base(title, description, dateTime, address) {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string GetFullDetails() {
        return $"{base.GetFullDetails()}Speaker: {_speaker}\nCapacity: {_capacity}\n";
    }
    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
}