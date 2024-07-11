public class Address
{
    private string street;
    private string city;
    private string stateOrProvince;
    private string country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        this.street = street;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    public string Street => street;
    public string City => city;
    public string StateOrProvince => stateOrProvince;
    public string Country => country;

    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }

    public override string ToString()
    {
        return $"{street}\n{city}, {stateOrProvince}\n{country}";
    }
}
