namespace PracticeProject.DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class Tablet : IProduct
    {
        private double _price;
        public string GetName()
        {
            return "Tablet";
        }

        public string SetPrice(double price)
        {
            _price = price;
            return "success";
        }
    }
}