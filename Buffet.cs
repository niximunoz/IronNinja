class Buffet
{
    public List<Food> Menu;
    public List<Drink> Driks;

    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Sandiwch", 100, true, false),
            new Food("Pizza", 890, false, false),
            new Food("Sushi", 500, false, true),
            new Food("Empanadas", 400, false, false),
            new Food("Carne", 660, true, false),
            new Food("Pollo", 790, true, true),
            new Food("Tallarines", 600, true, false)
        };
        Driks = new List<Drink>()
        {
            new Drink("Sandiwch", 100, true, false),
            new Drink("Pizza", 890, false, false)
        };
    }

    public Food Serve()
    {
        Random rand = new Random();
        int FoodRandom = rand.Next(Menu.Count());
        return Menu[FoodRandom];
    }
}