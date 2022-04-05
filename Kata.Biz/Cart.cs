namespace Kata.Biz
{
    public class Cart
    {
        public List<Item> CartItems { get; private set; } = new List<Item>();
        public decimal Total { get; private set; } = 0M;
        private readonly IPromotionsProcessor _promotionsProcessor;

        public Cart(IPromotionsProcessor promosProcessor)
        {
            this._promotionsProcessor = promosProcessor;
        }

        public void AddToCart(Item item)
        {
            CartItems.Add(item);
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            this.Total = 0;

            foreach (Item item in CartItems)
            {
                Total += item.UnitPrice;
            }

            this._promotionsProcessor.ApplyPromotions(this.CartItems.AsReadOnly(), this.ApplyDiscountToTotal);
        }

        private void ApplyDiscountToTotal(decimal amount)
        {
            this.Total -= amount;
        }
    }
}
