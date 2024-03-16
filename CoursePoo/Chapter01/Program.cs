using Chapter01;

public class Program
{
    private static void Main(string[] args)
    {
        TriangleArea();
        
        ProductInfo();

        CompareAge();

        CalculateAverageSalary();
    }
    
    #region Triangle
    private static void TriangleArea()
    {
        Triangle triangleA  = new Triangle();
        Triangle triangleB  = new Triangle();

        triangleA.SideA     = 3.00;
        triangleA.SideB     = 4.00;
        triangleA.SideC     = 5.00;

        triangleB.SideA     = 7.50;
        triangleB.SideB     = 4.50;
        triangleB.SideC     = 4.02;

        Console.WriteLine($"Measurements of the sides of the triangle X: Ax = {triangleA.SideA}, Bx = {triangleA.SideB} e Cx = {triangleA.SideC}");
        Console.WriteLine($"Measurements of the sides of the triangle Y: Ay = {triangleB.SideA}, By = {triangleB.SideB} e Cy = {triangleB.SideC}");

        double areaX        = triangleA.CalculateArea();
        double areaY        = triangleB.CalculateArea();

        Console.WriteLine($"Triangle area X: {areaX:F4}");
        Console.WriteLine($"Triangle area Y: {areaY:F4}");

        string resultCompareArea = CompareAreaTriangles(areaX, areaY);

        Console.WriteLine(resultCompareArea);
    }

    private static string CompareAreaTriangles(double areaX, double areaY)
    {
        if (areaX < areaY)
            return $"The area of triangle Y is greater: {areaY:F4}";
        else if (areaX > areaY)
            return $"The area of triangle X is greater: {areaX:F4}";
        else
            return $"Triangles have the same area: {areaY:F4}";
    }
    #endregion

    #region Product
    private static void ProductInfo()
    {
        Products tv     = new()
        {
            ProductName = "TV XLT",
            Price       = 900.00,
            Quantity    = 10,
        };

        double totalValue   = tv.TotalValueInStock();

        Console.WriteLine($"Product Data: {tv}");
        
        int addQuantity     = 5;
        tv.AddProducts(addQuantity);

        Console.WriteLine($"Updated data: {tv}");

        int removeQuantity  = 3;
        tv.RemoveProducts(removeQuantity);

        Console.WriteLine($"Updated data: {tv}");
    }
    #endregion

    #region Person
    public class Person
    {
        public string Name;
        public int Age;
    }

    private static void CompareAge()
    {
        Person maria    = new Person();
        maria.Name      = "Maria";
        maria.Age       = 19;

        Person joao     = new()
        {
            Name        = "João",
            Age         = 16
        };

        Console.WriteLine(WhoIsOlder(maria, joao));
    }

    private static string WhoIsOlder(Person firstPerson, Person secondPerson)
    {
        if (firstPerson.Age == secondPerson.Age)
            return $"{firstPerson.Age} and {secondPerson.Age} be the same age";
        
        return firstPerson.Age >= secondPerson.Age ? $"Older person: {firstPerson.Age}" : $"Pessoa mais velha: {secondPerson.Age}";
    }
    #endregion

    #region Calculate Average Salary
    public class Employee
    {
        public string Name;
        public double Salary;
    }

    private static void CalculateAverageSalary()
    {
        Employee pablo  = new Employee() { Name = "Lucas", Salary = 1800 };

        Employee pedro  = new Employee() { Name = "Pedro", Salary = 2800 };

        string average  = AverageSalary(pablo.Salary, pedro.Salary);

        Console.WriteLine(average);
    }

    private static string AverageSalary(double firstSalary, double secondSalary)
    {
        double averageSalary = (firstSalary + secondSalary) / 2;

        return $"Average Salary: R$ {averageSalary}";
    }
    #endregion
}