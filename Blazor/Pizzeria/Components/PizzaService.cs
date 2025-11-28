namespace Pizeria.Components
{
    public class PizzaService
    {
        // el servicio usa una llamada asincrónica para acceder a los datos y
        // devolver una colección de Pizza objetos.
        public async Task<PizzaDatos[]> GetPizzasAsync()
        {
            await Task.Delay(300);

            return new PizzaDatos[]
            {
                 new PizzaDatos { Name = "Hawaiian", Description = "Ham and pineapple", vegan = false, vegetarian = false, Prize = 12.00M },
                 new PizzaDatos { Name = "Veggie Supreme", Description = "Loaded with vegetables", vegan = true, vegetarian = true, Prize = 11.50M },
                 new PizzaDatos { Name = "Meat Lovers", Description = "Pepperoni, sausage, bacon", vegan = false, vegetarian = false, Prize = 13.75M }
            };
        }

    }
}
