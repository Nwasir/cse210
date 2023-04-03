using System;
class Address {
    private string _street;
    private string _city;
    private string _state;
    private string _zip;

    public Address(string street, string city, string state, string zip) {
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
    }

    public string GetAddressString() {
        return ($"{_street}, {_city}, {_state} {_zip}");
    }
    public string GetStreet()
    {
        return _street;
    }
    public string GetCity()
    {
        return _city;
    }
    public string GetState()
    {
        return _state;
    }
    public string GetZip()
    {
        return _zip;
    }
}