namespace OnlineStore
{
    class ProductInfo
    {
        private string p_name;
        private float p_price;
        private string p_category;
        private Brand p_brand;

        public ProductInfo()
        {
            p_name = string.Empty;
            p_price = 0;
            p_category = string.Empty;
            p_brand = new Brand();
        }

        public string GetName()
        {
            return p_name;
        }

        public float GetPrice()
        {
            return p_price;
        }

        public string GetCategory()
        {
            return p_category;
        }

        public void SetName(string name)
        {
            p_name = name;
        }

        public void SetPrice(float price)
        {
            p_price = price;
        }

        public void SetCategory(string category)
        {
            p_category = category;
        }

        public void SetBrand(BrandInfo bInfo)
        {
            p_brand.SetBrandInfo(bInfo);
        }

        public BrandInfo GetBrand()
        {
            return p_brand.GetBrandInfo();
        }
    }
}
