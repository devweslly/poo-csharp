using System.Globalization;

namespace Chapter01
{
    public class Products
    {
        public string   ProductName;
        public double   Price;
        public int      Quantity;

        public double TotalValueInStock()
        {
            Console.WriteLine($"Calculating total value in stock of the product: {ProductName}.");
            double totalValue = Price * Quantity;

            return totalValue;
        }

        public void AddProducts(int quantity)
        {
            Console.WriteLine($"Adding '{quantity}' product units: {ProductName}.");
            Quantity += quantity;
        }

        public void RemoveProducts(int quantity)
        {
            Console.WriteLine($"Remove '{quantity}' product units: {ProductName}.");
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return  $"\nName: {ProductName}" +
                    $"\nPrice: {Price.ToString("F2", CultureInfo.InvariantCulture)}" +
                    $"\nQuantity in stock: {Quantity} units" +
                    $"\nTotal: R$ {TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture)}" +
                    $"\n-------------------------------------------------------";
        }
    }
}
