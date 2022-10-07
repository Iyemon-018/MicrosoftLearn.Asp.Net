namespace PizzaStore.DB;

public record Pizza
{
    public int Id { get; set; }

    public string? Name { get; set; }
}

public class PizzaDB
{
    private static readonly List<Pizza> _pizzas = new()
    {
     new Pizza{ Id=1, Name="Montemagno, Pizza shaped like a great mountain" },
     new Pizza{ Id=2, Name="The Galloway, Pizza shaped like a submarine, silent but deadly"},
     new Pizza{ Id=3, Name="The Noring, Pizza shaped like a Viking helmet, where's the mead"}
    };

    public static List<Pizza> GetPizzas() => _pizzas;

    public static Pizza? GetPizza(int id) => _pizzas.SingleOrDefault(p => p.Id == id);

    public static Pizza CreatePizza(Pizza pizza)
    {
        if (_pizzas.Any(p => p.Id == pizza.Id)) throw new Exception($"ID:{pizza.Id} Pizza is exist.");

        _pizzas.Add(pizza);
        return pizza;
    }

    public static Pizza UpdatePizza(Pizza pizza)
    {
        var oldPizza = _pizzas.FirstOrDefault(p => p.Id == pizza.Id);
        if (oldPizza is null) throw new Exception($"ID:{pizza.Id} Pizza is not found.");

        oldPizza.Name = pizza.Name;
        return oldPizza;
    }

    public static void RemovePizza(int id) => _pizzas.Remove(GetPizza(id));
}