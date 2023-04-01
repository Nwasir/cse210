using System;
class Event {
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private Address _address;

    public Event(string title, string description, DateTime dateTime, Address address) {
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }
    // public string GetStandardDetails() {
    //     return $"{_title}\n{_description}\n{_dateTime}\n{_address}\n";
    // }
    public virtual string GetFullDetails() {
        return $"{_title}\n{_description}\n{_dateTime}\n{_address}\n";
    }
    // public string GetShortDescription() {
    //     return $"{GetType().Name}: {_title}, {_dateTime.ToShortDateString()}";
    // }
    public string GetTitle()
    {
        return _title;
    }
    public string GetDescription()
    {
        return _description;
    }
}