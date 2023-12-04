class Order
{
    public List<Tovar> Items { get; set; }
    public int Quantity { get; set; }
    public decimal TotalCost => Items.Sum(item => item.Price * Quantity);
    public string Status { get; set; }
}