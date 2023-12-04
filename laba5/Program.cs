class Program
{
    static void Main()
    {
        // Створення магазину
        var shop = new Shop();

        // Додавання користувача і товарів
        var user = new User { Login = "user1", Password = "pass123" };
        shop.AddUser(user);

        var tovar1 = new Tovar { Name = "Товар1", Price = 10.50m, Category = "Категорія1", Rating = 4 };
        var tovar2 = new Tovar { Name = "Товар2", Price = 20.75m, Category = "Категорія2", Rating = 5 };
        shop.AddTovar(tovar1);
        shop.AddTovar(tovar2);

        // Пошук товарів за категорією
        var searchResults = shop.SearchByCriteria(shop.Tovary, t => t.Category == "Категорія1");

        // Оформлення замовлення
        shop.PlaceOrder(user, searchResults, 2);

        // Виведення історії покупок користувача
        Console.WriteLine($"Історія покупок користувача {user.Login}:");
        foreach (var order in user.PurchaseHistory)
        {
            Console.WriteLine($"Замовлення: {string.Join(", ", order.Items.Select(item => item.Name))}");
            Console.WriteLine($"Кількість: {order.Quantity}, Загальна вартість: {order.TotalCost:C}, Статус: {order.Status}");
            Console.WriteLine();
        }
    }
}
