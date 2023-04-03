using System;
class Event {
    private string _title;
    private string _description;
    protected DateTime _dateTime;
    protected Address _address;

    public Event(string title, string description, DateTime dateTime, Address address) {
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }
   
    public virtual void GetFullDetails() {
        
        Console.WriteLine($"{_title}\n{_description}\n{_dateTime}\n{_address.GetAddressString()}\n");
    }
     public string GetTitle()
    {
        return _title;
    }
    public string GetDescription()
    {
        return _description;
    }
    
    
}