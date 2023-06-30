public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    public Address(string streetAddress, string city, string stateOrProvince, string country )
    {
        _streetAddress=streetAddress;
        _city=city;
        _stateOrProvince=stateOrProvince;
        _country=country;
    }

    public string GetFullAddress()
    {
        string fullAddress=$"{_streetAddress}, {_city}, {_stateOrProvince}, {_country}";
        return fullAddress;
    }

    public bool IsInTheUSA()
    {
        bool isInTheUSA;
        if(_country=="United States")
        {
            isInTheUSA=true;
        }
        else
        {
            isInTheUSA=false;
        }
        return isInTheUSA;
    }
}