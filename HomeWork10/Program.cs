using System;
using System.Collections.Generic;


public class City
{
    
    private string cityName;
    private string regionName;
    private string countryName;
    private int population;
    private string postalCode;
    private string phoneCode;

    
    public City(string cityName, string regionName, string countryName, int population, string postalCode, string phoneCode)
    {
        this.cityName = cityName;
        this.regionName = regionName;
        this.countryName = countryName;
        this.population = population;
        this.postalCode = postalCode;
        this.phoneCode = phoneCode;
    }

    
    public void GetCityInfo()
    {
        Console.WriteLine($"Name of the city: {cityName}");
        Console.WriteLine($"Region: {regionName}");
        Console.WriteLine($"Country: {countryName}");
        Console.WriteLine($"Population: {population}");
        Console.WriteLine($"Postal Code of the city: {postalCode}");
        Console.WriteLine($"Phone Code of the city: {phoneCode}");
    }
}


public class Country
{
   
    private string countryName;
    private string continentName;
    private int population;
    private string phoneCode;
    private string capitalCity;
    private List<City> cities;

   
    public Country(string countryName, string continentName, int population, string phoneCode, string capitalCity)
    {
        this.countryName = countryName;
        this.continentName = continentName;
        this.population = population;
        this.phoneCode = phoneCode;
        this.capitalCity = capitalCity;
        this.cities = new List<City>();
    }

    
    public void AddCity(City city)
    {
        cities.Add(city);
    }

    
    public void GetCountryInfo()
    {
        Console.WriteLine($"Name of country: {countryName}");
        Console.WriteLine($"Continent: {continentName}");
        Console.WriteLine($"Population of the country: {population}");
        Console.WriteLine($"Phone code of the country: {phoneCode}");
        Console.WriteLine($"Capital: {capitalCity}");
        Console.WriteLine("Cities of the country:");
        foreach (City city in cities)
        {
            city.GetCityInfo();
            Console.WriteLine();
        }
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        
        City kyiv = new City("Kyiv", "Kyiv region", "Ukraine", 2804000, "01001", "+38044");
        City lviv = new City("Lviv", "Lviv region", "Ukraine", 721301, "79000", "+38032");

        
        Country ukraine = new Country("Ukraine", "Europe", 41723998, "+380", "Kyiv");
        ukraine.AddCity(kyiv);
        ukraine.AddCity(lviv);

       
        ukraine.GetCountryInfo();

        Console.WriteLine();

        
        City berlin = new City("Berlin", "Berlin", "Germany", 3645000, "10115", "+4930");
        City hamburg = new City("Hamburg", "Hamburg", "Germany", 1841000, "20095", "+4940");

        
        Country germany = new Country("Germany", "Europe", 83166711, "+49", "Berlin");
        germany.AddCity(berlin);
        germany.AddCity(hamburg);

        germany.GetCountryInfo();
    }
}