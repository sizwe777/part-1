class Program
{
    static void Main()
    {
        Recipe recipe = new Recipe();

        Console.Write("Enter the number of ingredients: ");
        int numIngredients = int.Parse(Console.ReadLine());
        for (int i = 0; i < numIngredients; i++)
        {
            Console.Write("Enter the ingredient name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the quantity: ");
            double quantity = double.Parse(Console.ReadLine());
            Console.Write("Enter the unit of measurement: ");
            string unit = Console.ReadLine();
            recipe.AddIngredient(name, quantity, unit);
        }

        Console.Write("Enter the number of steps: ");
        int numSteps = int.Parse(Console.ReadLine());
        for (int i = 0; i < numSteps; i++)
        {
            Console.Write("Enter step description: ");
            string step = Console.ReadLine();
            recipe.AddStep(step);
        }

        recipe.DisplayRecipe();

        int option;
        do
        {
            Console.WriteLine("1. Scale Recipe\n2. Reset Quantities\n3. Clear Recipe\n4. View Recipe\n5. Exit");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter scale factor (0.5, 2, 3): ");
                    double scaleFactor = double.Parse(Console.ReadLine());
                    recipe.ScaleRecipe(scaleFactor);
                    recipe.DisplayRecipe();
                    break;
                case 2:
                    recipe.ResetQuantities();
                    recipe.DisplayRecipe();
                    break;
                case 3:
                    recipe.ClearRecipe();
                    Console.WriteLine("Recipe data cleared.");
                    break;
                case 4:
                    recipe.DisplayRecipe();
                    break;
                case 5:
                    Console.WriteLine("Exiting the program.");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        } while (option != 5);
    }
}