public class City
{
    private string cityName;
    private string countryName;
    private int population;
    private string phoneCode;
    private string[] cityDistricts;

    public void InputData()
    {
        Console.Write("Введіть назву міста: ");
        cityName = Console.ReadLine();

        Console.Write("Введіть назву країни: ");
        countryName = Console.ReadLine();

        Console.Write("Введіть кількість жителів у місті: ");
        population = int.Parse(Console.ReadLine());

        Console.Write("Введіть телефонний код міста: ");
        phoneCode = Console.ReadLine();

        Console.Write("Введіть назву районів міста (через пробіл): ");
        cityDistricts = Console.ReadLine().Split(' ');
    }

    public void DisplayData()
    {
        Console.WriteLine($"Назва міста: {cityName}");
        Console.WriteLine($"Назва країни: {countryName}");
        Console.WriteLine($"Кількість жителів у місті: {population}");
        Console.WriteLine($"Телефонний код міста: {phoneCode}");
        Console.WriteLine($"Назва районів міста: {string.Join(", ", cityDistricts)}");
    }
}
