public class Address
{
    private string street;
    private string city;
    private string state;
    private string postalCode;
    private string country;

    public Address(string street, string city, string state, string postalCode, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.postalCode = postalCode;
        this.country = country;
    }

    public override string ToString()
    {
        return $"{street}, {city}, {state}, {postalCode}, {country}";
    }
}
