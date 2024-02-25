using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTests
{
    [TestMethod]
    public void TestCityInputAndDisplay()
    {
        // Arrange
        City city = new City();

        // Act
        city.InputData();


    }

    [TestMethod]
    public void TestEmployeeInputAndDisplay()
    {
        // Arrange
        Employee employee = new Employee();

        // Act
        employee.InputData();


    [TestMethod]
    public void TestPlaneDisplay()
    {
        // Arrange
        Plane plane = new Plane("TestPlane", "TestManufacturer", 2022, "TestType");

    }

    [TestMethod]
    public void TestMatrixInputAndDisplay()
    {
        // Arrange
        Matrix matrix = new Matrix(2, 2);

        // Act
        matrix.InputData();


    }

    [TestMethod]
    public void TestMatrixMaximumAndMinimum()
    {
        // Arrange
        Matrix matrix = new Matrix(2, 2);
        matrix.InputData();

        // Act
        int max = matrix.FindMaximum();
        int min = matrix.FindMinimum();

    }
}
