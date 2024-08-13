namespace akkayasoftOnlineOtomasyonProjesi.Models.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public int ProductStock { get; set; }
        public bool ProductState { get; set; }
        public string ProductImage { get; set; }
        public int ProductPriceTake { get; set; }
        public int ProductPriceSale { get; set; }

    }
}
