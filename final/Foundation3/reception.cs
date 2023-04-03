using System;
class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime dateTime, Address address, string rsvpEmail)
        : base(title, description, dateTime, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override void GetFullDetails()
    {
        Console.WriteLine($"{GetTitle()}\n{GetDescription()}\n{_dateTime}\n{_address.GetAddressString()}\nRSVP Email: {_rsvpEmail}\n");
    }
    public string GetRSVPemail()
    {
        return _rsvpEmail;
    }
}
