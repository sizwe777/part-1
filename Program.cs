class Recipe
{
    private string[] ingredients;
    private string[] steps;
    private string[] originalIngredients;

    public string[] Ingredients
    {
        get { return ingredients; }
        set { ingredients = value; }
    }

    public string[] Steps
    {
        get { return steps; }
        set { steps = value; }
    }

    public Recipe()
    {
        ingredients = new string[0];
        steps = new string[0];
    }

    public void AddIngredient(string name, double quantity, string unit)
    {
        Array.Resize(ref ingredients, ingredients.Length + 1);
        ingredients[ingredients.Length - 1] = $"{name} - {quantity} {unit}";
    }

    public void AddStep(string stepDescription)
    {
        Array.Resize(ref steps, steps.Length + 1);
        steps[steps.Length - 1] = stepDescription;
    }

    public void DisplayRecipe()
    {
        Console.WriteLine("Ingredients:");
        foreach (string ingredient in ingredients)
        {
            Console.WriteLine(ingredient);
        }

        Console.WriteLine("\nSteps:");
        for (int i = 0; i < steps.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {steps[i]}");
        }
    }

    public void ScaleRecipe(double factor)
    {
        for (int i = 0; i < ingredients.Length; i++)
        {
            string[] parts = ingredients[i].Split('-');
            double quantity = Convert.ToDouble(parts[1].Split(' ')[1]);
            quantity *= factor;
            ingredients[i] = $"{parts[0]} - {quantity} {parts[1].Split(' ')[1]}";
        }
    }

    public void ResetQuantities()
    {
        Array.Copy(originalIngredients, ingredients, originalIngredients.Length);
    }

    public void ClearRecipe()
    {
        ingredients = new string[0];
        steps = new string[0];
    }

    public void SaveOriginalIngredients()
    {
        originalIngredients = new string[ingredients.Length];
        Array.Copy(ingredients, originalIngredients, ingredients.Length);
    }

    public void ClearAll()
    {
        ClearRecipe();
        originalIngredients = new string[0];
    }

    public void AddCustomRecipe(string[] customIngredients, string[] customSteps)
    {
        ClearRecipe();
        ingredients = customIngredients;
        steps = customSteps;
        SaveOriginalIngredients();
    }
}