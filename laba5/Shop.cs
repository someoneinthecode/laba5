class Shop : ISearchable
{
    public List<User> Users { get; set; } = new List<User>();
    public List<Tovar> Tovary { get; set; } = new List<Tovar>();
    public List<Order> Orders { get; set; } = new List<Order>();

    // Метод для додавання нового користувача
    public void AddUser(User user)
    {
        Users.Add(user);
    }

    // Метод для додавання нового товару
    public void AddTovar(Tovar tovar)
    {
        Tovary.Add(tovar);
    }

    // Метод для оформлення нового замовлення
    public void PlaceOrder(User user, List<Tovar> items, int quantity)
    {
        var order = new Order { Items = items, Quantity = quantity, Status = "Processing" };
        user.PurchaseHistory.Add(order);
        Orders.Add(order);
    }

    // Реалізація пошукового інтерфейсу
    public List<Tovar> SearchByCriteria(List<Tovar> tovary, Func<Tovar, bool> criteria)
    {
        return tovary.Where(criteria).ToList();
    }
}