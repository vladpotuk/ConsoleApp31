public class Plane
{
    private string planeName;
    private string manufacturerName;
    private int manufactureYear;
    private string planeType;

    public Plane(string name, string manufacturer, int year, string type)
    {
        planeName = name;
        manufacturerName = manufacturer;
        manufactureYear = year;
        planeType = type;
    }

    public void DisplayData()
    {
        Console.WriteLine($"Назва літака: {planeName}");
        Console.WriteLine($"Назва виробника: {manufacturerName}");
        Console.WriteLine($"Рік випуску: {manufactureYear}");
        Console.WriteLine($"Тип літака: {planeType}");
    }
}
