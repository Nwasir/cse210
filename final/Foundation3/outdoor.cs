class OutDoor : Event {
    private string _weather;

    public OutDoor(string title, string description, DateTime dateTime, Address address, string weather)
        : base(title, description, dateTime, address)
        {
        _weather = weather;
    }

    public override string GetFullDetails() {
        return ($"{base.GetFullDetails()}Weather: {_weather}\n");
    }
    public string GetWeather()
    {
        return _weather;
    }
}