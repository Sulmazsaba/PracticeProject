namespace PracticeProject.DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class Phone : IProduct
    {
        private double _price;
        public string GetName()
        {
            return "Phone";
        }

        public string SetPrice(double price)
        {
            _price = price;
            return "success";
        }
    }
}