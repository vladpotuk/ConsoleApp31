public class Employee
{
    private string fullName;
    private DateTime birthDate;
    private string contactPhone;
    private string workEmail;
    private string position;
    private string jobDescription;

    public void InputData()
    {
        Console.Write("Введіть ПІБ співробітника: ");
        fullName = Console.ReadLine();

        Console.Write("Введіть дату народження співробітника (у форматі YYYY-MM-DD): ");
        birthDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Введіть контактний телефон співробітника: ");
        contactPhone = Console.ReadLine();

        Console.Write("Введіть робочий email співробітника: ");
        workEmail = Console.ReadLine();

        Console.Write("Введіть посаду співробітника: ");
        position = Console.ReadLine();

        Console.Write("Введіть опис службових обов'язків: ");
        jobDescription = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine($"ПІБ співробітника: {fullName}");
        Console.WriteLine($"Дата народження: {birthDate.ToShortDateString()}");
        Console.WriteLine($"Контактний телефон: {contactPhone}");
        Console.WriteLine($"Робочий email: {workEmail}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Опис службових обов'язків: {jobDescription}");
    }
}
