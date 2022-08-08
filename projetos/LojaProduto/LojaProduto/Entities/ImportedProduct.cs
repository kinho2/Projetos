using System.Globalization;


namespace LojaProduto.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFree { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFree)
            : base(name, price)
        {
            CustomsFree = customsFree;
        }
        public double TotalPrice()
        {
           return CustomsFree += Price;
        }

        public override string PriceTag()
        {
            return Name
                + " $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs Free: $ "
                + CustomsFree.ToString("F2", CultureInfo.InvariantCulture)
                + ")";

        }
    }
}
