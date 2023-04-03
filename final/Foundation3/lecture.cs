using System;

class Lecture : Event {
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime dateTime, Address address, string speaker, int capacity)
        : base(title, description, dateTime, address) {
        _speaker = speaker;
        _capacity = capacity;
    }
   
    public override void GetFullDetails()
    {
        Console.WriteLine($"{GetTitle()}\n{GetDescription()}\n{_dateTime}\n{_address.GetAddressString()}\nSpeaker: {_speaker}\nCapacity: {_capacity}\n");
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