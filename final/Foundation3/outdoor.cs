class OutDoor : Event {
    private string _weather;

    public OutDoor(string title, string description, DateTime dateTime, Address address, string weather)
        : base(title, description, dateTime, address)
        {
        _weather = weather;
    }

    public override void GetFullDetails()
    {
        Console.WriteLine($"{GetTitle()}\n{GetDescription()}\n{_dateTime}\n{_address.GetAddressString()}\nWeather: {_weather}\n");
    }
    public string GetWeather()
    {
        return _weather;
    }
}